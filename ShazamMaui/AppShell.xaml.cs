namespace ShazamMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("newchat", typeof(Charts));
            Routing.RegisterRoute("newlibrary", typeof(NewPage1));

        }

        
    }
}
