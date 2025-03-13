namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color selectedColor;
        Material selectedMaterial;
        Style selectedStyle;
        public Color GetColor()
        {
            RadioButton selectedRadioButton = grpboxcolors.Controls.OfType<RadioButton>() // why are these green? I don't know, it works though.
            .FirstOrDefault(radioButton => radioButton.Checked);

            if (selectedRadioButton != null)
            {
                Color selectedColor = (Color)Enum.Parse(typeof(Color), selectedRadioButton.Tag.ToString());
                return selectedColor;
            }
            else
            {
                MessageBox.Show("Please select a color radio button.");
                return Color.NONE;
            }
        }
        public Material GetMaterial()
        {
            RadioButton selectedRadioButton = grpboxmaterial.Controls.OfType<RadioButton>()
            .FirstOrDefault(radioButton => radioButton.Checked);

            if (selectedRadioButton != null)
            {
                Material selectedMaterial = (Material)Enum.Parse(typeof(Material), selectedRadioButton.Tag.ToString());
                return selectedMaterial;
            }
            else
            {
                MessageBox.Show("Please select a material radio button.");
                return Material.NONE;
            }
        }
        public Style GetStyle()
        {
            RadioButton selectedRadioButton = grpboxstyle.Controls.OfType<RadioButton>()
            .FirstOrDefault(radioButton => radioButton.Checked);

            if (selectedRadioButton != null)
            {
                selectedStyle = (Style)Enum.Parse(typeof(Style), selectedRadioButton.Tag.ToString());
                return selectedStyle;
            }
            else
            {
                MessageBox.Show("Please select a style radio button.");
                return Style.NONE;
            }
        }
        public void DisplayInfo(float height, float width, Color color, Material material, Style style)
        {
            if (rbtnMatted.Checked)
            {
                MattedPhoto mattedPhoto = new MattedPhoto(width, height, color);
                float price = mattedPhoto.Price;
                lblfinalInfo.Text = mattedPhoto.ToString();
                lblCost.Text = "$" + price.ToString();
            }
            else if (rbtnFramed.Checked)
            {
                FramedPhoto framedPhoto = new FramedPhoto(width, height, material, style);
                float price = framedPhoto.Price;
                lblfinalInfo.Text = framedPhoto.ToString();
                lblCost.Text = "$" + price.ToString();
            }
            else
            {
                Photo photo = new Photo(width, height);
                float price = photo.Price;
                lblfinalInfo.Text = photo.ToString();
                lblCost.Text = "$" + price.ToString();
            }
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float width = float.Parse(txtWidth.Text);
            float height = float.Parse(txtHeight.Text);
            Color color = GetColor();
            Material material = GetMaterial();
            Style style = GetStyle();

            DisplayInfo(height, width, color, material, style );

        }
    }
}