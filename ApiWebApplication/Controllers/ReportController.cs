using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Extensions;
using ApiWebApplication.Models;
using SelectPdf;

namespace ApiWebApplication.Controllers
{
    public class ReportController : Controller
    {
        SchoolDbContext dbContext=new SchoolDbContext();
        IQueryable<TuitionDTO> TuitionDTOs { 
            get
            {
                return dbContext.Tuitions
                    .Include("Students")
                    .Include("WorkingDays")
                    .Include("Course")
                    .Include("Status")
                    .Include("Strangenesses")
                    .Include("Concepts")
                    .Select(x => new TuitionDTO
                    {
                        Id = x.Id,
                        Code = x.Code,
                        Student = x.Student,
                        StudentId = x.StudentId,
                        WorkingDay = x.WorkingDay,
                        WorkingDayId = x.WorkingDayId,
                        Course = x.Course,
                        CourseId = x.CourseId,
                        FirstDate = x.FirstDate,
                        LastDate = x.LastDate,
                        MonthValue = x.MonthValue,
                        TutionValue = x.TutionValue,
                        Status = x.Status,
                        StatusId = x.StatusId,
                        Strangenesses = x.Strangeness.Where(a => a.TuitionId == x.Id).Select(st => new StrangenessDTO
                        {
                            Id = st.Id,
                            Code = st.Code,
                            TuitionId = st.TuitionId,
                            Course = x.Course.Code + " " + x.Course.Name,
                            ConceptId = st.ConceptId,
                            Date = st.Date,
                            Detail = st.Detail,
                            Concept = st.Concept,

                        }).ToList()

                    });

            } 
        }
        public FileResult GetFileStudent(int courseid)
        {
            CourseDTO course = dbContext.Courses.Where(x => x.Id == courseid).Select(x => new CourseDTO 
            {
                Id=x.Id,
                Code=x.Code,
                Name=x.Name ,
                Description=x.Description,
                Amount=x.Amount ,
            }).FirstOrDefault();
            TempData["course"] = course ;
            List<TuitionDTO> tuitions=TuitionDTOs.Where(x=>x.CourseId==courseid).ToList();
            string htmlString = this.RenderRazorViewToString("StudentByCousePdf", tuitions);
            PdfPageSize pageSize = PdfPageSize.A4;
            PdfPageOrientation pdfOrientation = PdfPageOrientation.Portrait;
            int webPageWidth = 1500;
            HtmlToPdf htmlToPdf = Utilities .GetHtmlToPdf(pageSize, pdfOrientation, webPageWidth);
            byte[] pdf = Utilities .ConvertPdfToByte(htmlString, htmlToPdf);
            return File(pdf, "application/pdf");
        }

        // GET: Report
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Report/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Report/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Report/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Report/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Report/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Report/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Report/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
