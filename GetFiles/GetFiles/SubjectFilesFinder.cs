using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFiles;

static public class SubjectFilesFinder
{
    /// <summary>
    /// Returns all paths of files that fit a search criteria.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="searchPattern"></param>
    /// <returns></returns>
    public static List<string> GetAllFiles(string path, string searchPattern)
    {
        return Directory.EnumerateFiles(path, searchPattern).Union(
            Directory.EnumerateDirectories(path).SelectMany(d =>
            {
                try
                {
                    return GetAllFiles(d, searchPattern);
                }
                catch (Exception)
                {
                    return Enumerable.Empty<string>();
                }
            })).ToList<string>();
    }
}

