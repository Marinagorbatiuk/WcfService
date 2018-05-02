using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class BllMaterials
    {
        public int Id { get; set; }
        [Required]
       // [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        //[MaxLength(20)]
        public string Brand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Volume { get; set; }
        [Required]
        public int QuantityBottles { get; set; }
        [Required]
        public double QuantityGeneralVolume { get; set; }
     
        public ICollection<BllServices> BllServices { get; set; }
    }
    public class BllBalsam : BllMaterials
    {
    }
    public class BllColor : BllMaterials
    {
        public string Description { get; set; }
        public string Color { get; set; }
    }
    public class BllFoundation : BllMaterials
    {
        public string Description { get; set; }
        public string Color { get; set; }
    }
    public class BllLaque : BllMaterials
    {
    }
    public class BllLipstick : BllMaterials
    {
        public string Description { get; set; }
        public string Color { get; set; }
    }
    public class BllMascara : BllMaterials
    {
        public string Color { get; set; }
    }
    public class BllNailBase : BllMaterials
    {
    }
    public class BllNailPolish : BllMaterials
    {
        public string Color { get; set; }
    }
    public class BllNailTop : BllMaterials
    {
    }
    public class BllPowder : BllMaterials
    {
        public string Color { get; set; }
    }
    public class BllShadows : BllMaterials
    {
        public string Color { get; set; }
    }
    public class BllShampoo : BllMaterials
    {
        public string Description { get; set; }
    }
}
