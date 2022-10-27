namespace Trams.GUI.Forms
{
    public partial class TramForm : Form
    {
        private readonly VehicleHandler vehicleHandler;
        private readonly VehicleStopHandler vehicleStopHandler;
        private readonly List<Vehicle> allVehicles;
        private Vehicle selectedVehicle;
        public TramForm()
        {
            vehicleHandler = new();
            vehicleStopHandler = new();
            allVehicles = vehicleHandler.GetAll();
            InitializeComponent();
        }
        private void SetSelevtedVehicle() 
            => selectedVehicle = vehicleHandler.GetSingle(vehiclesList.SelectedItem.ToString());
        private void TramForm_Load(object sender, EventArgs e)
        {
            if (vehiclesList.Items.Count == 0)
                allVehicles.ForEach(v => vehiclesList.Items.Add(v.Name));
        }
        private void vehiclesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehiclesList.SelectedItem != null)
            {
                SetSelevtedVehicle();
                DisplayListOfStopsForSelectedVehicle();
                DisplayInformationsOfVehicle();
            }
        }
        private void DisplayListOfStopsForSelectedVehicle()
        {
            stopList.Items.Clear();
            var vehicleStops = vehicleStopHandler.GetAll(selectedVehicle);
            vehicleStops.Where(x => x.Direction != vehicleStops.First().Direction).ToList()
                .ForEach(vs => stopList.Items.Add(vs.Stop.Name));
        }
        private void DisplayInformationsOfVehicle()
        {
            lblName.Text = vehiclesList.SelectedItem.ToString();
            lblType.Text = selectedVehicle.VehicleType.ToString();
            lblRoute.Text = $"{stopList.Items[0]} - {stopList.Items[^1]}";
        }
    }
}
