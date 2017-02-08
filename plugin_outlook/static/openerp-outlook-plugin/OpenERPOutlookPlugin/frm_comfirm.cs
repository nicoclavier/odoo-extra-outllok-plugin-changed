using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenERPOutlookPlugin
{
    public partial class frm_comfirm : Form
    {
        public String url = null;

        public frm_comfirm()
        {
            InitializeComponent();
        }

        public void UpdateDisplayedText(string input)
        {
            this.displayed_text.Text = input;
        }

        public void RedirectWeb(object web_url)
        {
            /*
             * Will open the url into the web browser.
             */
            System.Diagnostics.Process.Start(web_url.ToString());
        }

        private void button_view_in_odoo_Click(object sender, EventArgs e)
        {
            if (this.url != null)
            {
                this.RedirectWeb(this.url);
            }
            this.Close();
        }

         private void close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
