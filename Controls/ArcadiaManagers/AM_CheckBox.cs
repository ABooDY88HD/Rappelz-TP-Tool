using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_Tool_11._2.Controls.ArcadiaManagers
{
    public partial class AM_CheckBox : UserControl
    {
        [Browsable(true)]
        [DefaultValue(true)]

        ToolTip tooltip = new ToolTip();

        public Boolean Checked
        {
            get { return AM_cb.Checked; }
            set { AM_cb.Checked = value; Invalidate(); }
        }

        public String TextLabel
        {
            get { return AM_cb.Text; }
            set { AM_cb.Text = value; }
        }

        public String TextTooltip
        {
            get { return tooltip.GetToolTip(am_tooltip); }
            set { tooltip.SetToolTip(am_tooltip, value); }
        }

        public AM_CheckBox()
        {
            InitializeComponent();

            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.IsBalloon = true;
            tooltip.ShowAlways = true;
        }
    }
}
