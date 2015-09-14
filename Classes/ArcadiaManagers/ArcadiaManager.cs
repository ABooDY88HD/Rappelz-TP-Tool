using System;
using System.Collections.Generic;
using System.Data;
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

        private TextBox[] textbox;
        private Int32[] additional;

        public ArcadiaManager(BaseArcadiaManager base_arcadia_manager)
        {
            this.base_arcadia_manager = base_arcadia_manager;

            //just to make the datagrid easy to access
            datagrid = base_arcadia_manager.base_datagrid = new DataGridView();

            base_arcadia_manager.base_select_query = base_arcadia_manager.base_xml_file.readProperty("select_query");
            base_arcadia_manager.base_format_type = Convert.ToInt32(base_arcadia_manager.base_xml_file.readProperty("format_type"));
            base_arcadia_manager.base_value_filter = base_arcadia_manager.base_xml_file.readProperty("string_filter");

            fetch_database_data();
            format_datagrid();
            Initialize_tooltip();

            //event listener datagrid_cell_enter
            datagrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_cell_entered);
            base_arcadia_manager.base_button_data_viewer.Click += new System.EventHandler(this.button_data_viewer_clicked);
        }

        public void set_common_fields(TextBox[] textbox, Int32[] additional)
        {
            this.textbox = textbox;
            this.additional = additional;

            textbox[0].TextChanged += new EventHandler(textbox_changed);
        }

        private void textbox_changed(object sender, EventArgs e)
        {
            for (int i = 0; i < textbox.Length; i++)
                textbox[i].Text = textbox[0].Text + additional[i];
        }

        //format the datagrid according to set of rules predfined in the project
        private void format_datagrid()
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
        private void fetch_database_data()
        {
            datagrid.DataSource = sql.fetch_table(base_arcadia_manager.base_select_query);
        }

        //on cell enter handler (displays datagrid info)
        private void datagrid_cell_entered(object sender, DataGridViewCellEventArgs e)
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
                    if (control is AM_CheckBox)
                        ((AM_CheckBox)control).Checked = (datagrid.Rows[datagrid.CurrentCell.RowIndex].Cells[c.HeaderText].Value.ToString() == "1" || datagrid.Rows[datagrid.CurrentCell.RowIndex].Cells[c.HeaderText].Value.ToString() == "true");
                }
            }
        }

        private void button_data_viewer_clicked(object sender, EventArgs e)
        {
            //create a new form
            new DatagridViewer(this).ShowDialog();
        }

        private void Initialize_tooltip()
        {

            foreach (DataColumn c in ((DataTable)datagrid.DataSource).Columns)
            {
                if (((Form)base_arcadia_manager).Controls.Find("tp_" + c.ColumnName, true).Length == 0)
                    Debug.WriteLine("The header \"" + c.ColumnName + "\" hasn't been found, you may have missed it somehow");
                else
                {
                    Control control = (Control)((Form)base_arcadia_manager).Controls.Find("tp_" + c.ColumnName, true)[0];
                    if (control is AM_TextBox)
                        ((AM_TextBox)control).TextTooltip = base_arcadia_manager.base_xml_file.readTrnaslation(c.ColumnName);
                    if (control is CheckBox)
                        ((CheckBox)control).Checked = (datagrid.Rows[datagrid.CurrentCell.RowIndex].Cells[c.ColumnName].Value.ToString() == "1" || datagrid.Rows[datagrid.CurrentCell.RowIndex].Cells[c.ColumnName].Value.ToString() == "true");
                }
            }
        }
    }
}
