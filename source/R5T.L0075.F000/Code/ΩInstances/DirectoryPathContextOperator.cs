using System;


namespace R5T.L0075.F000
{
    public class DirectoryPathContextOperator : IDirectoryPathContextOperator
    {
        #region Infrastructure

        public static IDirectoryPathContextOperator Instance { get; } = new DirectoryPathContextOperator();


        private DirectoryPathContextOperator()
        {
        }

        #endregion
    }
}
