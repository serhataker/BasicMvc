using Microsoft.AspNetCore.Mvc;
using BasicMvc.Model;

namespace BasicMvc.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Create a customer
            var customer = new Customer // Create a new instance of the Customer class and initialize its properties

            {
                Id = 1,
                FirstName = "Test-z",
                LastName = "testtit-z",
                Email = "test-itz@kms.com"
            };

            // Create a list of orders
            var orders = new List<Order>// Create a new instance of the Order List class and initialize its properties

            {
                new Order { Id = 1, Price = 3, Quantity = 1, ProductName = "Lale-z" },
                new Order { Id = 2, Price = 1, Quantity = 1, ProductName = "Lale-Zar" },
                new Order { Id = 3, Price = 1, Quantity = 1, ProductName = "Lale-sz" }
            };

            // Create the view model
            var customerOrderViewModel = new CustomerOrderViewModel
            {
                Customer = customer,// Assign the customer instance to the Customer property
                Orders = orders // Assign the list of orders to the Orders property
            };
            return View(customerOrderViewModel); // we result the View method customerOrderViewModel object for rendering
        }
    }
}
