using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NationalScholarshipPortalApi.Models
{
    //Model class for scholarship form details
    public class Scholarship
    {
        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ApplicationId { get; set; }
        [StringLength(10)]
        public string StudentID { get; set; }
        [StringLength(30)]
        public string InstituteName { get; set; }
        [StringLength(20)]
        public string Scheme { get; set; }
        public Nullable<double> AdmissionFee { get; set; }
        public Nullable<double> TutionFee { get; set; }
        public Nullable<double> OtherFee { get; set; }

        [StringLength(15)]
        public string StudentStatus { get; set; } 
        [StringLength(10)]
        public string InstituteLevelStatus { get; set; }
        [StringLength(10)]
        public string NodalOfficerLevelStatus { get; set; }
        [StringLength(10)]
        public string MinistryLevelStatus { get; set; }
               
        public virtual Student Student { get; set; }
    }
}