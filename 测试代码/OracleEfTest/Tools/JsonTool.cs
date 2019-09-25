using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Tools
{
    public static class JsonTool
    {
        public static object ToObject(this string jsonText, Type type)
        {
            return JsonConvert.DeserializeObject(jsonText, type);
        }

        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
