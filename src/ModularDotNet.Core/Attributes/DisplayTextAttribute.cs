using System;

namespace ModularDotNet.Core.Attributes
{
    public sealed class DisplayTextAttribute : Attribute
    {
        #region Properties

        public string DisplayText { get; set; }

        #endregion

        #region Constructor

        public DisplayTextAttribute(string displayText)
        {
            DisplayText = displayText;
        }

        #endregion
    }
}
