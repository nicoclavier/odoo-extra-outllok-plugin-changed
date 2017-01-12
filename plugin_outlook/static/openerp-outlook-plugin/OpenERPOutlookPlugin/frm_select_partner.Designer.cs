using System;

namespace OpenERPOutlookPlugin
{
    partial class frm_select_partner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_select_partner));
            this.txt_select_partner = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.partnerGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_select_partner_select = new System.Windows.Forms.Button();
            this.btn_select_partner_close = new System.Windows.Forms.Button();
            this.btn_select_partner_search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partnerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_select_partner
            // 
            this.txt_select_partner.Location = new System.Drawing.Point(19, 20);
            this.txt_select_partner.Name = "txt_select_partner";
            this.txt_select_partner.Size = new System.Drawing.Size(389, 20);
            this.txt_select_partner.TabIndex = 0;
            this.txt_select_partner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.partnerGrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 368);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partner Name";
            // 
            // partnerGrid
            // 
            this.partnerGrid.AllowUserToAddRows = false;
            this.partnerGrid.AllowUserToDeleteRows = false;
            this.partnerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partnerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.partnerGrid.Location = new System.Drawing.Point(6, 19);
            this.partnerGrid.MultiSelect = false;
            this.partnerGrid.Name = "partnerGrid";
            this.partnerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partnerGrid.Size = new System.Drawing.Size(464, 343);
            this.partnerGrid.TabIndex = 5;
            this.partnerGrid.DoubleClick += new System.EventHandler(this.btn_link_to_partner_click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.FillWeight = 1F;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 2;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Partner Name";
            this.name.MinimumWidth = 2;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // btn_select_partner_select
            // 
            this.btn_select_partner_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_partner_select.Image = global::OpenERPOutlookPlugin.Properties.Resources.Success;
            this.btn_select_partner_select.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_select_partner_select.Location = new System.Drawing.Point(366, 432);
            this.btn_select_partner_select.Name = "btn_select_partner_select";
            this.btn_select_partner_select.Size = new System.Drawing.Size(53, 23);
            this.btn_select_partner_select.TabIndex = 6;
            this.btn_select_partner_select.Text = "&Link";
            this.btn_select_partner_select.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_select_partner_select.UseVisualStyleBackColor = true;
            this.btn_select_partner_select.Click += new System.EventHandler(this.btn_link_to_partner_click);
            // 
            // btn_select_partner_close
            // 
            this.btn_select_partner_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_partner_close.Image = global::OpenERPOutlookPlugin.Properties.Resources.Error;
            this.btn_select_partner_close.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_select_partner_close.Location = new System.Drawing.Point(425, 432);
            this.btn_select_partner_close.Name = "btn_select_partner_close";
            this.btn_select_partner_close.Size = new System.Drawing.Size(64, 23);
            this.btn_select_partner_close.TabIndex = 5;
            this.btn_select_partner_close.Text = "&Close ";
            this.btn_select_partner_close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_select_partner_close.UseVisualStyleBackColor = true;
            this.btn_select_partner_close.Click += new System.EventHandler(this.btn_select_partner_close_Click);
            // 
            // btn_select_partner_search
            // 
            this.btn_select_partner_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_partner_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_select_partner_search.Image")));
            this.btn_select_partner_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_select_partner_search.Location = new System.Drawing.Point(414, 19);
            this.btn_select_partner_search.Name = "btn_select_partner_search";
            this.btn_select_partner_search.Size = new System.Drawing.Size(75, 23);
            this.btn_select_partner_search.TabIndex = 1;
            this.btn_select_partner_search.Text = "&Search ";
            this.btn_select_partner_search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_select_partner_search.UseVisualStyleBackColor = true;
            this.btn_select_partner_search.Click += new System.EventHandler(this.btn_select_partner_search_Click);
            // 
            // frm_select_partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_select_partner_select);
            this.Controls.Add(this.btn_select_partner_close);
            this.Controls.Add(this.btn_select_partner_search);
            this.Controls.Add(this.txt_select_partner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_select_partner";
            this.Text = "Select Partner";
            this.Load += new System.EventHandler(this.frm_select_partner_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partnerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_select_partner;
        private System.Windows.Forms.Button btn_select_partner_search;
        private System.Windows.Forms.Button btn_select_partner_close;
        private System.Windows.Forms.Button btn_select_partner_select;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView partnerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}