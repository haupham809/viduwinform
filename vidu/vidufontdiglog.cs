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
    public partial class vidufontdiglog : Form
    {
        public vidufontdiglog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }

        }


    }
}
