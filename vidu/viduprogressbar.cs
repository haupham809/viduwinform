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
    public partial class viduprogressbar : Form
    {
        public viduprogressbar()
        {
            InitializeComponent();
        }
        //vi du progressbar
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for(int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }

        }
    }
}
