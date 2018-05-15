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
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
       
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Brand { get; set; }
        [Required]
        [Range(1, 1500, ErrorMessage = " was entered incorrectly")]
        public decimal Price { get; set; }
        [Required]
        [Range(1, 1500, ErrorMessage = " was entered incorrectly")]
        public double Volume { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = " was entered incorrectly")]
        public int QuantityBottles { get; set; }
        [Required]
        [Range(0, 9999999, ErrorMessage = " was entered incorrectly")]
        public double QuantityGeneralVolume { get; set; }
        [Required]
        public double QuntityCount { get; set; }
        public ICollection<BllServices> BllServices { get; set; }
    }
    public class BllBalsam : BllMaterials
    {
    }
    public class BllColor : BllMaterials
    {
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Color { get; set; }
    }
    public class BllFoundation : BllMaterials
    {
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Color { get; set; }
    }
    public class BllLaque : BllMaterials
    {
    }
    public class BllLipstick : BllMaterials
    {
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Color { get; set; }
    }
    public class BllMascara : BllMaterials
    {  
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Color { get; set; }
    }
    public class BllNailBase : BllMaterials
    {
    }
    public class BllNailPolish : BllMaterials
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Color { get; set; }
    }
    public class BllNailTop : BllMaterials
    {
    }
    public class BllPowder : BllMaterials
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Color { get; set; }
    }
    public class BllShadows : BllMaterials
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Color { get; set; }
    }
    public class BllShampoo : BllMaterials
    {        
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = " was entered incorrectly")]
        public string Description { get; set; }
    }
}
