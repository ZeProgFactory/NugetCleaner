// See https://aka.ms/new-console-template for more information


string _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
_path += @"\.nuget\packages\";

Console.WriteLine("NugetsCleaner");
Console.WriteLine("");
Console.WriteLine(_path);

var packages = System.IO.Directory.GetDirectories(_path);

foreach (var package in packages)
{
    // Console.WriteLine(System.IO.Path.GetFileName(package));

    var versions = System.IO.Directory.GetDirectories(package);

    if (versions.Length > 1)
    {
        Console.WriteLine(System.IO.Path.GetFileName(package));

        for (int i = 0; i < versions.Length - 1; i++)
        {
            System.IO.Directory.Delete(versions[i], true);
        };
    };
};