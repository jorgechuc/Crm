using Crm.Maui.Views;

namespace Crm.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registramos las rutas que están en la jerarquía visual del Shell
            Routing.RegisterRoute(
                nameof(CustomerEditPage),
                typeof(CustomerEditPage));
            Routing.RegisterRoute(
                nameof(CustomerDetailPage),
                typeof(CustomerDetailPage));
        }
    }
}
