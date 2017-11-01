using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolutionAssembliesLoader
{
    public class AssemblyLoader
    {
        public List<Assembly> Assemblies { get; private set; }

        public AssemblyLoader()
        {

            DirectoryInfo projectDirectory = getProjectDirectory();
            string solutionPath = getSolutionPath(projectDirectory);
            List<string> solutionFilecontent = solutionFileContent(solutionPath);
            Assemblies = getSolutionAssemblies(solutionFilecontent);
        }

        private DirectoryInfo getProjectDirectory()
        {
            return new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        }

        private string getSolutionPath(DirectoryInfo projectDirectory)
        {
            return projectDirectory.Parent.Parent.Parent.GetFiles().Where(p => p.Extension == ".sln").Select(p => p.FullName).First();
        }

        private List<string> solutionFileContent(string solutionPath)
        {
            return File.ReadAllLines(solutionPath).ToList();
        }

        private List<Assembly> getSolutionAssemblies(List<string> solutionFile)
        {
            List<Assembly> assemblies = new List<Assembly>();

            foreach (string solutioFileLine in solutionFile)
            {
                if (solutioFileLine.StartsWith("Project"))
                {
                    string assemblyName = solutioFileLine.Substring(solutioFileLine.IndexOf('=') + 2);
                    assemblyName = assemblyName.Substring(0, assemblyName.IndexOf(','));
                    assemblyName = assemblyName.Replace("\"", string.Empty);

                    assemblies.Add(Assembly.Load(assemblyName));
                }
            }

            return assemblies;
        }
    }
}

