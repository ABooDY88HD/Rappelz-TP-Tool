using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace TP_Tool_11._2.Classes.Common
{
    public class XML
    {
        public String path { get; set; }
        public XElement xml;

        public XML(String path)
        {
            this.path = path;
            xml = XElement.Load(path);
        }

        public String readAttribute(String id, String language)
        {
            IEnumerable<XElement> translation_element =
                from el in xml.Elements("translation")
                where (string)el.Attribute("id") == id
                select el;

            foreach (XElement el in translation_element)
            {
                IEnumerable<XElement> language_element =
                from el2 in el.Elements(language)
                select el2;

                //get first element
                foreach (XElement element in language_element)
                    return ((string)element.Value);
            }

            //not found
            return "";
        }
    }
}
