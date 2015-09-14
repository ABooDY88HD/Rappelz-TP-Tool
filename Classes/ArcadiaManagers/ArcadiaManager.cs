using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Tool_11._2.Controls.ArcadiaManagers;

namespace TP_Tool_11._2
{
    public class ArcadiaManager
    {
        public BaseArcadiaManager base_arcadia_manager { get; set; }
        public DataGridView datagrid { get; set; }

        public ArcadiaManager(BaseArcadiaManager base_arcadia_manager)
        {
            this.base_arcadia_manager = base_arcadia_manager;

            //just to make the datagrid easy to access
            datagrid = base_arcadia_manager.base_datagrid;

            format_datagrid();
            fetch_database_data();

            datagrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_cell_entered);
            base_arcadia_manager.base_button_data_viewer.Click += new System.EventHandler(this.button_data_viewer_clicked);
        }

        //format the datagrid according to set of rules predfined in the project
        public void format_datagrid()
        {
            switch (base_arcadia_manager.base_format_type)
            {
                //cases are here (for diffrent formatting)
                case 0:
                    datagrid.ReadOnly = true;
                    datagrid.RowHeadersVisible = false;
                    datagrid.AllowUserToAddRows = false;
                    datagrid.AllowUserToResizeRows = false;
                    datagrid.Refresh();
                    datagrid.Dock = DockStyle.Fill;
                    break;
            }
        }


        //copy database info into the datagridview
        public void fetch_database_data()
        {
            datagrid.DataSource = sql.fetch_table(base_arcadia_manager.base_select_query);
        }

        //on cell enter handler (displays datagrid info)
        public void datagrid_cell_entered(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                datagrid.Rows[e.RowIndex].Selected = true;

            foreach (DataGridViewColumn c in datagrid.Columns)
            {
                if (((Form)base_arcadia_manager).Controls.Find("tp_" + c.HeaderText, true).Length == 0)
                    Debug.WriteLine("The header \"" + c.HeaderText + "\" hasn't been found, you may have missed it somehow");
                else
                {
                    Control control = (Control)((Form)base_arcadia_manager).Controls.Find("tp_" + c.HeaderText, true)[0];
                    if (control is AM_TextBox)
                        ((AM_TextBox)control).Text = datagrid.Rows[datagrid.CurrentCell.RowIndex].Cells[c.HeaderText].Value.ToString();
                    if (control is CheckBox)
                        ((CheckBox)control).Checked = (datagrid.Rows[datagrid.CurrentCell.RowIndex].Cells[c.HeaderText].Value.ToString() == "1" || datagrid.Rows[datagrid.CurrentCell.RowIndex].Cells[c.HeaderText].Value.ToString() == "true");
                }
            }
        }

        private void button_data_viewer_clicked(object sender, EventArgs e)
        {
            //create a new form
            new DatagridViewer(this).ShowDialog();
        }
    }
}
