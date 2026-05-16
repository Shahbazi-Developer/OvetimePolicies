using System.Reflection;

foreach (var name in args)
{
    Assembly a = Assembly.LoadFrom(name);
    Console.WriteLine("=== " + a.GetName()?.Name + " ===");
    foreach (var t in a.GetExportedTypes().OrderBy(t => t.FullName))
        Console.WriteLine(t.FullName);
}
