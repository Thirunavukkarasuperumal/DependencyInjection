using MvcConcepts.DBContext;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcConcepts.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        public string DefaultConnectionString;
        public IClientDbContext dbContext;
        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            DefaultConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        }
        public ActionResult Index()
        {
            var getUserDetails = _userRepository.GetUserDetails();
            dbContext = new ClientDbContext(DefaultConnectionString);
            var getEnrollment = dbContext.Enrollments.Where(x=>x.UserId == "admin").SingleOrDefault();
            return View(getEnrollment);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}