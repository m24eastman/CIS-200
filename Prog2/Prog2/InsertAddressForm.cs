// 5272456
// CIS 200-50
// Program 2
// 10/25/2021
// code for insert letter form. this runs the back end and test subjects for the form.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class InsertAddressForm : Form
    {
        // there is no pre condition
        // post condition is insert address form will be shown to user
        public InsertAddressForm()
        {
            InitializeComponent();

            List<string> states = new List<string> { "Alabama", "Alaska", "Arizona", "Arkansas", "California" }; // states used for testing
            //insert all states into list
            foreach (string State in states)
            {
                stateBox.Items.Add(State);
            }
        }
        internal string name
        {
            // there is no precondition
            // post condition is text from user is returned from the nameBox
            get
            {
                return nameBox.Text;
            }
            // there is no precondition
            // post condition is text from user is set to value from nameBox
            set
            {
                nameBox.Text = value;
            }
        }
        internal string addressline1
        {
            // there is no precondition
            // post conidiotn is address line 1 text box is returned
            get
            {
                return address1box.Text;
            }
            // there is no precondition
            //post condiitoin is value from address line 1 text box is set
            set
            {
                address1box.Text = value;
            }
        }
        internal string addressline2
        {
            // there is no precondition
            // post condition is address line 2 text box value returns
            get
            {
                return address2Box.Text;
            }
            // there is no precondition
            //post condition is value from address line 2 txt box is set
            set
            {
                address2Box.Text = value;
            }
        }
        internal string city
        {
            //there is no precondition
            // post condition is city value is returned
            get
            {
                return cityBox.Text;
            }
            // there is no pre condition
            // post condition is city text box value is set 
            set
            {
                cityBox.Text = value;
            }
        }
        internal string state
        {
            // there is no precondition
            // post condition is state value txt box is returned
            get
            {
                return stateBox.Text;
            }
            // there is no pre condition
            // post condition is state value text box is set
            set
            {
                stateBox.Text = value;
            }
        }
        internal string zipcode
        {
            // there is no precondition
            // post condition is zipcode value is set
            get
            {
                return zipBox.Text;
            }
            // there is no pre condition
            // post condition is zipcode text box value is set
            set
            {
                zipBox.Text = value;
            }
        }
        // there is no pre condition
        // post condition is whenever an invalid valid is entered, an error will occur that does not let user advance
        private void Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(nameBox, "Name is not valid.");
                nameBox.SelectAll();
            }
        }
        // pre condition is value entered inside name is valid
        // post condition is error test is cleared
        private void Name_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameBox, "");
        }
        // ther is no precondition
        // post condition is any invalid value for address 1 will result in error that does not allow user to advance
        private void Address1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address1box.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(address1box, "Address is not valid.");
                address1box.SelectAll();
            }
        }
        //pre condition is value entered in address line 1 are valid
        // post condition is it clears the error test
        private void Address1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(address1box, "");
        }
        // there is no precondition
        //post condition is invalid value for city will result in error that does not allow user to advance
        private void City_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cityBox, "City is not valid.");
                cityBox.SelectAll();
            }
        }
        // pre condition is city value is valid
        // post condition is it clears the error test
        private void City_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityBox, "");
        }
        // there is no pre condition
        // post condition is user gets error unless state is selected
        private void Sate_Validating(object sender, CancelEventArgs e)
        {
            if (stateBox.SelectedIndex == -1) // has user selected a state from list
            {
                e.Cancel = true;
                errorProvider1.SetError(stateBox, "Select a state.");

            }
        }
        // pre condition is state field must be selected
        // post condition is it clears the error test
        private void Sate_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(stateBox, "");
        }
        // there is no pre condition
        // post condition is any invalic zipcode value will show error message that does not allow user to advance
        private void ZipCode_Validating(object sender, CancelEventArgs e)
        { 
            int zipcode;
            if (!int.TryParse(zipBox.Text, out zipcode) || zipcode < Address.MIN_ZIP && zipcode > Address.MAX_ZIP) 
                                                                                                           
            {
                e.Cancel = true;
                errorProvider1.SetError(zipBox, "Zipcode is not valid.");
                zipBox.SelectAll();
            }
        }
        // pre condition is zipcode is valid
        // post condition is it clears the error test
        private void ZipCode_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipBox, "");
        }
        // there is no pre condition
        // post condition is user clicks the cancel button
        private void Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        // pre condition is all fields are valid
        // post condition is user clicks the add address button and adds it to the list
        private void AddAddressBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void StateCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
