using ModularDotNet.Core.Security;

namespace ModularDotNet.Core.Interfaces
{
    public interface ICurrent
    {
        #region Properties

        string Name { get; set; }

        EncryptionKeyPair EncryptionKeyPair { get; set; }

        #endregion
    }
}
