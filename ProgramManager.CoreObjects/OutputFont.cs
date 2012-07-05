using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace ProgramManager.CoreObjects
{
    public class OutputFont
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }

        public string FontString
        {
            get
            {
                List<string> result = new List<string>();
                result.Add(this.Name);
                result.Add(this.Size.ToString());
                if (this.Bold)
                    result.Add("Bold");
                if (this.Italic)
                    result.Add("Italic");
                return string.Join(",", result.ToArray());
            }
        }

        public Font FontObject
        {
            get
            {
                FontStyle style = FontStyle.Regular;
                if (this.Bold)
                {
                    style = FontStyle.Bold;
                    if (this.Italic)
                        style |= FontStyle.Italic;
                }
                else if (this.Italic)
                    style = FontStyle.Italic;
                FontFamily family = new FontFamily(this.Name);
                return new Font(family, this.Size, style);
            }
        }

        public OutputFont()
        {
        }

        public OutputFont(string name, int size, bool bold = false, bool italic = false)
        {
            this.Name = name;
            this.Size = size;
            this.Bold = bold;
            this.Italic = italic;
        }

        public string Serialize()
        {
            StringBuilder result = new StringBuilder();

            if (!string.IsNullOrEmpty(this.Name))
                result.AppendLine(@"<Name>" + this.Name.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Name>");
            result.AppendLine(@"<Size>" + this.Size.ToString() + @"</Size>");
            result.AppendLine(@"<Bold>" + this.Bold.ToString() + @"</Bold>");
            result.AppendLine(@"<Italic>" + this.Italic.ToString() + @"</Italic>");
            return result.ToString();
        }

        public void Deserialize(XmlNode node)
        {
            int tempInt;
            bool tempBool;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                switch (childNode.Name)
                {
                    case "Name":
                        this.Name = childNode.InnerText;
                        break;
                    case "Size":
                        if (int.TryParse(childNode.InnerText, out tempInt))
                            this.Size = tempInt;
                        break;
                    case "Bold":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.Bold = tempBool;
                        break;
                    case "Italic":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.Italic = tempBool;
                        break;
                }
            }
        }
    }
}
