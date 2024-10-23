using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Avalonia.Platform.Storage;

namespace YesserCalculator.Utilities;

public static class AssemblySelector
{
    public static async Task<IEnumerable<Assembly>?> SelectAssemblies(IStorageProvider storageProvider, string? message)
    {
        var files = await storageProvider.OpenFilePickerAsync(new FilePickerOpenOptions()
        {
            Title = message,
            AllowMultiple = true,
            FileTypeFilter = new [] {new FilePickerFileType("dll")}
        });

        List<Assembly> assemblies = [];
        
        try
        {
            assemblies.AddRange(files.Select(file => Assembly.LoadFile(file.Path.AbsolutePath)));
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found: {e.Message}");
            throw;
        }
        

        return assemblies;
    }
}