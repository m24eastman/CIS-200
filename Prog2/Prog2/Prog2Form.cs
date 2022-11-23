// 5272456
// CIS 200-50
// Program 2
// 10/25/2021
// this code runs the back end of the forms and has test objects for addresses and parcels for the main part of the program
using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView test;
        public Prog2Form()
        {
            InitializeComponent();

            test = new UserParcelView();
            // below are a list of addreesses to be used to test 
            test.AddAddress("Michael Jordan", "1816 Fleming Road", "Louisville", "KY", 40205); // first test address
            test.AddAddress("Vince Carter", "5391 Trevlian Way", "Lexington", "KY", 53210); // second test address
            test.AddAddress("Lebron James", "121 Shady Lane", "Phenoix", "AZ", 83104); // third test address
            test.AddAddress("Allen Iverson", "8931 Trials Drive", "Nashville", "TN", 12034); // fourth test address
            test.AddAddress("Lonzo Ball", "91 Blanket Lane", "Gulfport", "MS", 89891); // fifth test address
            test.AddAddress("Demar Derozon", "8989 Fan Highway", "Cleveland", "OH", 78103); // sixth test address
            test.AddAddress("Anthony Davis", "0012 Shirt Drive", "Orlando", "FL", 90138); // seventh test address
            test.AddAddress("Kobe Bryant", "6969 Game Way", "Louisville", "KY", 40217); // eighth test address


            // below are a list of letters to be tested
            test.AddLetter(test.AddressAt(1), test.AddressAt(3), 5.38M); // first letter
            test.AddLetter(test.AddressAt(4), test.AddressAt(2), 9.01M); // second letter

            // below are a list of groundpackages to be tested
            test.AddGroundPackage(test.AddressAt(0), test.AddressAt(4), 9, 10, 12, 2); // first ground package
            test.AddGroundPackage(test.AddressAt(7), test.AddressAt(5), 10, 22, 14, 1); // second ground package

            // below are a list of next day air package to be tested
            test.AddNextDayAirPackage(test.AddressAt(6), test.AddressAt(2), 24, 60, 2, 8, 20.9M); // first next day air package
            test.AddNextDayAirPackage(test.AddressAt(0), test.AddressAt(7), 23, 9, 1, 43, 50.6M); // second next day air package
            test.AddNextDayAirPackage(test.AddressAt(4), test.AddressAt(2), 30, 9, 8, 23, 62.2M); // third next day air package

            // below are a list of two day air package to be tested
            test.AddTwoDayAirPackage(test.AddressAt(3), test.AddressAt(0), 31, 99, 80, 21, TwoDayAirPackage.Delivery.Early); // first two day air package
            test.AddTwoDayAirPackage(test.AddressAt(7), test.AddressAt(2), 22, 19, 5, 31, TwoDayAirPackage.Delivery.Saver); // second two day air package
            test.AddTwoDayAirPackage(test.AddressAt(5), test.AddressAt(7), 21, 19, 31, 40, TwoDayAirPackage.Delivery.Early); // third two day air package
        }


        //pre condition is that the about item is selected from menu
        // post condition is that a box will come up showing the program, who it was made by, and class number
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            MessageBox.Show($"Program 2{newline}Made by: 5272456{newline}CIS 200-50{newline} "); ;
        }

        // pre condition is exit button is selected from drop down menu
        // post condition is application closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // pre condition is addresses is selected from tab
        // post conditions is addresses is printed out for user
        private void listOfAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine; // create new line
            reportT.Clear();
            reportT.AppendText("Addresses:");
            reportT.AppendText(newline);
            foreach (Address o in test.AddressList) // prints gui
            {
                reportT.AppendText(o.ToString());
                reportT.AppendText(newline);
                reportT.AppendText("..................");
                reportT.AppendText(newline);
            }
        }

        // pre condition is parcels was selected from tab in menu
        // post condition is all parcels are displayed to the user
        private void listOfParclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine; // creates new line
            reportT.Clear();
            reportT.AppendText("Parcels:");
            reportT.AppendText(newline);
            foreach (Parcel o in test.ParcelList) // does the "work" in selecting all the parcel objects that need to be printed
            {
                reportT.AppendText(o.ToString());
                reportT.AppendText(newline);
                reportT.AppendText("...................");
                reportT.AppendText(newline);
            }
        }


        //pre condition is address option is selected
        //post condition is address is added or error message
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertAddressForm newform = new InsertAddressForm(); // connects insertaddress form to primary form
            DialogResult display; 
            int zipcode; // creating variable zip for validation
            display = newform.ShowDialog(); 
            if(DialogResult == DialogResult.OK) // only ads address if it is validated
            {
                if (int.TryParse(newform.zipcode, out zipcode))
                {
                    test.AddAddress(newform.Name, newform.addressline1, newform.addressline2, newform.city, newform.state, zipcode); // uses info that was inserted by user into system
                }
            }
        }

        // pre condition is letter is clicked on tab
        // post condition is InsertLetterForm is shown 
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertLetterForm letter; // insert letter form variable
            DialogResult display; // what will be resulting variable
            decimal cost; // final cost to send letter variable
            letter = new InsertLetterForm(test.AddressList);
            display = letter.ShowDialog();
            if (test.AddressCount < InsertLetterForm.min_address) // ensures letters are in form
            {
                MessageBox.Show("Two addresses are required!");
                this.DialogResult = DialogResult.Cancel;
            }
            if (display == DialogResult.OK) // must pass validation
            {
                if (decimal.TryParse(letter.FCT, out cost)) 
                {
                    test.AddLetter(test.AddressAt(letter.originAddress), test.AddressAt(letter.destAddress), cost); 
                }
            }
        }

        private void FileMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
