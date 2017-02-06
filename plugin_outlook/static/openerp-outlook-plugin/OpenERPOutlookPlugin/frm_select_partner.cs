/*
    OpenERP, Open Source Business Applications
    Copyright (c) 2011 OpenERP S.A. <http://openerp.com>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


using System;
using System.Collections;
using System.Windows.Forms;
using OpenERPClient;
using outlook = NetOffice.OutlookApi;

namespace OpenERPOutlookPlugin
{

    public partial class frm_select_partner : Form
    {

        public frm_select_partner()
        {
            InitializeComponent();
           
        }

        public Form parent_form = null;

        private void btn_select_partner_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void search_lst_partner()
        {
            /*
            * Will search the list of partners as per the given search criteria.
            */
            try
                 {
                partnerGrid.Rows.Clear();
                foreach (Record oo in Cache.OpenERPOutlookPlugin.DomainSearchRecord("[('name','ilike','" + txt_select_partner.Text + "'),('is_company','=',True)]", "res.partner"))
                {
                    partnerGrid.Rows.Add(oo.id, oo.name);
                }
                if (partnerGrid.Rows.Count == 0)
                {
                    Connect.displayMessage("No matching Partner(s) found.");
                }
            }
            catch (Exception ex)
            {
                Connect.handleException(ex);
            }
        }

        private void btn_select_partner_search_Click(object sender, EventArgs e)
        {
            search_lst_partner();
        }
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Do something
                search_lst_partner();
            }
        }
        private void PopulateDataGridView()
        {
            Record[] partenr_list = Cache.OpenERPOutlookPlugin.DomainSearchRecord("[('is_company','=',True)]", "res.partner");

            foreach (Record partner in partenr_list)
            {
                partnerGrid.Rows.Add(partner.id,partner.name);
            }
        }

        //private void partnerGrid_SelectionChanged(object sender, EventArgs e)
        //{ 
        //    // useless if we read straight from the selected row ...
        //    //selectedPartnerId = partnerGrid.SelectedRows.[0].Cells[0].Value.ToString();
        //}

        private void btn_link_to_partner_click(object sender, EventArgs e)
        {
            try
            {
                if (partnerGrid.SelectedRows == null)
                {
                    throw new Exception("Please select a partner from the list.");
                }
                else
                {
                    txt_select_partner.Text = partnerGrid.SelectedRows[0].Cells[1].Value.ToString();
                    int partner_id = int.Parse(partnerGrid.SelectedRows[0].Cells[0].Value.ToString());
                    foreach (outlook.MailItem mailItem in Tools.MailItems())
                    {
                        Cache.OpenERPOutlookPlugin.CreateContactRecord(partner_id, mailItem.SenderName, mailItem.SenderEmailAddress);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Connect.handleException(ex);
            }

        }

        private void frm_select_partner_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}