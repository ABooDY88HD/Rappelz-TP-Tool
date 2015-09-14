using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_Tool_11._2.Forms.Common
{
    public partial class Flags : Form
    {
        private String[] flags { get; set; }
        private int combo_box_height = 40;
        private CheckBox[] checkboxes { get; set; }
        private Boolean[] properties { get; set; }
        private TextBox textbox;
        public Int32 flag_value;


        public Flags(String[] flags, int flag_value, TextBox textbox)
        {
            InitializeComponent();

            this.flags = flags;
            this.Size = new Size(this.Width, Convert.ToInt32(Math.Floor(flags.Length / 2.0 * combo_box_height)));
            this.flag_value = flag_value;
            this.textbox = textbox;

            import_properties();

            for (int i = 0; i < flags.Length; i++)
            {
                checkboxes[i] = new CheckBox();
                checkboxes[i].Text = (i+1) + "- " + flags[i];
                checkboxes[i].Checked = properties[i];
                tableLayout.Controls.Add(checkboxes[i]);
            }
        }

        public void import_properties()
        {
            //export CheckBoxes values by using flag value
            Char[] _flags = Convert.ToString(flag_value, 2).ToCharArray();

            for (int i = 0; i < _flags.Length; i++)
                checkboxes[i].Checked = properties[i] = _flags[i] == '1' ? true : false;
        }

        public void export_properties()
        {
            //export flag value by using CheckBoxes values
            Char[] _flags = new Char[properties.Length];
            for (int i = 0; i < _flags.Length; i++)
                _flags[i] = properties[i] == true ? '1' : '0';

            flag_value = Convert.ToInt32(new String(_flags), 2);
        }
    }
}
