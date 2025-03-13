namespace DCS_Compendium
{
    public partial class formMainScreen : Form
    {
        VehicleContext vehicleDb;
        List<VehicleDBSetup> vehicleList;
        public Vehicle vehicle = new Vehicle();
        public formMainScreen()
        {
            vehicleDb = new VehicleContext();
            InitializeComponent();
            this.AcceptButton = btnSearch;

            vehicleList = vehicleDb.Vehicles.Select(v => v).ToList();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchInput = txtSearch.Text;
                SearchDB.SearchInstance = searchInput; // searchinstance is whatever the user put in the text box on the main screen
                int foundCount = 0;
                Vehicle.vehicleListInstance.Clear();

                vehicleList = vehicleDb.Vehicles
                    .ToList();

                foreach (VehicleDBSetup vehicle in vehicleList)
                {
                    if (vehicle.VehicleName.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleType.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleClass.ToLower().Contains(searchInput.ToLower()))
                    {
                        Vehicle.vehicleListInstance.Add(vehicle);
                        foundCount++;

                        if (foundCount > 9) // this is here so I dont have a overflow of results incase I add more than 9 entries for each class or it bugs out
                        {
                            break;
                        }
                    }
                }
                // may need to add more for this to function


                // switches forms, put last (?)
                this.Hide();
                SearchQuery searchQuery = new SearchQuery();
                searchQuery.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        private void btnGround_Click(object sender, EventArgs e)
        {
            try
            {
                //search mechanics, vehicleListInstance for list
                string searchInput = "Ground";
                SearchDB.SearchInstance = searchInput; // searchinstance is whatever the user put in the text box on the main screen
                int foundCount = 0;
                Vehicle.vehicleListInstance.Clear();

                vehicleList = vehicleDb.Vehicles
                    .ToList();

                foreach (VehicleDBSetup vehicle in vehicleList)
                {
                    if (vehicle.VehicleName.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleType.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleClass.ToLower().Contains(searchInput.ToLower()))
                    {
                        Vehicle.vehicleListInstance.Add(vehicle);
                        foundCount++;

                        if (foundCount > 9) // this is here so I dont have a overflow of results incase I add more than 9 entries for each class or it bugs out
                        {
                            break;
                        }
                    }
                }

                // switches forms, put last (?)
                this.Hide();
                SearchQuery searchQuery = new SearchQuery();
                searchQuery.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }     
        }

        private void btnAir_Click(object sender, EventArgs e)
        {
            try
            {
                //search mechanics, vehicleListInstance for list
                string searchInput = "Air";
                SearchDB.SearchInstance = searchInput;
                int foundCount = 0;
                Vehicle.vehicleListInstance.Clear();

                vehicleList = vehicleDb.Vehicles
                    .ToList();

                foreach (VehicleDBSetup vehicle in vehicleList)
                {
                    if (vehicle.VehicleName.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleType.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleClass.ToLower().Contains(searchInput.ToLower()))
                    {
                        Vehicle.vehicleListInstance.Add(vehicle);
                        foundCount++;

                        if (foundCount > 9) // this is here so I dont have a overflow of results incase I add more than 9 entries for each class or it bugs out
                        {
                            break;
                        }
                    }
                }

                // switches forms, put last (?)
                this.Hide();
                SearchQuery searchQuery = new SearchQuery();
                searchQuery.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            } 
        }

        private void btnNaval_Click(object sender, EventArgs e)
        {
            try
            {
                //search mechanics, vehicleListInstance for list
                string searchInput = "Naval";
                SearchDB.SearchInstance = searchInput;
                int foundCount = 0;
                Vehicle.vehicleListInstance.Clear();

                vehicleList = vehicleDb.Vehicles
                    .ToList();

                foreach (VehicleDBSetup vehicle in vehicleList)
                {
                    if (vehicle.VehicleName.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleType.ToLower().Contains(searchInput.ToLower()) || vehicle.VehicleClass.ToLower().Contains(searchInput.ToLower()))
                    {
                        Vehicle.vehicleListInstance.Add(vehicle);
                        foundCount++;

                        if (foundCount > 9) // this is here so I dont have a overflow of results incase I add more than 9 entries for each class or it bugs out
                        {
                            break;
                        }
                    }
                }

                // switches forms, put last (?)
                this.Hide();
                SearchQuery searchQuery = new SearchQuery();
                searchQuery.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        private void btncreateNewEntry_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle.Instance.FormToOpen = "Create";

                // switches forms, put last (?)
                this.Hide();
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.ShowDialog();
                this.Close();
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
                Vehicle.Instance.FormToOpen = "Update";

                // switches forms, put last (?)
                this.Hide();
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle.Instance.FormToOpen = "Delete";

                // switches forms, put last (?)
                this.Hide();
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }
    }
}
