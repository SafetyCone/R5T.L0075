using System;

using R5T.T0141;


namespace R5T.L0075.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Ensure_DirectoryPathExists()
        {
            /// Inputs.
            var directoryPath = Instances.DirectoryPaths.Temp;


            /// Run.
            Instances.DirectoryPathContextOperator.In_DirectoryPathContext(
                directoryPath.Value,
                Instances.DirectoryPathContextOperations.Ensure_DirectoryPathExists,
                Instances.DirectoryPathContextOperations.Open_InWindowsExplorer);
        }
    }
}
