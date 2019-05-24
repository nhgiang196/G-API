using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.Models
{
    [Table("ChucDanh")]
    public class ChucDanh
    {
        public ChucDanh()
        {
           
        }
        [Column("CD")]
        [Key]
        public string CD { get; set; }
        public string cdten { get; set; }

        public virtual ICollection<GiangVien> GiangViens { get; set; }
       
    }
}
