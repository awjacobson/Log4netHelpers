using Newtonsoft.Json;
using System;

namespace Log4netHelpers.Extensions
{
    /// <summary>
    /// Extensions to the <see cref="Object"/> class.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Creates a string for displaying the state of this object in a trace log.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string ToDebugString(this Object o)
        {
            if (o == null)
            {
                return "null";
            }

            try
            {
                return JsonConvert.SerializeObject(o, Formatting.None, new JsonSerializerSettings
                {
                    /*
                     * NOTE: Be sure to add the [JsonIgnore] attribute on all naviagtion properties.
                     * Throw an error when cyclic references are found. ReferenceLoopHandling.Ignore still causes memory/cpu issues
                     */
                    ReferenceLoopHandling = ReferenceLoopHandling.Error
                });
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
