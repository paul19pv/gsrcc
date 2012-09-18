using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoServerRest.GeoServer
{
    public class RestUtil
    {
        public static String entryKey(String key, Boolean value) {
            return "<entry key=\"" + key + "\">" + value + "</entry>";
        }
    }
}
