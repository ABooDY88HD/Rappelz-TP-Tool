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
        String path = @"L:\TwilightPrince\Servers\Rappelz\Clinet\Resource 8.1\rdb\";
        public RDBManager()
        {
            InitializeComponent();
            Stopwatch timerST = Stopwatch.StartNew();
            TPTEngine engine = new TPTEngine("SkillTreeResource 8.1 By TwilightPrince", dg_rdb);
            engine.read(path + "db_skilltree.rdb");

            timerST.Stop();
            Debug.WriteLine(timerST.Elapsed.ToString("mm':'ss':'fff"));

            dg_rdb.DataSource = engine.datatable;
        }
    }
}
