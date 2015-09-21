using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TP_Tool_11._2.Classes.RDBManager
{
    class VariablesManager
    {
        private String[] VariableValue = new String[128];
        private String[] VariableName = new String[128];
        private InstructionsManager Manager {get;set;}
        private int idx = 0;

        private DataTable Table = new DataTable();

        public VariablesManager(InstructionsManager Manager)
        {
            this.Manager = Manager;
        }

        public void clean()
        {
            VariableValue = new String[128];
            VariableName = new String[128];
        }

        public void set_var(String name, String value)
        {
            int ind = Array.IndexOf(VariableName, name);

            if (ind >= 0)
                VariableValue[ind] = value;
            else
            {
                VariableName[idx] = name;
                VariableValue[idx++] = value;
            }
        }

        public String get_var(String name, DataRow row)
        {
            int ind_header = Array.IndexOf(Manager.Header, name);
            int ind_var = Array.IndexOf(VariableName, name);

            if (ind_header >= 0)
                return row[ind_header].ToString();

            if (ind_var >= 0)
                return VariableValue[ind_var];

            return "";
        }

        public Boolean var_exists(String name, DataRow row)
        {
            int ind_header = Array.IndexOf(Manager.Header, name);
            int ind_var = Array.IndexOf(VariableName, name);

            if (ind_var >= 0 || ind_header >= 0)
                return true;
            return false;
        }

        public String evaluate(string expression, DataRow row)
        {
            if (String.IsNullOrWhiteSpace(expression))
                return expression;

            if (row != null && Manager.Header.Contains(expression))
                return row[expression].ToString();

            if (VariableName.Contains(expression))
                return VariableValue[Array.IndexOf(VariableName, expression)];

            //convert variables into values
            for (int i = 0; i < idx; i++)
                expression = expression.Replace(VariableName[i], VariableValue[i]);

            //convert columns into values
            foreach (String header in Manager.Header)
                expression = expression.Replace(header, row[header].ToString());

            Table.Columns.Clear();
            Table.Columns.Add("expression", typeof(string), expression);
            DataRow rowadd = Table.NewRow();
            Table.Rows.Add(rowadd);

            return ((string)rowadd["expression"]).ToString();
        }
    }
}
