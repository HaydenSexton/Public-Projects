using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCS_Compendium
{
    public class VehicleDBSetup
    {
        [Key] public int VehicleID { get; set; }
        public string VehicleName { get; set; } = string.Empty;
        public string VehicleType { get; set; } = string.Empty;
        public string VehicleClass { get; set; } = string.Empty;
        public string VehicleImagePath { get; set; } = string.Empty;
        public string VehicleWeakness { get; set; } = string.Empty;
        public string VehicleDescription { get; set; } = string.Empty;
    }
}
