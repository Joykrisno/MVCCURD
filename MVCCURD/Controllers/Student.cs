using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCURD.Models;
using System;
using System.Linq;


namespace MVCCURD.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _Db;

        public StudentController(StudentContext Db)
        {
            _Db = Db;
        }

        public IActionResult StudentList()
        {
            try
            {
                var stdlist = from a in _Db.tbl_Student
                              join b in _Db.tbl_Departments
                              on a.DepID equals b.Id
                              into Dep
                              from b in Dep.DefaultIfEmpty()
                              select new Student
                              {
                                  Id = a.Id,
                                  Name = a.Name,
                                  Fname = a.Fname,
                                  Mobile = a.Mobile,
                                  Email = a.Email,
                                  Description = a.Description,
                                  DepID = a.DepID,
                                  Department = b == null ? "" : b.Departments
                              };

                return View(stdlist);

            }
            catch (Exception ex)
            {
                // Handle the exception here or log it
                return View();
            }
        }
    }
}


 
