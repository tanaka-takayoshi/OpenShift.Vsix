using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OpenShiftForVisualStudio.Vsix
{
    public enum GitHubUrlType
    {
        Master,
        CurrentBranch,
        CurrentRevision,
        CurrentRevisionFull
    }

    public sealed class GitAnalysis
    {
        readonly string targetFullPath;

        public bool IsDiscoveredGitRepository => targetFullPath != null;

        public string BranchName { get; } = "";
        public string RemoteName { get; } = "";
        public string RemoteURL { get; } = "";

        public GitAnalysis(string path)
        {
            string FindGit(DirectoryInfo dirinfo)
            {
                var gitpath = Path.Combine(dirinfo.FullName, ".git");
                return Directory.Exists(gitpath) ?
                        gitpath :
                        dirinfo.Parent != null ?
                            FindGit(dirinfo.Parent) : 
                            null;
            }
            targetFullPath = FindGit(new DirectoryInfo(path));

            //TODO 正規表現の方が確実
            try
            {
                var head = File.ReadLines(Path.Combine(targetFullPath, "HEAD")).First();
                BranchName = head.Replace(@"ref: refs/heads/", "");

                var configs = File.ReadAllLines(Path.Combine(targetFullPath, "config"));
                var index = Array.FindIndex(configs, l => l == $"[branch \"{BranchName}\"]");
                string line = configs[++index];
                while (!line.StartsWith("["))
                {
                    var s = line.Trim();
                    if (s.StartsWith("remote = "))
                    {
                        RemoteName = s.Replace("remote = ", "");
                        break;
                    }
                    line = configs[++index];
                }

                index = Array.FindIndex(configs, l => l == $"[remote \"{RemoteName}\"]");
                line = configs[++index];
                while (!line.StartsWith("["))
                {
                    var s = line.Trim();
                    if (s.StartsWith("url = "))
                    {
                        RemoteURL = s.Replace("url = ", "");
                        break;
                    }
                    line = configs[++index];
                }
            }
            catch (Exception)
            {
                //TODO Log
            }
            
        }
        
    }
}
