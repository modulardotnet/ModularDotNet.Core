using ModularDotNet.Core.Security;

namespace ModularDotNet.Core.Interfaces
{
    public interface ICurrent
    {
        #region Properties

        string Name { get; set; }

        EncryptionKey EncryptionKey { get; set; }

        #endregion
    }
}