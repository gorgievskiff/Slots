using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slots
{
    public partial class AddFunds : Form
    {
        public int Amount { get; set; }

        public AddFunds()
        {
            InitializeComponent();
            tbFunds.Focus();
        }

        private void tbFounds_Validating(object sender, CancelEventArgs e)
        {
            int newAmount;
            if(String.IsNullOrEmpty(tbFunds.Text))
            {
                errorProvider1.SetError(tbFunds, "Amount required!");
                e.Cancel = true;
            }
            else
            {
                if (!Int32.TryParse(tbFunds.Text, out newAmount))
                {
                    errorProvider1.SetError(tbFunds, "Only numbers are allowed!");
                    e.Cancel = true;
                }
                else
                {
                    this.Amount = newAmount;
                    errorProvider1.SetError(tbFunds, null);
                    e.Cancel = false;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
