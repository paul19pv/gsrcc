using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoServerRest.GeoServer
{
    public enum Configure
    {
        /*
         * Represents null value 
         */
        empty,
        /**
         * Only setup the first feature/coverages type available in the data
         * store/coveragestore. This is the default value.
         **/
        first,
        /**
         * Do not configure any feature types/coverages.
         */
        none,
        /**
         * cnfigure all featuretypes/coverages.
         */
        all
    }
}
