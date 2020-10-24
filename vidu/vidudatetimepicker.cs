using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu
{
    public partial class vidudatetimepicker : Form
    {
        public vidudatetimepicker()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());

        }

        
    }
}
