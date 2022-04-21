using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFiles;

[Serializable]
public class Subject
{
    public Subject(string name, string path)
    {
        this.Name = name;
        this.Path = path;
    }
    public string Name { get; set; }
    public string Path { get; set; }
}

