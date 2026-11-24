using CommunityToolkit.Mvvm.ComponentModel;
using Crm.Maui.Models;

namespace Crm.Maui.ViewModels
{
    public partial class CustomerDetailViewModel 
        : ObservableObject, IQueryAttributable
    {
        [ObservableProperty]
        private Customer _customer;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.TryGetValue("Item", out object? currentItem))
            {
                Customer = (Customer) currentItem;
            }

            query.Clear();
        }
    }
}
