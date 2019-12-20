using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NationalScholarshipPortalApi.Models
{
    //Model Class for student
    public class Student
    {
        //Primary key
        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StudentID { get; set; }
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string MiddleName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [Required]
        [StringLength(8)]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }
        [StringLength(20)]
        public string Nationality { get; set; }
        [StringLength(15)]
        public string StateOfDomicile { get; set; }
        [Required]
        [StringLength(10)]
        public string MobileNo { get; set; }
        [StringLength(10)]
        public string AlternateMobileNo { get; set; }
        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(16)]
        public string AadhaarNumber { get; set; }
        [StringLength(10)]
        public string MaritalStatus { get; set; }
        [StringLength(15)]
        public string Religion { get; set; }
        [StringLength(15)]
        public string Category { get; set; }
        [StringLength(20)]
        public string Caste { get; set; }
        [StringLength(40)]
        public string StudentAddress { get; set; }
        [StringLength(15)]
        public string District { get; set; }
        [StringLength(6)]
        public string Pincode { get; set; }
        [StringLength(25)]
        public string FatherName { get; set; }
        [StringLength(20)]
        public string FatherProfession { get; set; }
        [StringLength(16)]
        public string FatherAadharNo { get; set; }
        [StringLength(25)]
        public string MotherName { get; set; }
        [StringLength(20)]
        public string MotherProfession { get; set; }
        [StringLength(16)]
        public string MotherAadharNo { get; set; }
        [StringLength(5)]
        public string Disability { get; set; }
        [StringLength(20)]
        public string DisabilityType { get; set; }

        public Nullable<double> PercentOfDisability { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string StudentPassword { get; set; }
      
        public byte[] Photograph { get; set; }

        [StringLength(10)]
        public string InstituteCode { get; set; }
       

        //Code to define relationships between different model class
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual Institute Institute { get; set; }
        public virtual ICollection<Scholarship> Scholarships { get; set; }
        public virtual Academic Academic { get; set; }
        public virtual Document Document { get; set; }
    }
}