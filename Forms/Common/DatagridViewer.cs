using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Tool_11._2.Classes.ArcadiaManager;
using TP_Tool_11._2.Classes.Common;

namespace TP_Tool_11._2.Forms.Common
{
    public partial class DatagridViewer : Form
    {
        private ArcadiaManager arcadia_manager { get; set; }
        private String[] dataview_columns { get; set; }

        public DatagridViewer(ArcadiaManager arcadia_manager)
        {
            InitializeComponent();
            this.arcadia_manager = arcadia_manager;

            //load desired columns from the xml file
            dataview_columns = arcadia_manager.base_arcadia_manager.base_xml_file.readProperty("dataview_columns").Split(',');
            this.tableLayoutPanel1.Controls.Add(arcadia_manager.datagrid);
        }

        private void tb_filter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb == tb_filter_value)
                (arcadia_manager.datagrid.DataSource as DataTable).DefaultView.RowFilter = string.Format(arcadia_manager.base_arcadia_manager.base_value_filter, functions.EscapeLikeValue(tb.Text));
            else
            {
                try
                {
                    (arcadia_manager.datagrid.DataSource as DataTable).DefaultView.RowFilter = tb.Text;
                }
                catch { }
            }
        }

        private void cb_advanced_CheckedChanged(object sender, EventArgs e)
        {
            //hide-show all columns except those in the settings file
            foreach (DataGridViewColumn column in arcadia_manager.datagrid.Columns)
                if (!dataview_columns.Contains(column.HeaderText))
                    column.Visible = false || cb_advanced.Checked;
                else
                    column.Visible = true;
        }

        private void DatagridViewer_Load(object sender, EventArgs e)
        {
            //activate on check event to get the unneeded columns hidden
            cb_advanced.Checked = false;
        }
    }
}
