using System;
using ModularDotNet.Core.Interfaces;
using ModularDotNet.Core.Managers;
using ModularDotNet.Core.Security;

namespace ModularDotNet.Core.Tests.TestMaterials.Interfaces
{
    public class Current : ICurrent
    {
        private string _Name = Guid.NewGuid().ToString();

        private EncryptionKeyPair _EncryptionKeyPair = EncryptionManager.Aes.GenerateKeyPair();

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public EncryptionKeyPair EncryptionKeyPair
        {
            get => _EncryptionKeyPair;
            set => _EncryptionKeyPair = value;
        }
    }
}
