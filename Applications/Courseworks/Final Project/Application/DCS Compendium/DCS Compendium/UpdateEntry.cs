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
    public partial class UpdateEntry : Form
    {
        VehicleContext vehicleDb;
        List<VehicleDBSetup> vehicleList;

        public UpdateEntry()
        {
            InitializeComponent();
            vehicleDb = new VehicleContext();
            this.AcceptButton = btnFind;

            vehicleList = vehicleDb.Vehicles.Select(v => v).ToList();
        }
        private void FindVehicleInfo(string Input)
        {
            bool vehicleFound = false;
            foreach (VehicleDBSetup vehicle in vehicleList)
            {
                if (vehicle.VehicleName.ToLower().Contains(Input) || vehicle.VehicleType.ToLower().Contains(Input) || vehicle.VehicleClass.ToLower().Contains(Input))
                {
                    vehicleFound = true;
                    Vehicle.vehicleUpdateInstance = vehicle;
                }
            }
            if (!vehicleFound)
            {
                throw new Exception("Vehicle Not Found");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFind.Text != "")
                {
                    string Input = txtFind.Text.ToLower();
                    FindVehicleInfo(Input);

                    lblFindResult.Text = $"Selected: {Vehicle.vehicleUpdateInstance.VehicleName}, {Vehicle.vehicleUpdateInstance.VehicleType}, {Vehicle.vehicleUpdateInstance.VehicleClass}, {Vehicle.vehicleUpdateInstance.VehicleImagePath}"; //update with result
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblSuccess.Visible = false;

                string selectedKey = comboKeyToEdit.SelectedItem.ToString();
                string newInput = rchtxtInfoToUpdateWith.Text;

                if (txtFind.Text != "" && rchtxtInfoToUpdateWith.Text != "" && comboKeyToEdit.SelectedItem.ToString() != "")
                {
                    lblSuccess.Visible = true;
                    var existingVehicle = vehicleDb.Vehicles.FirstOrDefault(v => v.VehicleID == Vehicle.vehicleUpdateInstance.VehicleID);

                    if (existingVehicle != null)
                    {
                        if (selectedKey == "VehicleName")
                        {
                            existingVehicle.VehicleName = newInput;
                            vehicleDb.SaveChanges();
                        }
                        else if (selectedKey == "VehicleType")
                        {
                            existingVehicle.VehicleType = newInput;
                            vehicleDb.SaveChanges();
                        }
                        else if (selectedKey == "VehicleClass")
                        {
                            existingVehicle.VehicleClass = newInput;
                            vehicleDb.SaveChanges();
                        }
                        else if (selectedKey == "VehicleImagePath")
                        {
                            existingVehicle.VehicleImagePath = newInput;
                            vehicleDb.SaveChanges();
                        }
                        else if (selectedKey == "VehicleWeakness")
                        {
                            existingVehicle.VehicleWeakness = newInput;
                            vehicleDb.SaveChanges();
                        }
                        else if (selectedKey == "VehicleDescription")
                        {
                            existingVehicle.VehicleDescription = newInput;
                            vehicleDb.SaveChanges();
                        }
                    }
                    else
                    {
                        throw new Exception("Vehicle was null");
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
                formMainScreen formMainScreen = new formMainScreen();
                formMainScreen.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
    }
}
