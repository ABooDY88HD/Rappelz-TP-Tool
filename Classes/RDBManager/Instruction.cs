using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TP_Tool_11._2.Classes.Common;

namespace TP_Tool_11._2.Classes.RDBManager
{
    class Instruction
    {
        public static String[] Types = { "binary", "bit", "uint8", "int8", "uint16", "int16", "uint32", "int32", "monid", "int64", "uint64", "float", "single", "double", "datetime", "string", "bytes", "lenstring" };
        public static int[] Lengths = {     1,       1,      1,       1,       2,       2,        4,        4,      4,       8,        8,       4,        4,        8,        8,        -10,      -10,       -11 };
        public static Char[] Arethmitic = " +-/*&()".ToCharArray();


        private String Code { get; set; }

        public String ReadValue { get; set; }
        public Byte[] WriteValue { get; set; }

        public String Type { get; set; }
        public String TypeVariable { get; set; }

        public String Destination { get; set; }
        public String Destinationformula { get; set; }

        public int Length { get; set; }

        public VariablesManager Variables { get; set; }

        private Boolean Dynamic { get; set; }

        public Instruction(String Code, VariablesManager Variables)
        {
            this.Code = Code;
            this.Variables = Variables;
            Dynamic = false;

            Type = Code.Split(new string[] { "->" }, StringSplitOptions.None)[0];

            Destinationformula = Code.Split(new string[] { "fill." }, StringSplitOptions.None)[1];
            Destination = Destinationformula;

            foreach (Char c in Arethmitic)
                Destination = Destination.Split(c)[0];

            Length = Array.IndexOf(Types, Type);
            Length = Length < 0 ? Length : Lengths[Length];

            if (Type.Contains("@"))
            {
                TypeVariable = Type.Split('@')[1];
                Type = Type.Split('@')[0];

                if (new Regex(@"^\d+$").IsMatch(TypeVariable))
                    Length = Convert.ToInt32(TypeVariable);
                else
                    Dynamic = true;
            }
        }

        public void pre_read(DataRow row)
        {
            if (Dynamic)
            {
                TypeVariable = Variables.evaluate(Code.Split(new string[] { "->" }, StringSplitOptions.None)[0].Split('@')[1], row);
                Length = Convert.ToInt32(TypeVariable);
            }
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void set_read_value(Byte[] bytes, DataRow row)
        {
            switch (Type)
            {
                case "binary":
                    ReadValue = Reverse(Convert.ToString(bytes[0], 2));
                    break;
                case "bit":
                    ReadValue = bytes[0] == 0 ? "0" : "1";
                    break;

                case "uint8":
                    ReadValue = "" + Convert.ToSByte(bytes[0]);
                    break;

                case "int8":
                    ReadValue = "" + bytes[0];
                    break;

                case "uint16":
                    ReadValue = "" + BitConverter.ToUInt16(bytes, 0);
                    break;

                case "int16":
                    ReadValue = "" + BitConverter.ToInt16(bytes, 0);
                    break;

                case "uint32":
                    ReadValue = "" + BitConverter.ToUInt32(bytes, 0);
                    break;

                case "int32":
                    ReadValue = "" + BitConverter.ToInt32(bytes, 0);
                    break;

                case "monid":
                    ReadValue = "" + scramble.bits_descramble(BitConverter.ToInt32(bytes, 0));
                    break;

                case "int64":
                    ReadValue = "" + BitConverter.ToInt64(bytes, 0);
                    break;

                case "uint64":
                    ReadValue = "" + BitConverter.ToUInt64(bytes, 0);
                    break;

                case "float":
                case "single":
                    ReadValue = BitConverter.ToSingle(bytes, 0).ToString("G99");
                    break;

                case "double":
                    ReadValue = "" + BitConverter.ToDouble(bytes, 0);
                    break;

                case "datetime":
                    ReadValue = "" + new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(BitConverter.ToInt32(bytes, 0));
                    break;
                case "string":
                case "bytes":
                    ReadValue = strings.BytesToString(bytes, "Arabic");
                    break;

                case "lenstring":
                    ReadValue = "";
                    break;
            }
        }

        public void set_write_value(String data, DataRow row)
        {
            switch (Type)
            {
                case "binary":
                    WriteValue = new byte[Convert.ToByte(Convert.ToInt32(Reverse(data), 2))];
                    break;
                case "bit":
                    WriteValue = new byte[data[0] == 0 ? 0 : 255];
                    break;

                case "uint8":
                    WriteValue = new byte[Convert.ToSByte(data)];
                    break;

                case "int8":
                    WriteValue = new byte[Convert.ToByte(data)];
                    break;

                case "uint16":
                    WriteValue = BitConverter.GetBytes(Convert.ToUInt16(data));
                    break;

                case "int16":
                    WriteValue = BitConverter.GetBytes(Convert.ToInt16(data));
                    break;

                case "uint32":
                    WriteValue = BitConverter.GetBytes(Convert.ToUInt32(data));
                    break;

                case "int32":
                    WriteValue = BitConverter.GetBytes(Convert.ToInt32(data));
                    break;

                case "monid":
                    WriteValue = BitConverter.GetBytes(scramble.bits_scramble(Convert.ToInt32(data)));
                    break;

                case "int64":
                    WriteValue = BitConverter.GetBytes(Convert.ToInt64(data));
                    break;

                case "uint64":
                    WriteValue = BitConverter.GetBytes(Convert.ToUInt64(data));
                    break;

                case "float":
                case "single":
                    WriteValue = BitConverter.GetBytes(Convert.ToSingle(data));
                    break;

                case "double":
                    WriteValue = BitConverter.GetBytes(Convert.ToDouble(data));
                    break;

                case "datetime":
                    WriteValue = BitConverter.GetBytes((Convert.ToDateTime(data)).ToBinary());
                    break;
                case "string":
                case "bytes":
                    WriteValue = strings.StringToBytes(data, "Arabic");
                    break;

                case "lenstring":
                    WriteValue = BitConverter.GetBytes(Convert.ToInt32(data));
                    break;
            }
        }
    }
}
