using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ISA_Button_Click(object sender, EventArgs e)
        {
            try
            {
                XmlWriter xmlwriter = XmlWriter.Create("Mohit.xml");
                xmlwriter.WriteStartDocument();

                // ISA Segment Part

                xmlwriter.WriteStartElement("EDI");
                xmlwriter.WriteStartElement("ISA");
                
                xmlwriter.WriteStartElement("Vendor");
                xmlwriter.WriteString(ISA_VendorName.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("ID");
                xmlwriter.WriteString(ISA_ID.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("VendorName");
                xmlwriter.WriteString(ISA_VendorName.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("Date");
                xmlwriter.WriteString(ISA_Date.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("Time");
                xmlwriter.WriteString(ISA_Time.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("Flag");
                xmlwriter.WriteString(ISA_Flag.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteEndDocument();
                xmlwriter.Close();
                MessageBox.Show("xmlwriter is Generated successfully");

            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                Console.Read();

            }
        }
    }
}
