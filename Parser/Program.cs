using System.IO;

string path = @"C:\Users\hello\OneDrive\Documents\IO-Lab.txt";

FileInfo newFile = new FileInfo(path);

string line = "initial";

using (StreamReader reader = newFile.OpenText())
{
    line = reader.ReadLine();
    while (String.IsNullOrWhiteSpace(line))
    {

        string[] words = line.Split('.');
        foreach (string word in words)
        {
            using (StreamWriter writer = newFile.CreateText())
            {
                writer.WriteLine("STOP");
            }

        }
        line = reader.ReadLine();
    }
    newFile.CreateAsSymbolicLink(@"C:\Users\hello\OneDrive\Documents\IO-Lab.txt");
}