using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class WriteOffMaterialBll
    {
        public int Id { get; set; }
        [Required]
        public int UsedQuantity { get; set; }
        public virtual BllMaterials Material { get; set; }
    }
}
