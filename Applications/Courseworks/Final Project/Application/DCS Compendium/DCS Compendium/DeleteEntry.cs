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
    public partial class DeleteEntry : Form
    {
        VehicleContext vehicleDb;
        List<VehicleDBSetup> vehicleList;
        public DeleteEntry()
        {
            InitializeComponent();
            vehicleDb = new VehicleContext();
            this.AcceptButton = btnFind;
            vehicleList = vehicleDb.Vehicles.Select(v => v).ToList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text != "")
            {
                string Input = txtFind.Text.ToLower();
                FindVehicleInfo(Input);

                lblFindResult.Text = $"Selected: {Vehicle.vehicleDeleteInstance.VehicleName}, {Vehicle.vehicleDeleteInstance.VehicleType}, {Vehicle.vehicleDeleteInstance.VehicleClass}, {Vehicle.vehicleDeleteInstance.VehicleImagePath}"; //update with result so person knows what is found
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Vehicle.vehicleDeleteInstance.VehicleName != "")
            {
                vehicleDb.Vehicles.Remove(Vehicle.vehicleDeleteInstance);
                vehicleDb.SaveChanges();
                lblFindResult.Text = "Deletion Successful";
            }
            else if (Vehicle.vehicleDeleteInstance.VehicleName == "")
            {
                lblFindResult.Text = "Deletion Failed, nothing selected to delete";
            }
        }
        private void FindVehicleInfo(string Input)
        {
            bool vehicleFound = false;
            foreach (VehicleDBSetup vehicle in vehicleList)
            {
                if (vehicle.VehicleName.ToLower().Contains(Input) || vehicle.VehicleType.ToLower().Contains(Input) || vehicle.VehicleClass.ToLower().Contains(Input))
                {
                    vehicleFound = true;
                    Vehicle.vehicleDeleteInstance = vehicle;
                }
            }
            if (!vehicleFound)
            {
                lblFindResult.Text = "Not Found";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // switches forms
            this.Hide();
            formMainScreen formMainScreen = new formMainScreen();
            formMainScreen.ShowDialog();
            this.Close();
        }
    }
}
