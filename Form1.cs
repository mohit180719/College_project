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
          
        private void button2_Click(object sender, EventArgs e)
        {
            string vendor = "";
            string flag = "";
            string currency="";
            string Payment="";
            

            try
            {

                XmlWriter xmlwriter = XmlWriter.Create("Vendor.xml");
                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement("EDI");
                xmlwriter.WriteStartElement("VendorInfo");
                xmlwriter.WriteStartAttribute("Type", "Retail");
                //Vendor name
               xmlwriter.WriteStartElement("VendorName");

                if (VendorName.SelectedIndex.ToString()== "0")
                {
                    vendor = "Vendor 1";
                }
                else if (VendorName.SelectedIndex.ToString()== "1")
                {
                    vendor = "Vendor 2";
                }
                else if (VendorName.SelectedIndex.ToString()== "2")
                {
                    vendor = "Vendor 3";
                }

                xmlwriter.WriteString(vendor);
                xmlwriter.WriteEndElement();
                // vendor Phone
                xmlwriter.WriteStartElement("PhoneNo");
                xmlwriter.WriteString(Vendor_txtbox_Phone.Text);
                xmlwriter.WriteEndElement();

                // vendor Id
                xmlwriter.WriteStartElement("ID");
                xmlwriter.WriteString(Vendor_txtbox_ID.Text);
                xmlwriter.WriteEndElement();

                //vendor Fax
                xmlwriter.WriteStartElement("FAX");
                xmlwriter.WriteString(Vendor_txtbox_Fax.Text);
                xmlwriter.WriteEndElement();

                //Vendor Address
                xmlwriter.WriteStartElement("Address");
                xmlwriter.WriteString(Vendor_txtbox_Address.Text);
                xmlwriter.WriteEndElement();



                xmlwriter.WriteEndElement();
                

                // Ship To Address----Group Box

                xmlwriter.WriteStartElement("ShipToAddress");
                //company name
                xmlwriter.WriteStartElement("CompanyName");
                xmlwriter.WriteString(ShipTocName.Text);
                xmlwriter.WriteEndElement();

                //PhoneNo
                xmlwriter.WriteStartElement("PhoneNo");
                xmlwriter.WriteString(ShipTo_txtbox_Phone.Text);
                xmlwriter.WriteEndElement();

                //Address
                xmlwriter.WriteStartElement("Address");
                xmlwriter.WriteString(ShipTo_txtbox_Address.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteEndElement();

                //ShipFrom address----group box

                xmlwriter.WriteStartElement("ShipFromAddress");
                //company name
                xmlwriter.WriteStartElement("CompanyName");         
                xmlwriter.WriteString(ShipFrom_txtbox_CName.Text);
                xmlwriter.WriteEndElement();

                //PhoneNo
                xmlwriter.WriteStartElement("PhoneNo");
                xmlwriter.WriteString(ShipFrom_txtbox_Phone.Text);
                xmlwriter.WriteEndElement();

                //Address
                xmlwriter.WriteStartElement("Address");
                xmlwriter.WriteString(ShipFrom_txtbox_Address.Text);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteEndElement();

                //Term
                xmlwriter.WriteStartElement("Term");
                //flag
                xmlwriter.WriteStartElement("Flag");
                if (Term_radio_Test.Checked)
                {
                    flag = "Test";
                }
                else
                    flag = "Production";

                xmlwriter.WriteString(flag);
                xmlwriter.WriteEndElement();

                //currency

                xmlwriter.WriteStartElement("Currency");
                if(Term_Combox_Currency.SelectedIndex.ToString()=="0")
                {
                    currency = "IndianRupee";
                }
                else if(Term_Combox_Currency.SelectedIndex.ToString()=="1")
                {
                    currency = "Dollar";
                }
                else if(Term_Combox_Currency.SelectedIndex.ToString()=="2")
                {
                    currency = "Euro";
                }

                xmlwriter.WriteString(currency);
                xmlwriter.WriteEndElement();

                //Ship Date

                xmlwriter.WriteStartElement("ShipDate");
                xmlwriter.WriteString(Term_ShipDate.Text);
                xmlwriter.WriteEndElement();

                //Mode of payment
                
                xmlwriter.WriteStartElement("ModeOfPayment");
                if(Term_Combox_Payment.SelectedIndex.ToString()=="0")
                {
                    Payment ="Card";
                }
                else if(Term_Combox_Payment.SelectedIndex.ToString()=="1")
                {
                    Payment ="Cheque";
                }
                else if(Term_Combox_Payment.SelectedIndex.ToString()=="2")
                {
                    Payment ="Electronic Payment";
                }


                xmlwriter.WriteString(Payment);
                xmlwriter.WriteEndElement();

               // item details

                xmlwriter.WriteStartElement("ItemDetails");
                // for first item detail in the 1st row
                xmlwriter.WriteStartElement("Item1");
                
                xmlwriter.WriteStartElement("PO");
                xmlwriter.WriteString(Items_DataGrid.Rows[0].Cells["PO Number"].Value.ToString());
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("Quantity");
                xmlwriter.WriteString(Items_DataGrid.Rows[0].Cells["Quantity"].Value.ToString());
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("Description");
                xmlwriter.WriteString(Items_DataGrid.Rows[0].Cells["Description"].Value.ToString());
                xmlwriter.WriteEndElement();

                xmlwriter.WriteEndElement(); // end Item1
                xmlwriter.WriteEndElement(); // end ItemDetails


                xmlwriter.WriteEndDocument();
                xmlwriter.Close();
                MessageBox.Show("XML is generated");
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
           // table.Columns.Add("S.No", typeof(int));
            table.Columns.Add("PO Number", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Description", typeof(string));

            if(PO.Text !="")
            {
                if(quantity.Text !="")
                {
                    if(description.Text !="")
                    {
                        table.Rows.Add(PO.Text, quantity.Text, description.Text);
                        Items_DataGrid.DataSource = table;
                        MessageBox.Show("item is successfully added");
                        //itemCount++;
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter the description");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Quantity");
                }
            }
            else
            {
                MessageBox.Show("Please enter the PO#");
            }
    

        }


        // testing code area

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Items_DataGrid.Rows[0].Cells["Description"].Value.ToString());
           
        }
        // defaults
        private void button4_Click(object sender, EventArgs e)
        {
            Vendor_txtbox_Address.Text = "House No-1234, city, district 121004";
            Vendor_txtbox_Fax.Text = "123456";
            Vendor_txtbox_ID.Text = "vendor-1A";
            Vendor_txtbox_Phone.Text = "8744082072";
            ShipFrom_txtbox_Address.Text = "House No-1234, city, district 121004";
            ShipFrom_txtbox_CName.Text = "Customer Name";
            ShipFrom_txtbox_Phone.Text = "8744082072";
            ShipTo_txtbox_Address.Text = "address";
            ShipTo_txtbox_Phone.Text = "121212";
            ShipTocName.Text = "Customer";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
