using NuGet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalWinDownloader
{
    class KerbalProjectSystem : PhysicalFileSystem, IProjectSystem
    {
        private string _KerbalDirectory;

        public KerbalProjectSystem(string kerbalDirectory)
            : base(Path.Combine(kerbalDirectory, "Gamedata"))
        {
            _KerbalDirectory = kerbalDirectory;
        }

        public string ProjectName
        {
            get { return "GameData"; }
        }

        public string ResolvePath(string path)
        {
            return Path.Combine(_KerbalDirectory, "GameData",  path);
        }

        public System.Runtime.Versioning.FrameworkName TargetFramework
        {
            get { return new System.Runtime.Versioning.FrameworkName("Kerbal, version=v1.0");  }
        }

        public void AddFrameworkReference(string name)
        {
            throw new NotImplementedException();
        }

        public void AddImport(string targetPath, ProjectImportLocation location)
        {
            throw new NotImplementedException();
        }

        public void AddReference(string referencePath, System.IO.Stream stream)
        {
            throw new NotImplementedException();
        }

        public bool FileExistsInProject(string path)
        {
            return false; //TODO: Figure out what to do for this
            //throw new NotImplementedException();
        }

        public bool IsBindingRedirectSupported
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsSupportedFile(string path)
        {
            return true;
            //throw new NotImplementedException();
        }

        public bool ReferenceExists(string name)
        {
            throw new NotImplementedException();
        }

        public void RemoveImport(string targetPath)
        {
            throw new NotImplementedException();
        }

        public void RemoveReference(string name)
        {
            throw new NotImplementedException();
        }

        public dynamic GetPropertyValue(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}
