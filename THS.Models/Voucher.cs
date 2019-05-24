using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHS.Models
{
    [Table("Voucher")]
    public class Voucher
    {
        public Voucher()
        {
           
        }
        [Column("VoucherID")]
        [Key]
        public string VoucherID { get; set; }
        public string OwnerComp { get; set; }
        public string ProcessComp { get; set; }
        public string VoucherNumber { get; set; }
        public string DepartReq { get; set; }
        public string DepartProcess { get; set; }
        public string InternalPhone { get; set; }
        public string Location { get; set; }      
        public Nullable<System.DateTime> DateOut { get; set; }
        public Nullable<System.DateTime> DateComplete { get; set; }
        public string ReturnReason { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> Stamp { get; set; }
        public string Status { get; set; }

        public virtual ICollection<VoucherDetail> VoucherDetails { set; get; }
       
    }
}
