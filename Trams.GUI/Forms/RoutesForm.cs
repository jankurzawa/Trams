namespace Trams.GUI.Forms
{
    public partial class RoutesForm : Form
    {
        private readonly RouteHandler routeHandler;
        private readonly StopHandler stopHandler;
        private readonly VehicleStopHandler vehicleStopHandler;
        private readonly RouteStopHandler routeStopHandler;
        private readonly List<Stop> allStops;
        private Stop selectedFirstStop;
        private Stop selectedLastStop;
        private Route selectedRoute;
        private Vehicle selectedVehicle;
        public RoutesForm()
        {
            routeHandler = new();
            stopHandler = new();
            vehicleStopHandler = new();
            routeStopHandler = new();
            allStops = stopHandler.GetAll();
            InitializeComponent();
        }
        private void SetFirstStop()
            => selectedFirstStop = stopHandler.GetSingle(cBoxFirstStop.SelectedItem.ToString());
        private void SetLastStop()
            => selectedLastStop = stopHandler.GetSingle(cBoxLastStop.SelectedItem.ToString());
        private void SetSelectedRoute()
            => selectedRoute = routeHandler.GetSingle(routesList.SelectedItem.ToString());
        private void RoutesForm_Load(object sender, EventArgs e)
        {
            FillRoutesList();
            FillcBoxesWithStops();
        }
        private void routesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (routesList.SelectedItem != null)
                SetSelectedRoute();
            DisplayDetailsOfSelectedRoute();
        }
        private void cBoxFirstStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxFirstStop.SelectedItem != null)
            {
                SetFirstStop();
                FillcBoxVehicles();
            }
        }
        private void cBoxLastStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxLastStop.SelectedItem != null)
            {
                SetLastStop();
                FillcBoxVehicles();
            }
        }
        private void cBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxVehicle.SelectedItem != null)
            {
                var time = TimeCalculator.GetTimeBetweenStops(selectedFirstStop, selectedLastStop);
                DisplayOtherDetailsOfNewRoute(time);
            }
        }
        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            routeHandler.Create(tbName.Text, selectedVehicle, selectedFirstStop, selectedLastStop,
                TimeCalculator.GetTimeBetweenStops(selectedFirstStop, selectedLastStop));
            ClearControlsCreatesNewRoutes();
            FillRoutesList();
        }

        private void btnRemoveSelectedRoute_Click(object sender, EventArgs e)
        {
            if (routesList.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to remove '{routesList.SelectedItem}' from your Routes List?",
                    "Query", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    routeHandler.Delete(selectedRoute);
                    FillRoutesList();
                }
            }
        }
        private void DisplayDetailsOfSelectedRoute()
        {
            if (routesList.SelectedItem != null)
            {
                lblName.Text = selectedRoute.Name;
                lblTime.Text = selectedRoute.Time.ToString();
                lblFirstStop.Text = routeStopHandler.GetSingle(selectedRoute.RouteStops.Where(rs => rs.Status == StopStatus.Starting).FirstOrDefault()).Stop.Name;
                lblLastStop.Text = routeStopHandler.GetSingle(selectedRoute.RouteStops.Where(rs => rs.Status == StopStatus.Final).FirstOrDefault()).Stop.Name;
                lblVehicle.Text = selectedRoute.Vehicle.Name;
                lblCost.Text = $"{selectedRoute.Cost} PLN";
            }
        }
        private void FillRoutesList()
        {
            routesList.Items.Clear();
            routeHandler.GetAll().ForEach(r => routesList.Items.Add(r.Name));
        }
        private void FillcBoxesWithStops()
        {
            allStops.ForEach(s => cBoxFirstStop.Items.Add(s.Name));
            allStops.ForEach(s => cBoxLastStop.Items.Add(s.Name));
        }
        private void FillcBoxVehicles()
        {
            if (cBoxFirstStop.SelectedItem != null && cBoxLastStop.SelectedItem != null)
            {
                cBoxVehicle.Items.Clear();
                var vehicleStopsOfFirstStop = vehicleStopHandler.GetAll(selectedFirstStop);
                var vehicleStopOdLastStop = vehicleStopHandler.GetAll(selectedLastStop);

                List<Vehicle> commonVehicles = new();

                vehicleStopsOfFirstStop.ForEach(vs => commonVehicles.Add(vs.Vehicle));
                vehicleStopOdLastStop.ForEach(vs => commonVehicles.Add(vs.Vehicle));

                for (int i = 0; i < commonVehicles.Count; i++)
                {
                    for (int j = 0; j < commonVehicles.Count; j++)
                    {
                        if (i != j)
                            if (commonVehicles[i].Name == commonVehicles[j].Name)
                                commonVehicles.Remove(commonVehicles[j]);
                    }
                }
                commonVehicles.ForEach(v => cBoxVehicle.Items.Add(v.Name));
            }
        }
        private void DisplayOtherDetailsOfNewRoute(TimeSpan time)
        {
            lblTimeInNewRoute.Text = time.ToString();
            lblCostInNewRoute.Text = CostCalculator.GetCostofRoute(time).ToString();
        }
        private void ClearControlsCreatesNewRoutes()
        {
            tbName.Clear();
            cBoxFirstStop.SelectedItem = null;
            cBoxLastStop.SelectedItem = null;
            cBoxVehicle.SelectedItem = null;
            lblTimeInNewRoute.Text = "";
            lblCostInNewRoute.Text = "";
        }
    }
}
