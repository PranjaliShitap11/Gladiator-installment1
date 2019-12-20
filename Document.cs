using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NationalScholarshipPortalApi.Models
{
    //Model class for documents submitted by student
    public class Document
    {
        [Key]
        [ForeignKey("Student")]
        [StringLength(10)]

        public string StudentID { get; set; }
        public byte[] DomicileCertificate { get; set; }
        public byte[] InstituteIDCard { get; set; }
        public byte[] CastIncomeCertificate { get; set; }
        public byte[] PreviousYearMarksheet { get; set; }
        public byte[] FeeReceiptOfCurrentYear { get; set; }
        public byte[] BankPassbook { get; set; }
        public byte[] AadharCard { get; set; }
        public byte[] SscMarksheet { get; set; }
        public byte[] HscMarksheet { get; set; }

        //Code to define relationship between studentand document class
        public virtual Student Student { get; set; }
    }
}