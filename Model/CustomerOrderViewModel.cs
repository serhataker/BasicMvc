
namespace BasicMvc.Model
{
    public class CustomerOrderViewModel  // View model that holds customer details and related orders
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
