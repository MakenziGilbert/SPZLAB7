using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZLAB7.Classes;

namespace SPZLAB7
{
    public partial class AddCompany : Form
    {
        public Companies company { get; set; }
        public AddCompany()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            company = new Companies(CompanyTbx.Text, Int32.Parse(AmountTbx.Text));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
