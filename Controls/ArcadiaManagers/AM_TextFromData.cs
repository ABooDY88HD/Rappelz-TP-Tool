using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Tool_11._2.Forms.Common;

namespace TP_Tool_11._2.Controls.ArcadiaManagers
{
    public partial class AM_TextFromData : UserControl
    {
        [Browsable(true)]
        [DefaultValue(true)]

        ToolTip tooltip = new ToolTip();

        public override String Text
        {
            get { return am_tb.Text; }
            set { am_tb.Text = value; Invalidate(); }
        }

        public String TextLabel
        {
            get { return am_lb.Text; }
            set { am_lb.Text = value; }
        }

        public String TextTooltip
        {
            get { return tooltip.GetToolTip(am_tooltip); }
            set { tooltip.SetToolTip(am_tooltip, value); }
        }

        public String SelectQuery { get; set; }
        public String DefaultFilter { get; set; }
        public Boolean hasIcon { get; set; }

        public AM_TextFromData()
        {
            InitializeComponent();

            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.IsBalloon = true;
            tooltip.ShowAlways = true;
        }

        private void am_bt_Click(object sender, EventArgs e)
        {
            new DataPicker(SelectQuery, DefaultFilter, am_tb, hasIcon).ShowDialog();
        }

        private void am_tb_TextChanged(object sender, EventArgs e)
        {
            //tooltip.SetToolTip(am_tb, am_tb.Tag.ToString());
        }
    }
}
