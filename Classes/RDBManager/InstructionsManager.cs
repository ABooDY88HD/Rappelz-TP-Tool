using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TP_Tool_11._2.Classes.RDBManager
{
    class InstructionsManager
    {
        public String[] Instructions;
        public VariablesManager Variables { get; set; }

        public String[] Header { get; set; }
        public String Copyright { get; set; }
        public String FileName { get; set; }

        private String[] ReadData { get; set; }
        private String[] WriteData { get; set; }
        private String[] InitData { get; set; }
        
        public Instruction[] ReadInstructions { get; set; }
        public Instruction[] WriteInstructions { get; set; }
        public Instruction[] InitialInstructions { get; set; }
        public InstructionsManager(String[] Instructions)
        {
            this.Instructions = Instructions;
            Variables = new VariablesManager(this);

            Header = fetch_section("header").Split(',');
            Copyright = fetch_section("copyright");
            FileName = fetch_section("filename");

            ReadData = fetch_sections("-");
            WriteData = fetch_sections("$");
            InitData = fetch_sections("!");
            
            update_instructions();
        }

        private String fetch_section(String section)
        {
            foreach (String line in Instructions)
                if (line.StartsWith("#" + section + ":"))
                    return line.Substring(2 + section.Length);

            return "";
        }


        private String[] fetch_sections(String section)
        {
            List<String> programmable_data = new List<String>();

            foreach (String line in Instructions)
                if (line.StartsWith(section))
                    programmable_data.Add(line.Substring(1));

            return programmable_data.ToArray();
        }

        private void update_instructions()
        {
            ReadInstructions = new Instruction[ReadData.Length];
            WriteInstructions = new Instruction[WriteData.Length];
            InitialInstructions = new Instruction[InitData.Length];

            for (int i = 0; i < ReadData.Length; i++)
                ReadInstructions[i] = new Instruction(ReadData.ElementAt(i), Variables);

            for (int i = 0; i < WriteData.Length; i++)
                WriteInstructions[i] = new Instruction(WriteData.ElementAt(i), Variables);

            for (int i = 0; i < InitData.Length; i++)
                InitialInstructions[i] = new Instruction(InitData.ElementAt(i), Variables);
        }
    }
}
