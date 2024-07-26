namespace Buoi4
{
    partial class frm_NV
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
            this.lbl_MSNV = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.lbl_LuongCB = new System.Windows.Forms.Label();
            this.txt_MSNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_LuongCB = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MSNV
            // 
            this.lbl_MSNV.AutoSize = true;
            this.lbl_MSNV.Location = new System.Drawing.Point(57, 50);
            this.lbl_MSNV.Name = "lbl_MSNV";
            this.lbl_MSNV.Size = new System.Drawing.Size(46, 16);
            this.lbl_MSNV.TabIndex = 0;
            this.lbl_MSNV.Text = "MSNV";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Location = new System.Drawing.Point(57, 109);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(50, 16);
            this.lbl_TenNV.TabIndex = 1;
            this.lbl_TenNV.Text = "TenNV";
            // 
            // lbl_LuongCB
            // 
            this.lbl_LuongCB.AutoSize = true;
            this.lbl_LuongCB.Location = new System.Drawing.Point(57, 168);
            this.lbl_LuongCB.Name = "lbl_LuongCB";
            this.lbl_LuongCB.Size = new System.Drawing.Size(62, 16);
            this.lbl_LuongCB.TabIndex = 2;
            this.lbl_LuongCB.Text = "LuongCB";
            // 
            // txt_MSNV
            // 
            this.txt_MSNV.Location = new System.Drawing.Point(156, 47);
            this.txt_MSNV.Name = "txt_MSNV";
            this.txt_MSNV.Size = new System.Drawing.Size(271, 22);
            this.txt_MSNV.TabIndex = 3;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(156, 106);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(271, 22);
            this.txt_TenNV.TabIndex = 4;
            this.txt_TenNV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_LuongCB
            // 
            this.txt_LuongCB.Location = new System.Drawing.Point(156, 162);
            this.txt_LuongCB.Name = "txt_LuongCB";
            this.txt_LuongCB.Size = new System.Drawing.Size(271, 22);
            this.txt_LuongCB.TabIndex = 5;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(175, 242);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "Đồng Ý";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(302, 242);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 299);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_LuongCB);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_MSNV);
            this.Controls.Add(this.lbl_LuongCB);
            this.Controls.Add(this.lbl_TenNV);
            this.Controls.Add(this.lbl_MSNV);
            this.Name = "frm_NV";
            this.Text = "Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MSNV;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.Label lbl_LuongCB;
        private System.Windows.Forms.TextBox txt_MSNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_LuongCB;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Close;
    }
}