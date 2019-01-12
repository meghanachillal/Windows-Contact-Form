using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace WindowsContactForm
{
    public partial class ContactForm : Form
    {
        Dictionary<int, Customer> allData = new Dictionary<int, Customer>();
        int currentIndex = 0;
        int maxIndex = 0;

        public ContactForm()
        {
            InitializeComponent();
        }

        private void prevButtonClick(object sender, EventArgs e)
        {
            textBoxStatus.Clear();
            currentIndex = currentIndex - 1;
            if (currentIndex < 0)
            {
                this.textBoxStatus.Text = "This is the first record. Please Click on Next Button to proceed!! ";
                this.textBoxStatus.ForeColor = Color.Green;
            }
            else 
            {
                UpdateData(currentIndex);
            }
         
        }

        private void nextButtonClick(object sender, EventArgs e)
        {
            textBoxStatus.Clear();
            currentIndex = currentIndex + 1;
            if (currentIndex >= maxIndex)
            {
                this.textBoxStatus.Text = "This is the end of the records!!";
                this.textBoxStatus.ForeColor = Color.Green;
                currentIndex = maxIndex-1;
            }
            else 
            {
                UpdateData(currentIndex);
            }
        }



        private void ContactForm_Load(object sender, EventArgs e)
        {
            allData.Clear();

            using (CustomerDataModel db = new CustomerDataModel())
            {
                DbSet<Customer> customers = db.Customers;

                foreach (Customer customer in customers)
                {
                    allData.Add(maxIndex, customer);
                    maxIndex++;
                }
            }
            UpdateData(currentIndex);
        }

        private void ValidateFields()
        {
            int val;
            var controls = new [] { textBoxFirstName, textBoxlastName, textBoxAddress, textBoxCity, textBoxProvince};

            foreach (var control in controls)
            {
                if (control.Text.Length >50)
                {
                    this.textBoxStatus.Text = "Error:   " + control.Name + "  must not more than 50";
                    this.textBoxStatus.ForeColor = Color.Red;
                }
            }

            if (textBoxPostalCode.Text.Length > 6)
            { 
                this.textBoxStatus.Text = "Error: Postal Code must not be more than 6 Characters" ;
                this.textBoxStatus.ForeColor = Color.Red;
            }

            if (!int.TryParse(textBoxStreetNumber.Text, out val))
            {
                this.textBoxStatus.Text = "Error: Street Number Must Be A Numeric Value";
            }

        }

        private void UpdateData(int index)
        {
            Customer personData = null;
            if (allData.TryGetValue(index, out personData))
            {
                this.textBoxID.Text = personData.ID.ToString();
                this.textBoxFirstName.Text = personData.FirstName;
                this.textBoxlastName.Text = personData.LastName;
                this.textBoxStreetNumber.Text = personData.StreetNumber;
                this.textBoxAddress.Text = personData.Address;
                this.textBoxPhoneNumber.Text = personData.PhoneNumber;
                this.textBoxCity.Text = personData.City;
                this.textBoxCountry.Text = personData.Country;
                this.textBoxPostalCode.Text = personData.PostalCode;
                this.textBoxProvince.Text = personData.Province;
                this.textBoxEmail.Text = personData.EmailAddress;
                ValidateFields();
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "CSV Files (.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                textImportFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
          
            String file = textImportFile.Text;
            bool firstcolumn = false;
            using (TextFieldParser parser = new TextFieldParser(file))
            {
                parser.Delimiters = new string[] { "," };
                while (true)
                {
                    string[] parts = parser.ReadFields();
                    if (parts == null)
                    {
                        break;
                    }
                    using (CustomerDataModel db = new CustomerDataModel())
                    {
                        if (firstcolumn)
                        {
                            DbSet<Customer> customers = db.Customers;
                            Customer cust = new Customer();
                            cust.FirstName = parts[0];
                            cust.LastName = parts[1];
                            cust.StreetNumber = parts[2];
                            cust.Address = parts[3];
                            cust.City = parts[4];
                            cust.Province = parts[5];
                            cust.Country = parts[6];
                            cust.PostalCode = parts[7];
                            cust.PhoneNumber = parts[8];
                            cust.EmailAddress = parts[9];
                            // this saves it in the DB to be saved when Save is called
                            customers.Add(cust);
                            db.SaveChanges();
                            allData.Add(maxIndex, cust);
                            this.textBoxStatus.Text = "The data is imported successfully!!";
                            maxIndex++;
                        }
                        firstcolumn = true;
                    }
                }
            }
            UpdateData(currentIndex);

        }
    }
}
