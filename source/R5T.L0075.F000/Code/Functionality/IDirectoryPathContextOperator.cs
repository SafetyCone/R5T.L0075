using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;

using R5T.L0075.T000;


namespace R5T.L0075.F000
{
    [FunctionalityMarker]
    public partial interface IDirectoryPathContextOperator : IFunctionalityMarker,
        T000.IDirectoryPathContextOperator
    {
        public void In_DirectoryPathContext(
            string directoryPath,
            IEnumerable<Action<IDirectoryPathContext>> actions)
        {
            var directoryPathContext = this.From(directoryPath);

            Instances.ContextOperator.In_Context(
                directoryPathContext,
                actions);
        }

        public void In_DirectoryPathContext(
            string directoryPath,
            params Action<IDirectoryPathContext>[] actions)
        {
            this.In_DirectoryPathContext(
                directoryPath,
                actions.AsEnumerable());
        }
    }
}
