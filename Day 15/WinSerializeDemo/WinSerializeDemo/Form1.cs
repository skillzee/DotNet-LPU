using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//For Binary Serialization
using System.Runtime.Serialization.Formatters.Binary;


//For XML
using System.Xml.Serialization;

//For SOAP
using System.Runtime.Serialization.Formatters.Soap;

namespace WinSerializeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearAllTextBoxes()
        {

            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //Binary Serialization Code Below
            FileStream fs = new FileStream(@"D:\CapGemini Training LPU\BinSerialise.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);


            MessageBox.Show("Record Added..");


        }

        private void btnBinDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\CapGemini Training LPU\BinSerialise.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();
            Employee emp1 =(Employee) bf.Deserialize(fs);
            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name.ToString();
            txtSalary.Text = emp1.Salary.ToString();



        }

        private void txtXMLSerialize_Click(object sender, EventArgs e)
        {

            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //XML Serialization Code Below
            FileStream fs = new FileStream(@"D:\CapGemini Training LPU\XMLSerialise.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            XmlSerializer xs = new XmlSerializer(typeof(Employee)); //XML is Type Based
            xs.Serialize(fs, emp1);
            ClearAllTextBoxes();
            fs.Close();

        }

        private void btnXMLDeserialize_Click(object sender, EventArgs e)
        {


            FileStream fs = new FileStream(@"D:\CapGemini Training LPU\XMLSerialise.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee emp1 = (Employee)xs.Deserialize(fs);
            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name.ToString();
            txtSalary.Text = emp1.Salary.ToString();

        }


        //Soap
        private void button5_Click(object sender, EventArgs e)
        {

            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //Binary Serialization Code Below
            FileStream fs = new FileStream(@"D:\CapGemini Training LPU\SOAPSerialise.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, emp1);


            MessageBox.Show("Record Added..");

        }

        private void button6_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"D:\CapGemini Training LPU\SOAPSerialise.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            SoapFormatter bf = new SoapFormatter();
            Employee emp1 = (Employee)bf.Deserialize(fs);
            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name.ToString();
            txtSalary.Text = emp1.Salary.ToString();


        }
    }
}
