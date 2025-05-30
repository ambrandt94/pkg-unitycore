using System;

namespace ChainLink.Core
{
    public static class ChainLinkSerializer
    {
        public static string ToJson<T>(T obj)
        {
            return System.Text.Encoding.UTF8.GetString(ES3.Serialize<T>(obj));
        }

        public static T FromJson<T>(string json)
        {
            return ES3.Deserialize<T>(System.Text.Encoding.UTF8.GetBytes(json));
        }

        public static string ToString64<T>(T obj)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ToJson<T>(obj)));
        }

        public static T FromString64<T>(string text)
        {
            return FromJson<T>(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text)));
        }
    }
}