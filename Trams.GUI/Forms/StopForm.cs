namespace Trams.GUI.Forms
{
    public partial class StopForm : Form
    {
        private readonly StopHandler stopHandler;
        private readonly VehicleStopHandler vehicleStopHandler;
        private readonly DepartureTimesHandler departureTimesHandler;
        private readonly CommentHandler commentHandler;
        private readonly List<Stop> allStops;
        private Stop selectedStop;
        private List<DepartureTime> departuresOfSelectedStop;
        public StopForm()
        {
            stopHandler = new();
            vehicleStopHandler = new();
            departureTimesHandler = new();
            commentHandler = new();
            allStops = stopHandler.GetAll();
            InitializeComponent();
        }

        private void SetSelectedStop() 
            => selectedStop = stopHandler.GetSingle(StopList.SelectedItem.ToString());
        private void SetDeparturesOfSelectedStop() 
            => departuresOfSelectedStop = departureTimesHandler.GetDeparturesFromStop(selectedStop);
        private void DisplayDesriptionOfSelectedStop() 
            => lblDescription.Text = selectedStop.Description;
        private void ClearTextBoxToWriteComment() 
            => textBoxToWriteComment.Clear();
        private void TextBoxToWriteComment_Click(object sender, EventArgs e) 
            => ClearTextBoxToWriteComment();
        private void StopsForm_Load(object sender, EventArgs e)
        {
            if (StopList.Items.Count == 0)
                allStops.ForEach(s => StopList.Items.Add(s.Name));
        }
        private void StopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StopList.SelectedItem != null)
            {
                SetSelectedStop();
                SetDeparturesOfSelectedStop();
                DisplayDeparturesFromSelectedStop();
                DisplayDesriptionOfSelectedStop();
                DisplayCommentsAboutSelectedStop();
                DisplayVehiclesForSelectedStop();
            }
        }
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (StopList.SelectedItem != null)
            {
                commentHandler.AddNewComment(textBoxToWriteComment.Text, selectedStop);
                DisplayCommentsAboutSelectedStop();
                ClearTextBoxToWriteComment();
            }
        }
        private void DisplayDeparturesFromSelectedStop()
        {
            departuresList.Items.Clear();
            departuresOfSelectedStop.ForEach(dt => departuresList.Items
            .Add($"{dt.DateTime} - {dt.VehicleStop.Vehicle.Name} - '{dt.VehicleStop.Direction}'"));
        }
        private void DisplayCommentsAboutSelectedStop()
        {
            CommentsList.Items.Clear();
            commentHandler.GetAllCommentFromStop(selectedStop)
                .ForEach(c => CommentsList.Items.Add($"{c.CreatedDate} - {c.Message}"));
        }
        private void DisplayVehiclesForSelectedStop()
        {
            vehiclesList.Items.Clear();
            vehicleStopHandler.GetAll(selectedStop).OrderBy(vs => vs.Vehicle.Name).ToList()
                .ForEach(vs => vehiclesList.Items.Add($"{vs.Vehicle.Name} - '{vs.Direction}'"));
        }
    }
}
