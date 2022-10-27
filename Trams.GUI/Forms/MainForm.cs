namespace Trams.GUI.Forms
{
    public partial class MainForm : Form
    {
        private readonly StopForm stopsForm;
        private readonly TramForm tramForm;
        private readonly RoutesForm routesForm;
        public MainForm()
        {
            stopsForm = new StopForm() { Dock = DockStyle.Fill, TopLevel = false, IsAccessible = true };
            tramForm = new TramForm() { Dock = DockStyle.Fill, TopLevel = false, IsAccessible = true };
            routesForm = new RoutesForm() { Dock = DockStyle.Fill, TopLevel = false, IsAccessible = true };
            InitializeComponent();
        }
        private void btnStops_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            mainPanel.Controls.Add(stopsForm);
            stopsForm.Show();
        }
        private void btnTrams_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            mainPanel.Controls.Add(tramForm);
            tramForm.Show();
        }
        private void btnRoutes_Click(object sender, EventArgs e)
        {
            CloseOpenForms();
            mainPanel.Controls.Add(routesForm);
            routesForm.Show();
        }
        private void CloseOpenForms() 
            => mainPanel.Controls.Clear();
    }
}
