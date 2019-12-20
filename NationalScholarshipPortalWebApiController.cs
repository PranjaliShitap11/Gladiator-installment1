using NationalScholarshipPortalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace NationalScholarshipPortalApi.Controllers
{
    //Defining Route prefix
    [RoutePrefix("api/Scholarship")]

    //StudentController
    public class NationalScholarshipPortalWebApiController : ApiController
    {
        //Creating object of Context Class
        NationalScholarshipPortalDBContext dbObj = new NationalScholarshipPortalDBContext();

        //Method to retrieve all students from table
        [HttpGet]
        [Route("")]
        //Get: /api/scholarship
        public IQueryable<Student> GetStudents()
        {
         
            try
            {
                return dbObj.Students;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Method to create new entry in student table
        //Post: /api/scholarship
        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateEntry(Student studentObj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                dbObj.Students.Add(studentObj);
                dbObj.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(studentObj);
        }
    }
}
