using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Tool_11._2.Classes.Common;

namespace TP_Tool_11._2.Forms.Common
{
    public partial class DataPicker : Form
    {
        private String Query { get; set; }
        private Boolean HasIcon { get; set; }
        private String DefaultFilter { get; set; }
        private TextBox textbox { get; set; }
        public DataPicker(String Query, String DefaultFilter, TextBox textbox,Boolean Icon)
        {
            InitializeComponent();

            this.Query = Query;
            this.HasIcon = HasChildren;
            this.DefaultFilter = DefaultFilter;

            Dataview.ReadOnly = true;
            Dataview.RowHeadersVisible = false;
            Dataview.AllowUserToAddRows = false;
            Dataview.AllowUserToResizeRows = false;
            Dataview.Refresh();
            Dataview.Dock = DockStyle.Fill;
            pb_icon.Image = new Bitmap(Properties.Settings.Default.path_icons + "/" + "ain_saw_lv1_ultimate01.jpg");

            Dataview.DataSource = sql.fetch_table(Query);
            Dataview.Size = this.Size;
        }

        private void tb_filter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb == tb_filter_value)
                (Dataview.DataSource as DataTable).DefaultView.RowFilter = string.Format(DefaultFilter, functions.EscapeLikeValue(tb.Text));
            else
            {
                try
                {
                    (Dataview.DataSource as DataTable).DefaultView.RowFilter = tb.Text;
                }
                catch { }
            }
        }

        private void Dataview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String img_path = Properties.Settings.Default.path_icons + "/" + Dataview.Rows[e.RowIndex].Cells[Dataview.ColumnCount-1].Value.ToString() + ".jpg";
            if (HasIcon && File.Exists(img_path))
                pb_icon.Image = new Bitmap(img_path);

            //textbox.Text = Dataview.Rows[e.RowIndex].Cells[0].Value.ToString();
            //textbox.Tag = Dataview.Rows[e.RowIndex].Cells[1].Value.ToString();*/
        }
    }
}
