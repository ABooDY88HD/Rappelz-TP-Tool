using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Tool_11._2.Classes.Common;

namespace TP_Tool_11._2.Classes.ArcadiaManager
{
    public interface BaseArcadiaManager
    {
        ArcadiaManager arcadia_manager { get; set; }
        DataGridView base_datagrid { get; set; }
        Button base_button_data_viewer { get; set; }
        String base_select_query { get; set; }
        String base_value_filter { get; set; }
        Int32 base_format_type { get; set; }
        XML base_xml_file { get; set; }
    }
}
