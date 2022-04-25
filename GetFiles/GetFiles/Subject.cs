using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFiles;

/// <summary>
/// Class for a subject, to store a path and an official name of the subject.
/// </summary>
[Serializable]
public class Subject
{
    public Subject(string name, string path)
    {
        this.Name = name;
        this.Path = path;
    }

    /// <summary>
    /// Official name of subject
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Path of folder on user-file-system
    /// </summary>
    public string Path { get; set; }
}

