using HR_WebApp.Database;
using HR_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HR_WebApp.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffDatabase staffDatabase;

        public StaffController(IStaffDatabase staffDatabase)
        {
            this.staffDatabase = staffDatabase;
        }

        public IActionResult Overview()
        {
            var vm = staffDatabase.GetAll().Select(x => new StaffListViewModel
            {
                Id = x.Id,  // <-- nodig voor selectie
                FirstName = x.FirstName,
                LastName = x.LastName,
                DOE = x.DOE, // <-- nodig voor sorteren
            } );
            
            return View(vm);
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}
