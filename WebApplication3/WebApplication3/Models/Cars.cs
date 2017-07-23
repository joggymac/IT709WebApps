using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Database.Models
{
    public class Cars
    {
        [Key]
        public int CarsID { get; set; }

        public virtual int CarBrand { get; set; }
        public CarBrand CarBrands { get; set; }

        public virtual int CarModel { get; set; }
        public CarModel CarModels { get; set; }
        [DisplayFormat(DataFormatString = "{yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
        [Required]
        public int Displacement { get; set; }

        
        public string Power { get; set; }
        [Required]
        public string Torque { get; set; }
        
        public virtual int FuelType { get; set; }
        public FuelType FuelTypes { get; set; }
        
        public virtual int DriveType { get; set; }
        public DriveType DriveTypes { get; set; }

        public int Weight { get; set; }




    }
}
