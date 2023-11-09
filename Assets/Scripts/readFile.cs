using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Windows;

public class readFile : MonoBehaviour
{
    
    private void CreateDirectoryStructure()
    {
        if (!System.IO.Directory.Exists("Assets/Text"))
        {
            System.IO.Directory.CreateDirectory("Assets/Text");
        }

        if (!System.IO.File.Exists("Assets/Text/Names.txt"))
        {
            System.IO.File.Create("Assets/Text/Names.txt").Close();
        }
    }
    private void readFileByLine()
    {
        FileStream fs = new FileStream("Assets/Text/Names.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fs);
        string line = reader.ReadLine();
        if (line == null)
        {
            Debug.Log("No Text in File :(");
        } else
        {
            while (line != null)
            {
                Debug.Log(line);
                line = reader.ReadLine();
            }
        }


    }

    private string[] ReadFileIntoArray(string path)
    {
        string[] completeFile = System.IO.File.ReadAllLines(path);
        return completeFile;
    }

    public void readFileAtOnce()
    {
        string[] names = ReadFileIntoArray("Assets/Text/Names.txt");
        string[] titles = ReadFileIntoArray("Assets/Text/Titles.txt");

        string name = names[Random.Range(0, names.Length)] + " " + titles[Random.Range(0, titles.Length)];

        return name;
        //Debug.Log(name);
    }
}
