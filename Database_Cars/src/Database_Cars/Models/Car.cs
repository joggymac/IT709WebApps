using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Database.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }

        public virtual int CarBrandID { get; set; }
        public CarBrand CarBrands { get; set; }

        public virtual int CarModelID { get; set; }
        public CarModel CarModels { get; set; }
        public int Year { get; set; }
        [Required]
        public int Displacement { get; set; }

        
        public string Power { get; set; }
        [Required]
        public string Torque { get; set; }
        
        public virtual int FuelTypeID { get; set; }
        public FuelType FuelTypes { get; set; }
        
        public virtual int DriveTypeID { get; set; }
        public DriveType DriveTypes { get; set; }

        public int Weight { get; set; }




    }
}
