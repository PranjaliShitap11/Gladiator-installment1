using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NationalScholarshipPortalApi.Models
{
    //Model class for Institute
    public class Institute
    {
        //Primary key 
        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string InstituteCode { get; set; }

        [Required]
        [StringLength(30)]
        public string InstituteName { get; set; }
        [Required]
        [StringLength(10)]
        public string Location { get; set; }
        [Required]
        [StringLength(40)]
        public string InstituteAddress { get; set; }
        [Required]
        [StringLength(20)]
        public string InstituteState { get; set; }
        [Required]
        [StringLength(20)]
        public string District { get; set; }
        [Required]
        [StringLength(20)]
        public string InstituteType { get; set; }
        [Required]
        [StringLength(20)]
        public string Affiliated { get; set; }

        [Required]
        [StringLength(10)]
        public string AffiliatedUniversityId { get; set; }

        [Required]
        public System.DateTime YearFromAdmissionStarted { get; set; }

        [Required]
        [StringLength(30)]
        public string PrincipalName { get; set; }
        [Required]
        [StringLength(10)]
        public string InstituteContactNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20)]
        public string InstitutePassword { get; set; }

        //Documents Submitted by institute
        public byte[] RegistrationCertificate { get; set; }
        public byte[] BoardAffiliationCertificate { get; set; }

        //Define relationships between institute and student model
        public virtual ICollection<Student> Students { get; set; }
        
    }
}