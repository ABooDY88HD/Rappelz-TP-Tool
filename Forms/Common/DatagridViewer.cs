using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Tool_11._2.Classes.Common;

namespace TP_Tool_11._2
{
    public partial class DatagridViewer : Form
    {
        public ArcadiaManager arcadia_manager { get; set; }

        public DatagridViewer(ArcadiaManager arcadia_manager)
        {
            InitializeComponent();
            this.arcadia_manager = arcadia_manager;
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
    }
}
