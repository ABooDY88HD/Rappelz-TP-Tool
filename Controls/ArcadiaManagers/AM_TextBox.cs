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
    public partial class AM_TextBox : UserControl
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
            get{return tooltip.GetToolTip(am_tooltip);}
            set{tooltip.Show(value, am_tooltip, 10000);}
        }

        public AM_TextBox()
        {
            InitializeComponent();

            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.IsBalloon = true;
            tooltip.ShowAlways = true;
        }
    }
}
