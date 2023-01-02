using System.Collections.Generic;

namespace Vidly.Models.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public string Title
        {
            get
            {
                return Customer.Id == 0 ? "New Customer" : "Edit Customer";
            }
        }
        public Customer Customer { get; set; }        
    }
}