using System;

using R5T.T0131;
using R5T.T0239;


namespace R5T.L0075.O001
{
    [ValuesMarker]
    public partial interface IDirectoryPathContextOperations : IValuesMarker
    {
        public void Ensure_DirectoryPathExists(IHasDirectoryPath context)
        {
            Instances.FileSystemOperator.Ensure_DirectoryExists(
                context.DirectoryPath);
        }
    }
}
