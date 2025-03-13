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
    public partial class CreateNewEntry : Form
    {
        VehicleContext vehicleDb;
        List<VehicleDBSetup> vehicleList;
        public CreateNewEntry()
        {
            vehicleDb = new VehicleContext();
            InitializeComponent();

            vehicleList = vehicleDb.Vehicles.Select(v => v).ToList();
        }
        private bool ValidateEntries()
        {
            if (txtType.Text == "" || txtName.Text == "" || txtClass.Text == "" || rchtxtDescription.Text == "" || rchtxtWeakness.Text == "" || pbNewImage.Image == null)
            {
                return false;
            }
            if (txtClass.Text != "Ground" && txtClass.Text != "Air" && txtClass.Text != "Naval")
            {
                return false;
            }
            else
            {
                return true;
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
        private void UploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog.Title = "Select an Image";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbNewImage.Image = Image.FromFile(openFileDialog.FileName);
                pbNewImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                UploadImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
        private void createEntry()
        { // VehicleName, VehicleType, Class, Imagepath, Weakness, Description
            string projectDirectory = Directory.GetParent(Application.StartupPath).FullName; // goes up to DCS Compendium folder
            string resourcesDirectory = Path.Combine(projectDirectory, "Resources");
            Directory.CreateDirectory(resourcesDirectory);
            string fileName = $"{txtName.Text.Replace(" ", "_")}.png"; // even if its a jpeg this works for me so hopefully it works for you to
            string savedImagePath = Path.Combine(resourcesDirectory, fileName);

            pbNewImage.Image.Save(savedImagePath, System.Drawing.Imaging.ImageFormat.Png);
            VehicleDBSetup addVehicle = new VehicleDBSetup
            {
                VehicleName = $"{txtName.Text}",
                VehicleType = $"{txtType.Text}",
                VehicleClass = $"{txtClass.Text}",
                VehicleImagePath = $"Resources\\{fileName}",
                VehicleWeakness = rchtxtWeakness.Text,
                VehicleDescription = rchtxtDescription.Text
            };

            vehicleDb.Vehicles.Add(addVehicle);
            vehicleDb.SaveChanges();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateEntries();
                if (ValidateEntries() == false)
                {
                    throw new ArgumentException("Entry failed to create, fields are missing or are not of type Ground, Air, or Naval");
                }
                if (ValidateEntries() == true)
                {
                    createEntry();
                    txtName.Text = "";
                    txtType.Text = "";
                    txtClass.Text = "";
                    pbNewImage.Image = null;
                    rchtxtWeakness.Text = "";
                    rchtxtDescription.Text = "";
                    MessageBox.Show("Successfully created entry.", "Entry Created");
                }
            }
            catch (ArgumentException AEx)
            {
                MessageBox.Show(AEx.Message, Text);
            }
        }
    }
}
