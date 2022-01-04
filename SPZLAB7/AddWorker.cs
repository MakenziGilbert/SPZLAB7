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
    public partial class AddWorker : Form
    {
        public Workers worker { get; set; }
        public AddWorker()
        {
            InitializeComponent();
        }

        private void AddWorkerBtn_Click(object sender, EventArgs e)
        {
            worker = new Workers(AddNameTbx.Text, AddSurnameTbx.Text, Int32.Parse(AddSalaryTbx.Text));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
