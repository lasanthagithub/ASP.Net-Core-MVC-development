using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4App.Extensions
{
    //public static class SessionExtensions
    //{
    //    public static void SetObjectAsJson(this ISession session, string key, object value)
    //    {
    //        session.SetString(key, JsonConvert.SerializeObject(value));
    //    }

    //    public static T GetObjectFromJson<T>(this ISession session, string key)
    //    {
    //        var value = session.GetString(key);

    //        return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    //    }
    //}


    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session,
                           string key, object value)
        {
            string stringValue = JsonConvert.
                                 SerializeObject(value);
            session.SetString(key, stringValue);
        }

        public static T GetObject<T>(this ISession session,
                                     string key)
        {
            string stringValue = session.GetString(key);
            T value = JsonConvert.DeserializeObject<T>
                                  (stringValue);
            return value;
        }
    }


}
