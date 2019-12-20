using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NationalScholarshipPortalApi.Models
{
    public class Academic
    {
        [Key]
        [ForeignKey("Student")]
        [StringLength(10)]
        public string StudentID { get; set; }
        [StringLength(30)]
        public string InstituteName { get; set; }
        [StringLength(15)]
        public string PresentCourse { get; set; }
        [StringLength(4)]
        public string PresentCourseYear { get; set; }
        [StringLength(20)]
        public string ModeOfStudy { get; set; }
        
        public Nullable<System.DateTime> ClassStartDate { get; set; }
        [StringLength(30)]
        public string UniversityBoardName { get; set; }
        [StringLength(15)]
        public string PreviousCourse { get; set; }
        [StringLength(4)]
        public string PreviousCoursePassingYear { get; set; }
        
        public Nullable<double> PreviousCoursePercent { get; set; }
        [StringLength(10)]
        public string TenthSeatNumber { get; set; }
        [StringLength(30)]
        public string TenthBoardName { get; set; }
        [StringLength(4)]
        public string TenthPassingYear { get; set; }
        
        public Nullable<double> TenthPercentObtained { get; set; }
        [StringLength(10)]
        public string TwelthSeatNumber { get; set; }
        [StringLength(30)]
        public string TwelthBoardName { get; set; }
        [StringLength(4)]
        public string TwelthPassingYear { get; set; }
        public Nullable<double> TwelthPercentObtained { get; set; }
        //Define relationships between academics and student model    
        public virtual Student Student{ get; set; }
    }
}