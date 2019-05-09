using DataAccessPoint;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiNorthwindEX.Controllers.API;

namespace WebApiNorthwindEX.Views.DataGrids
{
    public class DataGridsController : Controller
    {
        CustomerAPIController api = new CustomerAPIController();

        // GET: DataGrids
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            ICollection<Customer> custLst = new List<Customer>();
            Models.CustomerModel cm = new Models.CustomerModel();

            custLst = api.GetCustomers(cm);

            return View(custLst);
        }

    }
}