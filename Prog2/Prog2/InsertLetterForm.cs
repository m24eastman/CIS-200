// 5272456
// CIS 200-50
// Program 2
// 10/25/2021
// code behind the insert letter form. it sends all entered information back into the main form
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
    public partial class InsertLetterForm : Form
    {

        public const int min_address= 2; //addresses needed for the form
        List<Address>  list;
        // pre condition is at least two addresses are available
        // post condition is form is shown
        public InsertLetterForm(List<Address> addresses) // populates drop dowm list with names
        {
            InitializeComponent();
            list = addresses;
            foreach (Address a in list) // populates list
            {
                originBox.Items.Add(a.Name);
                destBox.Items.Add(a.Name);
            }
        }
        internal int originAddress
        {
            // there is no precondition
            // post condition is value is returned
            get
            {
                return originBox.SelectedIndex;
            }

            // pre condition is origin address box is not empty
            // post condition is value for origin address box is returned
            set
            {
                if ((value <= -1) && (value > list.Count)) // entered value must be between -1 and max 
                {
                    throw new ArgumentOutOfRangeException("Origin Address is not valid."); 
                }
                else
                {
                    originBox.SelectedIndex = value;
                }
            }
        }
        internal int destAddress
        {
            // there is no precondition
            // post condition is dest address value is returned
            get
            {
                return destBox.SelectedIndex;
            }
            set
            {
                // pre cond is dest add box cannot be empty
                // post cond is value in dest add box is returned
                if ((value <=-1) && (value > list.Count)) 
                {
                    throw new ArgumentOutOfRangeException("Destination Address is not valid.");
                }
                else
                {
                    destBox.SelectedIndex = value;
                }
            }
        }
        internal string FCT
        {
            // there is no pre cond
            // post cond is value is returned
            get
            {
                return fixedBox.Text;
            }

            // there is no pre condition
            // post cond is value is set to FCT variable
            set
            {
                fixedBox.Text = value;
            }
        }

        // there is no  precondition
        // post cond is no addresses are selected or addresses are repeated, error appears
        private void OAddress_Validating(object sender, CancelEventArgs e)
        {
            if ((originBox.SelectedIndex == -1) || (originBox.SelectedIndex == destBox.SelectedIndex)) // addresses cannot repeat
            {
                e.Cancel = true;
                errorProvider1.SetError(originBox, "Please select an address");
            }
        }

        // pre cond is values have passed validation
        // post cond is error is cleared
        private void OAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originBox, " ");
        }
        // there is no pre condition
        // post condition is error will not allow user to advance if no address is selected
        private void DAddress_Validating(object sender, CancelEventArgs e)
        {
            if ((destBox.SelectedIndex == -1) || (destBox.SelectedIndex == originBox.SelectedIndex)) // addresses do not repeat
            {
                e.Cancel = true;
                errorProvider1.SetError(destBox, "Please select valid address.");
            }
        }
        // pre cond is dest address is validated
        // post cond is error is cleared
        private void DAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destBox, " ");
        }
        // there is no pre condition
        // post cond is error wont let user advance is fixed cost value is not valid
        private void FC_Validating(object sender, CancelEventArgs e)
        {
            double costs;

            if (!double.TryParse(fixedBox.Text, out costs) || costs < 0) // is value less than 0?
            {
                e.Cancel = true;
                fixedBox.SelectAll();
                errorProvider1.SetError(fixedBox, "Fixed cost is invalid.");
            }
        }
        // pre cond is fixed cost is validated
        // post cond is error is cleared
        private void FC_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedBox, " ");
        }
        // there is no pre cond
        // post cond is user closes application
        private void cancelBTN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

       // pre cond is all fields clear the validation test
       // post cond is data is inserted into list of parcels
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FCTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
