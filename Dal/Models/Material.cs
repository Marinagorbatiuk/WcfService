using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Dal
{
    public abstract  class Material
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Brand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Volume { get; set; }
        [Required]
        public int QuantityBottles { get; set; }
        [Required]
        public double QuantityGeneralVolume { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public string Color { get; set; }
        public virtual ICollection<Service> Service { get; set; }
        public virtual ICollection<WriteOffMaterial> WriteOffMaterials { get; set; }
        [Required]
        public double QuntityCount { get; set; }
    }

    public class Shampoo : Material
    {
        public override string ToString()
        {
            return "Shampoo " + Name;
        }
    }
    public class Balsam : Material
    {
        public override string ToString()
        {
            return "Balsam " + Name;
        }
    }
    public class HairColor : Material
    {
        public override string ToString()
        {
            return "Hair color " + Name;
        }
    }
    public class Laque : Material
    {
        public override string ToString()
        {
            return "Laque " + Name;
        }
    }
    public class Lipstick : Material
    {
        public override string ToString()
        {
            return "Lipstick " + Name;
        }
    }
    public class Mascara : Material
    {
        public override string ToString()
        {
            return "Mascara " + Name;
        }
    }
    public class Foundation : Material
    {
        public override string ToString()
        {
            return "Foundation " + Name;
        }
    }
    public class Powder : Material
    {
        public override string ToString()
        {
            return "Powder " + Name;
        }
    }
    public class Shadows : Material
    {
        public override string ToString()
        {
            return "Shadow " + Name;
        }
    }
    public class NailPolish : Material
    {
        public override string ToString()
        {
            return "Nail polish " + Name;
        }
    }
    public class NailTop : Material
    {
        public override string ToString()
        {
            return "Nail top " + Name;
        }
    }
    public class NailBase : Material
    {
        public override string ToString()
        {
            return "Nail base " + Name;
        }
    }

}