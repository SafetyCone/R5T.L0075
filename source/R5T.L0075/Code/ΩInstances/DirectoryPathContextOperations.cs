using System;


namespace R5T.L0075
{
    public class DirectoryPathContextOperations : IDirectoryPathContextOperations
    {
        #region Infrastructure

        public static IDirectoryPathContextOperations Instance { get; } = new DirectoryPathContextOperations();


        private DirectoryPathContextOperations()
        {
        }

        #endregion
    }
}
