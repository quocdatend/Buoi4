using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class frm_List : Form
    {
        public frm_List()
        {
            InitializeComponent();
        }
        private int index = -1;
        private ListViewItem listViewItem1 = null;
        public bool isEdit = false;
        public void ReceiveValue(ListViewItem list)
        {
            if(isEdit)
            {
                lv_Details.Items.RemoveAt(index);
            }
            lv_Details.Items.Add(list);
            index = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            index = -1;
            frm_NV frm = new frm_NV(this);
            frm.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(index != -1)
            {
                lv_Details.Items.RemoveAt(index);
                index = -1;
            } else
            {
                MessageBox.Show("Vui long chon hang!", "Thong Bao");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(listViewItem1 != null)
            {
                frm_NV frm_NV = new frm_NV(this, listViewItem1, true);
                frm_NV.Show();
            } else
            {
                MessageBox.Show("Vui long chon hang!", "Thong Bao");
            }
        }

        private void lv_Details_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            listViewItem1 = new ListViewItem(e.Item.SubItems[0].Text);
            listViewItem1.SubItems.Add(e.Item.SubItems[1].Text);
            listViewItem1.SubItems.Add(e.Item.SubItems[2].Text);
            index = e.ItemIndex;
        }
    }
}
