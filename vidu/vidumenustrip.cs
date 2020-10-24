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
    public partial class vidumenustrip : Form
    {
        public vidumenustrip()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        //vidu menustrip
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form new_window = new Form();
            new_window.Text = "cua so moi";
            new_window.MdiParent = this;
            new_window.Show();

        }
    }
}
