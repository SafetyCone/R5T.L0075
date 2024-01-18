using System;

using R5T.T0137;
using R5T.T0231;


namespace R5T.L0075.T000
{
    [ContextImplementationMarker, ContextTypeMarker]
    public class DirectoryPathContext :
        IDirectoryPathContext
    {
        public IDirectoryPath DirectoryPath { get; }

        string T0239.IHasDirectoryPath.DirectoryPath => this.DirectoryPath.Value;


        public DirectoryPathContext(IDirectoryPath directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }
    }
}
