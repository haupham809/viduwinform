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
    public partial class vidulisstview : Form
    {
        public vidulisstview()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = null;
            string price = null;
            string quantity = null;

            if (listView1.SelectedItems.Count > 0)
            {
                productName = listView1.SelectedItems[0].SubItems[0].Text;
                price = listView1.SelectedItems[0].SubItems[1].Text;
                quantity = listView1.SelectedItems[0].SubItems[2].Text;

                MessageBox.Show(productName + " \n price: " + price + "\nquantity: " + quantity);

            }
            else
            {
                MessageBox.Show("Moi chon 1 san pham ");
            }
        }

        private void vidulisstview_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Ten san pham", 100);
            listView1.Columns.Add("Gia", 100);
            listView1.Columns.Add("SO luong", 100);

            string[] arr = new string[4];
            ListViewItem itm;

            arr[0] = " San pham 01";
            arr[1] = " 100";
            arr[2] = " 10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            arr[0] = " San pham 02";
            arr[1] = " 200";
            arr[2] = " 20";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);


        }
    }
}
