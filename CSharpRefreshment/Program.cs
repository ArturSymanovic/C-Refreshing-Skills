using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.Math;
using System.IO;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            FileStream fStream1 = fileInfo.OpenRead();

            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\charpfundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }

            var directories = Directory.GetDirectories(@"c:\projects", "*,*", SearchOption.AllDirectories);
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }

            Directory.Exists("...");
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();



        }
    }
}