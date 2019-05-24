using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHS.Models
{
    [Table("WasteItems")]
    public  class WasteItem
    {
        public WasteItem()
        {
          
        }
        [Column("WasteID")]
        [Key]
        public string WasteID { get; set; }
        public string MethodID { get; set; }
        public string State { get; set; }
        public string ItemCode { get; set; }
        public string Description_EN { get; set; }
        public string Description_TW { get; set; }
        public string Description_CN { get; set; }
        public string Description_VN { get; set; }
        public int Status { get; set; }   
        public string CompID  { get; set; }   
      
               
    }
}
