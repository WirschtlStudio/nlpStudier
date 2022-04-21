using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFiles;

static public class SubjectFilesFinder
{
    //No subfolders yet
    public static string[] ListFiles(string path)
    {
        string[] files = Directory.GetFiles(path);
        return files;
    }
    public static string[] ListFiles(string path, string criteria)
    {
        string[] files = Directory.GetFiles(path, criteria);
        return files;
    }
}

