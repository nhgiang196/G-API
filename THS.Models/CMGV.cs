using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.Models
{
    [Table("CMGV")]
    public class CMGV
    {
        public CMGV()
        {
           
        }
        [Column("gv")]
        [Key]
        public string gv { get; set; }
        public string cm { get; set; }

    }
}
