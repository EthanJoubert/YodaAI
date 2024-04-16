using TheYodaAI_App.Views;

namespace TheYodaAI_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute("funfactspage", typeof(FunFactsPage));
        }
    }
}
