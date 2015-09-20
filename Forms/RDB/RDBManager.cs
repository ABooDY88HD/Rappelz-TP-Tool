using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Tool_11._2.Classes.RDBManager;

namespace TP_Tool_11._2.Forms.RDB
{
    public partial class RDBManager : Form
    {
        public RDBManager()
        {
            InitializeComponent();
            Stopwatch timerST = Stopwatch.StartNew();
            TPTEngine engine = new TPTEngine("NPCResource8.1 By TwilightPrince", dg_rdb);
            engine.read(@"L:\TwilightPrince\Servers\Rappelz\Clinet\Resource 8.1\rdb\db_npcresource.rdb");

            timerST.Stop();
            Debug.WriteLine(timerST.Elapsed.ToString("mm':'ss':'fff"));

            dg_rdb.DataSource = engine.datatable;
        }
    }
}
