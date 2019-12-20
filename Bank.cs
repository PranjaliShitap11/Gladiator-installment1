using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NationalScholarshipPortalApi.Models
{
    //Model class for bank
    public class Bank
    {
        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StudentID { get; set; }
        [StringLength(20)]
        public string BankName { get; set; }
        [StringLength(16)]
        public string BankAccountNumber { get; set; }
        [StringLength(15)]
        public string BankIFSCCode { get; set; }
        [StringLength(20)]
        public string BranchName { get; set; }
        //Define relationships between Bank and student model
        public virtual Student Student { get; set; }
    }
}