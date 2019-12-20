using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NationalScholarshipPortalApi.Models
{
    //DbContext class after configuring entityframework
    public class NationalScholarshipPortalDBContext:DbContext
    {
        //Constructor to disable the lazy loading to avoid runtime exceptions
         public NationalScholarshipPortalDBContext():base("name=NationalScholarshipPortalDBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        //properties with all models classes
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Institute> Institutes { get; set; }
        public virtual DbSet<Scholarship> Scholarships { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Academic> Academics { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
    }
}