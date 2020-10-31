using System.Collections.Generic;
using DryIoc;

namespace ModularDotNet.Core.Interfaces
{
    public interface IModule
    {
        #region Properties

        string Id { get; }

        string Name { get; }

        string Description { get; }

        string Version { get; }

        IEnumerable<string> Dependencies { get; }

        #endregion

        #region Methods

        void ConfigureServices(IRegistrator registrator);

        #endregion
    }
}
