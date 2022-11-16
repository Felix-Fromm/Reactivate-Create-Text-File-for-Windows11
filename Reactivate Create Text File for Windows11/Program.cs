using System;
using System.Diagnostics;
using Microsoft.Win32;
public class Reactivator
{
    private static void Main()
    {
        Console.WriteLine("Do you want to get the old 'Create Textfile' back? Y/N");
        if (Console.ReadLine().ToLower() == "y")
        {
            DoWork();
            Console.WriteLine("Finish");
        } else
        {
            Console.WriteLine("Then no i guess");
        }
    }

    private static void DoWork()
    {
        RegistryKey key;
        key = Registry.ClassesRoot.CreateSubKey(".txt").CreateSubKey("ShellNew");
        key.SetValue("", "NullFile");
        key.Close();

        RegistryKey key2;
        key2 = Registry.ClassesRoot.CreateSubKey("txtfilelegacy");
        key2.SetValue("", "Text File");
        key2.Close();
    }
}
