using System.ComponentModel;
using ModularDotNet.Core.Attributes;

namespace ModularDotNet.Core.Tests.TestMaterials.Enums
{
    public enum EnumGender
    {
        [Description("")]
        NotSpecific,
        
        Male,

        [DisplayText("female")]
        Female
    }
}
