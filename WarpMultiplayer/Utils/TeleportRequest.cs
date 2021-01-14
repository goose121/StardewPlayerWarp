using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpMultiplayer.Utils
{
    class TeleportRequest
    {
        public static readonly string Type = "BringPlayerRequest";

        public string FromFarmerName { get; set; }
        public Farmer FromFarmer { get; set; }

        public TeleportRequest(Farmer fromFarmer)
        {
            this.FromFarmer = fromFarmer;
            this.FromFarmerName = fromFarmer.name;
        }

        public TeleportRequest()
        {
            // default ctor for serialization
        }
    }
}
