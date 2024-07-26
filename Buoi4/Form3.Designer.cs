namespace Buoi4
{
    partial class frm_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_Details = new System.Windows.Forms.ListView();
            this.col_MSNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_LuongCB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Details
            // 
            this.lv_Details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_MSNV,
            this.col_TenNV,
            this.col_LuongCB});
            this.lv_Details.FullRowSelect = true;
            this.lv_Details.HideSelection = false;
            this.lv_Details.Location = new System.Drawing.Point(12, 12);
            this.lv_Details.Name = "lv_Details";
            this.lv_Details.Size = new System.Drawing.Size(594, 431);
            this.lv_Details.TabIndex = 0;
            this.lv_Details.UseCompatibleStateImageBehavior = false;
            this.lv_Details.View = System.Windows.Forms.View.Details;
            this.lv_Details.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Details_ItemSelectionChanged);
            // 
            // col_MSNV
            // 
            this.col_MSNV.Text = "MSNV";
            // 
            // col_TenNV
            // 
            this.col_TenNV.Text = "Ten NV";
            // 
            // col_LuongCB
            // 
            this.col_LuongCB.Text = "Luong CB";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(667, 51);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(667, 114);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(667, 180);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(667, 244);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lv_Details);
            this.Name = "frm_List";
            this.Text = "List View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Details;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ColumnHeader col_MSNV;
        private System.Windows.Forms.ColumnHeader col_TenNV;
        private System.Windows.Forms.ColumnHeader col_LuongCB;
    }
}