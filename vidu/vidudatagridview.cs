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
    public partial class vidudatagridview : Form
    {
        public vidudatagridview()
        {
            InitializeComponent();
            loaddatagridview();

        }

        public void loaddatagridview()
        {
            DataTable a = new DataTable("people");
            a.Columns.Add("ten");
            a.Columns.Add("ngay sinh");
            a.Columns.Add("gioi tinh");
            a.Columns.Add("noi o");
            a.Rows.Add(new object[] { "hau", "19", "nam", "quang ngai" });

            a.Rows.Add(new object[] { "do quoc tuan", "12", "nam", "binh dinh" });

            a.Rows.Add(new object[] { "hoang huy tuan", "12", "nam", "gia lai" });

            a.Rows.Add(new object[] { "trong truong", "23", "nam", "gia lai" });
            dataGridView1.DataSource = a;
        }

       
    }
}
