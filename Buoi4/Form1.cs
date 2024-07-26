using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text != "" && txtLastName.Text != "" && txtPhone.Text != "") {
                ListViewItem lvi = new ListViewItem(txtLastName.Text);
                lvi.SubItems.Add(txtFirstName.Text);
                lvi.SubItems.Add(txtPhone.Text);
                lv_Details.Items.Add(lvi);
            } else
            {
                MessageBox.Show("Yeu cau nhap du First Name, Last Name, Phone!", "Thong bao");
            }
        }

        private void lv_Details_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtFirstName.Text = e.Item.SubItems[1].Text;
            txtLastName.Text = e.Item.SubItems[0].Text;
            txtPhone.Text = e.Item.SubItems[2].Text;
        }
    }
}
