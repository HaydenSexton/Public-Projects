using System.Diagnostics.Eventing.Reader;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Letter> letterList = new List<Letter>();

        List<CertifiedLetter> certifiedLettersList = new List<CertifiedLetter>();

        private void GetCertLetter(string recipient, DateTime dateinput, string trackingNumber)
        {
            CertifiedLetter newCertLetter = new CertifiedLetter($"{recipient}", (DateTime)dateinput, $"{trackingNumber}");
            letterList.Insert(0, newCertLetter);
        }
        private void GetLetter(string recipient, DateTime dateinput)
        {

            Letter newLetter = new Letter($"{recipient}", (DateTime)dateinput);
            letterList.Insert(0, newLetter);
        }
        private void AddAndDisplay() // this took me wayyyyy too long to figure out
        {
            rchtxttransactionLog.Clear();

            foreach (var letter in letterList)
            {
                rchtxttransactionLog.AppendText(letter.ToString() + Environment.NewLine);
            }

            foreach (var certletter in certifiedLettersList)
            {
                rchtxttransactionLog.AppendText(certletter.ToString() + Environment.NewLine);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int listlength = letterList.Count + certifiedLettersList.Count;
            if (listlength <= 20)
            {
                string recipient = txtRecipient.Text;
                DateTime dateinput = Convert.ToDateTime(txtsentDate.Text);
                string trackingNumber = txttrackingNumber.Text;
                if (txttrackingNumber.Text == "")
                {
                    GetLetter(recipient, (DateTime)dateinput);
                }
                if (txttrackingNumber.Text != "")
                {
                    GetCertLetter(recipient, (DateTime)dateinput, trackingNumber);
                }

                AddAndDisplay();
            }     
            else
            {
                lblFULL.Visible = true;
            }
        }
    }
}