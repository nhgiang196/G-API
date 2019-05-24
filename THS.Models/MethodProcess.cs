using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHS.Models
{
     [Table("MethodProcess")]
    public class MethodProcess
    {       
        public MethodProcess()
        {
          
        }
        [Column("MethodID")]
        [Key]
        public string MethodID { get; set; }
        public string MethodName { get; set; }
        public string Description_EN { get; set; }
        public string Description_TW { get; set; }
        public string Description_CN { get; set; }
        public string Description_VN { get; set; }
        public int Status { get; set; }   
        //public string UserID { get; set; }
        //public Nullable<System.DateTime> CreateTime { get; set; }
        //public Nullable<System.DateTime> Stamp { get; set; }
        //public string Status { get; set; }
     
    }
}
