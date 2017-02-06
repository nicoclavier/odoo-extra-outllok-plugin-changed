namespace OpenERPOutlookPlugin
{
    partial class frm_comfirm_create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_comfirm_create));
            this.ok_created = new System.Windows.Forms.Button();
            this.button_view_url = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ok_created
            // 
            this.ok_created.Location = new System.Drawing.Point(297, 58);
            this.ok_created.Name = "ok_created";
            this.ok_created.Size = new System.Drawing.Size(75, 23);
            this.ok_created.TabIndex = 0;
            this.ok_created.Text = "OK";
            this.ok_created.UseVisualStyleBackColor = true;
            this.ok_created.Click += new System.EventHandler(this.close);
            // 
            // button_view_url
            // 
            this.button_view_url.Location = new System.Drawing.Point(211, 58);
            this.button_view_url.Name = "button_view_url";
            this.button_view_url.Size = new System.Drawing.Size(80, 23);
            this.button_view_url.TabIndex = 1;
            this.button_view_url.Text = "View in Odoo";
            this.button_view_url.UseVisualStyleBackColor = true;
            this.button_view_url.Click += new System.EventHandler(this.button_view_in_odoo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "The document was successfully created.";
            // 
            // frm_comfirm_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 93);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_view_url);
            this.Controls.Add(this.ok_created);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_comfirm_create";
            this.Text = "Partner Creation Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_created;
        private System.Windows.Forms.Button button_view_url;
        private System.Windows.Forms.TextBox textBox1;
    }
}