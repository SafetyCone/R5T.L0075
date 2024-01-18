using System;


namespace R5T.L0075.Construction
{
    public class Instances :
        L0055.Instances
    {
        public static L0066.IContextOperator ContextOperator => L0066.ContextOperator.Instance;
        public static IDirectoryPathContextOperations DirectoryPathContextOperations => L0075.DirectoryPathContextOperations.Instance;
        public static IDirectoryPathContextOperator DirectoryPathContextOperator => L0075.DirectoryPathContextOperator.Instance;
    }
}