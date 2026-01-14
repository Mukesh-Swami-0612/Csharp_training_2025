using System;
using System.IO;

class FileWriteStreamWriterDemo
{
    static void Main(string[] args)
    {
        // Array of strings that we want to write in file
        string[] lines = { "First Line", "Second Line", "Third Line" };

        // Getting the Documents folder path from system
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Creating file path inside Documents folder
        string filePath = Path.Combine(docPath, "output.txt");

        // StreamWriter is used to write text into a file
        // "using" ensures file closes automatically after writing
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            // Writing each line into file
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }
        }

        // Print where file is created
        Console.WriteLine("✅ File created at: " + filePath);
    }
}
