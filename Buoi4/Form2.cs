using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class frm_NV : Form
    {
        private frm_List frmList;
        private bool isEdit = false;
        public frm_NV()
        {
            InitializeComponent();
        }
        
        public frm_NV(frm_List parent)
        {
            InitializeComponent();
            frmList = parent;
        }
        public frm_NV(frm_List parent, ListViewItem listViewItem, bool isTrue)
        {
            InitializeComponent();
            txt_MSNV.Text = listViewItem.SubItems[0].Text;
            txt_TenNV.Text = listViewItem.SubItems[1].Text;
            txt_LuongCB.Text = listViewItem.SubItems[2].Text;
            isEdit = isTrue;
            frmList = parent;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ListViewItem list = new ListViewItem(txt_MSNV.Text);
            list.SubItems.Add(txt_TenNV.Text);
            list.SubItems.Add(txt_LuongCB.Text);
            if(isEdit)
            {
                frmList.isEdit = true;
            }
            frmList.ReceiveValue(list);
            this.Close();
        }
    }
}
