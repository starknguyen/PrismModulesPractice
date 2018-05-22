using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public enum Universe : int
    {
        /// <summary>
        /// Main Universe
        /// </summary>
        EARTH_616,

        /// <summary>
        /// Marvel Cinematic Universe
        /// </summary>
        EARTH_199999,

        /// <summary>
        /// X-Men Days of Future Past
        /// </summary>
        EARTH_811,

        ASGARD,

        SOMEWHERE_IN_THE_GALAXY,

        UNKNOWN
    }

    public class AvengersManager
    {
        public string MemberRealName { get; set; }

        public string MemberCodeName { get; set; }

        public Universe MemberUniverse { get; set; }
    }
}
