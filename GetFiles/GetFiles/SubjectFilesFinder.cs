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
    /// <param name="path">Path of Parentfolder</param>
    /// <param name="searchCriteria">Criteria to get the right paths</param>
    /// <returns>Returns a String-List with paths</returns>
    public static List<string> GetAllFilePaths(string path, string searchCriteria)
    {
        // at first, gets a list of directories and then collects paths within these directories
        return Directory.EnumerateFiles(path, searchCriteria).Union(
            Directory.EnumerateDirectories(path).SelectMany(o =>
            {
                try
                {
                    // recursive, because subfolders could contain files too.
                    return GetAllFilePaths(o, searchCriteria);
                }
                catch (Exception)
                {
                    // Any error returns empty enumerable
                    return Enumerable.Empty<string>();
                }
            })).ToList<string>();
    }
}

