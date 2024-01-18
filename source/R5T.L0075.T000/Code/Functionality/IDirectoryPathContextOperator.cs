using System;

using R5T.T0132;
using R5T.T0231.Extensions;


namespace R5T.L0075.T000
{
    [FunctionalityMarker]
    public partial interface IDirectoryPathContextOperator : IFunctionalityMarker
    {
        public IDirectoryPathContext From(string directoryPath)
        {
            var directoryPath_StronglyTyped = directoryPath.ToDirectoryPath();

            var output = new DirectoryPathContext(directoryPath_StronglyTyped);
            return output;
        }
    }
}
