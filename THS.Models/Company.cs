using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.Models
{
    [Table("Company")]
    public class Company
    {
        public Company()
        {
           
        }
        [Column("CompID")]
        [Key]
        public string CompID { get; set; }
        public string CompName { get; set; }
        public string CompCode { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }         
    }
}
