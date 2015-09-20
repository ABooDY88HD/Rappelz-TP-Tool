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

namespace TP_Tool_11._2
{
    public partial class SkillsEditor : Form, BaseArcadiaManager
    {
        //variables must be in each and every arcadia manager, copy-paste
        public ArcadiaManager arcadia_manager { get; set; }
        public DataGridView base_datagrid { get; set; }
        public Button base_button_data_viewer { get; set; }
        public String base_select_query { get; set; }
        public String base_value_filter { get; set; }
        public Int32 base_format_type { get; set; }
        public XML base_xml_file { get; set; }

        public SkillsEditor()
        {
            InitializeComponent();

            //path of the xml file that contains the settings of the form
            base_xml_file = new XML("ArcadiaManager/SkillsEditor/main.xml");

            //the button that will show the data where the user selects a row to build on
            base_button_data_viewer = bt_dataviewer;

            //running the aracdia manager to setup the form
            arcadia_manager = new ArcadiaManager(this);

            //set common textboxes
            //arcadia_manager.set_common_fields(new TextBox { }, new Int32 { });
        }
    }
}
