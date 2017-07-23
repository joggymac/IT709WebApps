using Car_Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carinfo.Models
{
    public class Subaru
    {
        [Key]
        public int SubaruID { get; set; }

        public virtual int CarModelID { get; set; }
        public CarModel CarModels { get; set; }
        public string Year { get; set; }
        [Required]
        public int Displacement { get; set; }

        public virtual int CylinderID { get; set; }
        public Cylinder Cylinders { get; set; }

        public string Power { get; set; }
        [Required]
        public string Torque { get; set; }

        public virtual int FuelTypeID { get; set; }
        public FuelType FuelTypes { get; set; }

        public virtual int DriveTypeID { get; set; }
        public DriveType DriveTypes { get; set; }

        public virtual int GearBoxID { get; set; }
        public GearBox GearBoxes { get; set; }

        public int Weight { get; set; }

        public string img { get; set; }
    }
}
