using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxAspNetCore.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string bankname { get; set; }

        [Column(TypeName = "varchar(11)")]
        public string SWIFTCode { get; set; }

        public int Amount { get; set; }
    }
}
