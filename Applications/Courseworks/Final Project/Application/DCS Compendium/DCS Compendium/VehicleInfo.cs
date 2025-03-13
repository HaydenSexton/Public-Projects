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
    public partial class VehicleInfo : Form
    {
        VehicleContext vehicleDb;
        List<VehicleDBSetup> vehicleList;
        public VehicleInfo()
        {
            vehicleDb = new VehicleContext();
            InitializeComponent();

            vehicleList = vehicleDb.Vehicles.Select(v => v).ToList();
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            try
            {
                bool vehicleFound = false;
                foreach (VehicleDBSetup vehicle in vehicleList)
                {
                    if (vehicle.VehicleName == Vehicle.vehicleInfoInstance.VehicleName) // it took me like an hour of debugging just for me to realize I needed to compare vehicleNames and not the whole VehicleDBSetup type
                    {
                        vehicleFound = true;
                        string imagePath = vehicle.VehicleImagePath;
                        string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                        string resourcesDirectory = Path.Combine(projectDirectory); // this isn't needed but it works so not touching it
                        string entirePath = Path.Combine(resourcesDirectory, imagePath);

                        if (File.Exists(entirePath))
                        {
                            pbVehicleImage.Image = Image.FromFile(entirePath);
                        }
                        lblnameOfUnit.Text = vehicle.VehicleName;
                        lbltypeOfUnit.Text = vehicle.VehicleClass;
                        lblgroupOfUnit.Text = vehicle.VehicleType;
                        rchtxtDescription.Text = vehicle.VehicleDescription;
                        rchtxtWeakness.Text = vehicle.VehicleWeakness;
                    }
                    if (!vehicleFound)
                    {
                        pbVehicleImage.Image = null;
                        lblnameOfUnit.Text = "Error";
                        lbltypeOfUnit.Text = "Error";
                        lblgroupOfUnit.Text = "Error";
                        rchtxtDescription.Text = "Error";
                        rchtxtWeakness.Text = "Error";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                // switches forms
                this.Hide();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }      
        }
    }
}
