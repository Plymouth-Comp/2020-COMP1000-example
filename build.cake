var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
#tool nuget:?package=xunit.runner.console&version=2.4.1

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .WithCriteria(c => HasArgument("rebuild"))
    .Does(() =>
{
    CleanDirectory($"./Exercise/bin/{configuration}");
});

Task("Build")
  .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetCoreBuild("./Exercises.sln", new DotNetCoreBuildSettings
    {
        Configuration = configuration,
    });
});

Task("Tests")
  //.IsDependentOn("Build")
  .Does(() =>
{
	var testAssemblies = GetFiles(string.Format("./*.Tests/bin/{0}/**/*.Tests.dll",configuration));
	foreach (var assembly in testAssemblies)
	{
		Information(string.Format("runningtests on: {0}", assembly.ToString()));
		DotNetCoreTest(assembly.ToString());
	};
	Information("there");
    
    
}).OnError(exception =>
{
    Information("Some Unit Tests failed...");
});

Task("Default")
  .IsDependentOn("Tests");


//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
