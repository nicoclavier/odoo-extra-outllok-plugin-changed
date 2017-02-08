namespace OpenERPOutlookPlugin
{
    partial class frm_comfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_comfirm));
            this.ok_created = new System.Windows.Forms.Button();
            this.button_view_url = new System.Windows.Forms.Button();
            this.displayed_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_created
            // 
            this.ok_created.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // displayed_text
            // 
            this.displayed_text.AutoSize = true;
            this.displayed_text.Location = new System.Drawing.Point(12, 9);
            this.displayed_text.Name = "displayed_text";
            this.displayed_text.Size = new System.Drawing.Size(189, 13);
            this.displayed_text.TabIndex = 3;
            this.displayed_text.Text = "The contact was successfully created!";
            // 
            // frm_comfirm
            // 
            this.AcceptButton = this.ok_created;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ok_created;
            this.ClientSize = new System.Drawing.Size(395, 92);
            this.ControlBox = false;
            this.Controls.Add(this.displayed_text);
            this.Controls.Add(this.button_view_url);
            this.Controls.Add(this.ok_created);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_comfirm";
            this.Text = "Odoo Partners";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_created;
        private System.Windows.Forms.Button button_view_url;
        private System.Windows.Forms.Label displayed_text;
    }
}