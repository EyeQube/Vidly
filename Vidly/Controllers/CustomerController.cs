using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // ////////////////////////////////////////////////////////////////////


        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
                
            };

            return View(viewModel);
        }


        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            return View();
        }



        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); // Eagerloading by adding  " Include(c => c.MembershipType) "  in between.

            return View(customers);
        }


        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        

        
    }
}