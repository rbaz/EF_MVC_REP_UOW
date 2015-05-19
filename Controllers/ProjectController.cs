using EF_MVC_Repository_UOW.Models;
using EF_MVC_Repository_UOW.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_MVC_Repository_UOW.Controllers
{
    public class ProjectController : Controller
    {
        UnitOfWork unitofwork = new UnitOfWork();
       // Project project;

        public ActionResult Index()
        {
            IQueryable<Project> projects = unitofwork.ProjectRepository.GetAll();
            return View(projects);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            try
            {
                unitofwork.ProjectRepository.Insert(project);
                unitofwork.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Project project)
        {
            try
            {
                unitofwork.ProjectRepository.Edit(project);
                unitofwork.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View("Edit", unitofwork.ProjectRepository.GetById(id.Value));
        }

        [HttpPost]
        public ActionResult Delete(int? submit)
        {
            Project project = unitofwork.ProjectRepository.GetById(submit.Value);
            unitofwork.ProjectRepository.Delete(project);
            unitofwork.Save();
            return View("Index", unitofwork.ProjectRepository.GetAll());
        }
    }
}