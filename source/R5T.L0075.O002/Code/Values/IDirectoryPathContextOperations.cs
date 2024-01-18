using System;

using R5T.T0131;
using R5T.T0239;


namespace R5T.L0075.O002
{
    [ValuesMarker]
    public partial interface IDirectoryPathContextOperations : IValuesMarker
    {
        public void Open_InWindowsExplorer(IHasDirectoryPath context)
        {
            Instances.WindowsExplorerOperator.OpenDirectoryInExplorer(
                context.DirectoryPath);
        }
    }
}
