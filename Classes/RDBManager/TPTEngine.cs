using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_Tool_11._2.Classes.RDBManager
{
    class TPTEngine
    {
        private String tpt { get; set; }
        private String Target { get; set; }
        private String[] Header { get; set; }
        private InstructionsManager InstructionManager { get; set; }

        private int max_rows { get; set; }
        private int current_row { get; set; }

        public DataGridView datagrid { get; set; }
        public DataTable datatable { get; set; }

        public TPTEngine(String tpt, DataGridView datagrid)
        {
            this.tpt = tpt;
            this.datagrid = datagrid;

            clean();

            //reading the programmable file
            InstructionManager = new InstructionsManager(File.ReadAllLines(@"./RDBManager/" + tpt + ".TPT"));
        }

        public void init()
        {
            foreach (Instruction instruction in InstructionManager.InitialInstructions)
                instruction.set_read_value(null, null);
        }

        public void read(String rdb_path)
        {
            clean();
            build_datatable();
            init();

            using (BinaryReader rdb = new BinaryReader(File.Open(rdb_path, FileMode.Open)))
            {
                //read unneeded bytes
                rdb.ReadBytes(128);
                max_rows = rdb.ReadInt32();

                while (current_row < max_rows)
                {
                    DataRow row = datatable.NewRow();

                    foreach (Instruction instruction in InstructionManager.ReadInstructions)
                    {
                        instruction.pre_read(row);
                        Byte[] bytes = new Byte[0];

                        if (instruction.Length > 0)
                            bytes = rdb.ReadBytes(instruction.Length);

                        instruction.set_read_value(bytes, row);

                        //special treatment for if statements
                        while(!String.IsNullOrWhiteSpace(instruction.IfConition))
                        {
                            instruction.CopyFrom(instruction.ReadValue.ToLower() == "true" ? instruction.IfInstruction : instruction.ElseInstruction);

                            if (instruction == null)
                                continue;

                            instruction.pre_read(row);
                            bytes = new Byte[0];

                            if (instruction.Length > 0)
                                bytes = rdb.ReadBytes(instruction.Length);

                            instruction.set_read_value(bytes, row);
                        }

                        if (instruction.Destination == "empty")
                            continue;
                        else if (InstructionManager.Header.Contains(instruction.Destination))
                            row[instruction.Destination] = instruction.ReadValue;
                        else if (instruction.Destination.Contains(","))
                            for (int i = 0; i < instruction.Destination.Split(',').Length; i++)
                                if(instruction.Destination.Split(',')[i] != "empty")
                                    row[instruction.Destination.Split(',')[i]] = instruction.ReadValue[instruction.Destination.Split(',').Length - 1 - i];
                        else
                            InstructionManager.Variables.set_var(instruction.Destination, instruction.ReadValue);
                    }

                    current_row++;
                    datatable.Rows.Add(row);
                    //readRDB.ReportProgress(Convert.ToInt32(new Decimal(reader_R)/reader_RO*100));
                }
            }

            datagrid.DataSource = datatable;
            datagrid.Refresh();
        }

        public void clean()
        {
            datagrid = new DataGridView();
            datatable = new DataTable();
            //InstructionManager.Variables.clean();

            max_rows = 0;
            current_row = 0;
        }

        public void build_datatable()
        {
            foreach (string head in InstructionManager.Header)
                datatable.Columns.Add(head);
        }
    }
}
