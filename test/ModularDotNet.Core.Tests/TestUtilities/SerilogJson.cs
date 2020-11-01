using Newtonsoft.Json;

namespace ModularDotNet.Core.Tests.TestUtilities
{
    public static class SerilogJson
    {
        #region Methods

        public static string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value)
                        .Replace("\"", "")
                        .Replace("{", "{ ")
                        .Replace("}", " }")
                        .Replace(":", ": ")
                        .Replace(",", ", ");
        }

        #endregion
    }
}
