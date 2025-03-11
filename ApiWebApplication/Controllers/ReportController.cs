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
        PdfPageSize pageSize = PdfPageSize.A4;
        PdfPageOrientation pdfOrientation = PdfPageOrientation.Portrait;
        int webPageWidth = 1500;
        StudentDTO GetStudent(int id)
        {
            return dbContext.Students
                           .Include("Sexes")
                           .Include("Status")
                           .Include("Pictures")
                           .Include("PicturePersons")
                           .Include("Attendants")
                           .Include("IdentificationTypes")
                           .Where(s=>s.Id ==id )
                           .Select(x => new StudentDTO
                           {
                               Id = x.Id,
                               FirstName = x.FirstName,
                               LastName = x.LastName,
                               Address = x.Address,
                               PhoneNumber = x.PhoneNumber,
                               Email = x.Email,
                               BirthDate = x.BirthDate,
                               Identification = x.Identification,
                               IdentificationType = x.IdentificationType,
                               Sex = x.Sex,
                               SexId = x.SexId,
                               IdentificationTypeId = x.IdentificationTypeId,
                               Attendant = x.Attendant,
                               AttendantId = x.AttendantId,
                               PicturePeople = x.picturePeople.Where(p => p.StudentId == x.Id).Select(p => new PicturePersonDTO
                               {
                                   Id = p.Id,
                                   Picture = p.Picture,
                                   PictureId = p.PictureId,
                                   Student = x.FirstName + " " + x.LastName,
                                   StudentId = p.StudentId,
                               }).ToList()
                           }).FirstOrDefault();
        }
        CourseDTO GetCourse(int id)
        {
            return dbContext.Courses.Where(x => x.Id == id).Select(x => new CourseDTO
            {
                Id = x.Id,
                Code = x.Code,
                Name = x.Name,
                Description = x.Description,
                Amount = x.Amount,
            }).FirstOrDefault();
        }
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
                    .Include("MonthlyPayments")
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

                        }).ToList(),
                        MonthlyPayments= x.MonthlyPayments.Where(m=>m.TuitionId==x.Id ).Select(m=>new MonthlyPaymentDTO
                        {
                            Id = m.Id,
                            Detail = m.Detail,
                            Code = m.Code,
                            IsConfirmed = m.IsConfirmed,
                            Value = m.Value,
                            Since = m.Since,
                            Untill = m.Untill,
                            TuitionId = m.TuitionId
                        }).ToList(),


                    });

            } 
        }
        public FileResult GetFileStudent(int courseid)
        {
            ViewBag.title = "Listado de estudiante";
           
            TempData["course"] =GetCourse (courseid) ;
            List<TuitionDTO> tuitions=TuitionDTOs.Where(x=>x.CourseId==courseid).ToList();
            string htmlString = this.RenderRazorViewToString("StudentByCoursePdf", tuitions);
     
            HtmlToPdf htmlToPdf = Utilities .GetHtmlToPdf(pageSize, pdfOrientation, webPageWidth);
            byte[] pdf = Utilities .ConvertPdfToByte(htmlString, htmlToPdf);
            return File(pdf, "application/pdf");
        }
        public FileResult GetFileMonthlyPayments(int tuitionId)
        {
            TuitionDTO tuition = TuitionDTOs.Where(x => x.Id == tuitionId).FirstOrDefault();
            List<MonthlyPaymentDTO> monthlyPayments =tuition. MonthlyPayments;
            TempData["course"] =GetCourse( tuition .CourseId);
            TempData["Student"] = GetStudent(tuition.StudentId);
            string htmlString = this.RenderRazorViewToString("MonthlyPaymentsBytuitionPdf", monthlyPayments);

            HtmlToPdf htmlToPdf = Utilities.GetHtmlToPdf(pageSize, pdfOrientation, webPageWidth);
            byte[] pdf = Utilities.ConvertPdfToByte(htmlString, htmlToPdf);
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
