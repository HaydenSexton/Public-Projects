using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCS_Compendium
{
    public partial class SearchQuery : Form
    {
        VehicleContext vehicleDb;
        List<VehicleDBSetup> vehicleList;
        public SearchQuery()
        {
            vehicleDb = new VehicleContext();
            InitializeComponent();
            vehicleList = vehicleDb.Vehicles.Select(v => v).ToList();

            lblsearchResult.Text = $"Results for: {SearchDB.SearchInstance}";
            OutputResults();

        }
        private void FindAndSetVehicle(string vehicleName)
        {
            foreach (VehicleDBSetup vehicle in vehicleList)
            {
                if (vehicle.VehicleName == vehicleName)
                {
                    Vehicle.vehicleInfoInstance = vehicle;
                }
            }
        }
        private void btnsearchQueryBack_Click(object sender, EventArgs e)
        {
            try
            {
                // switches forms, put this last(?)
                this.Hide();
                formMainScreen formMainScreen = new formMainScreen();
                formMainScreen.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        private void ImageClick_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox clickedPictureBox = sender as PictureBox;
                string clickIndex = clickedPictureBox.Name.Replace("pictureBox", "");
                Label correspondingLabel = this.Controls.Find($"lblname{clickIndex}", true).FirstOrDefault() as Label;

                FindAndSetVehicle(correspondingLabel.Text);

                VehicleInfo vehicleInfo = new VehicleInfo();
                vehicleInfo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
        private void OutputResults()
        {
            try
            {
                int outputCount = 0;
                string searchInput = SearchDB.SearchInstance;

                outputCount = Vehicle.vehicleListInstance.Count;

                for (int i = 1; i < 10; i++)
                {
                    var pictureBox = Controls.Find($"pictureBox{i}", true).FirstOrDefault() as PictureBox;
                    var labelName = Controls.Find($"lblname{i}", true).FirstOrDefault() as Label;
                    var labelType = Controls.Find($"lbltype{i}", true).FirstOrDefault() as Label;
                    var labelGroup = Controls.Find($"lblgroup{i}", true).FirstOrDefault() as Label;

                    if (i <= outputCount)
                    {
                        var vehicle = Vehicle.vehicleListInstance[i - 1];
                        labelName.Text = vehicle.VehicleName;
                        labelType.Text = vehicle.VehicleClass;
                        labelGroup.Text = vehicle.VehicleType;

                        string imagePath = vehicle.VehicleImagePath; // MAKE SURE IMAGE EXTENSION IS SAME AS WHATS LISTED (IE: ABRAMS.PNG = RESOURCES\ABRAMS.PNG IN DATABASE, CANT CONVERT WEBMS FYI)
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            string projectDirectory = Directory.GetParent(Application.StartupPath).FullName;
                            string resourcesDirectory = Path.Combine(projectDirectory); // dont think this is needed but it works so not touching it
                            string entirePath = Path.Combine(resourcesDirectory, imagePath);

                            if (File.Exists(entirePath)) // prevent crashing if I haven't put the image in yet
                            {
                                pictureBox.Image = Image.FromFile(entirePath);
                            }
                            else
                            {
                                pictureBox.Image = null;
                            }
                        }
                        pictureBox.Visible = true;
                        labelName.Visible = true;
                        labelType.Visible = true;
                        labelGroup.Visible = true;
                    }
                    else
                    {
                        pictureBox.Visible = false;
                        labelName.Visible = false;
                        labelType.Visible = false;
                        labelGroup.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
    }
}
