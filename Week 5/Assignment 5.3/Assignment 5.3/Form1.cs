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
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace Assignment_5._3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbFormats.DataSource = Enum.GetValues(typeof(SerializeFormat));
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id=Int32.Parse(txtID.Text);
            student.Name=txtName.Text;
            student.Address=txtAddress.Text;
            switch (CmbFormats.SelectedIndex)
            {
                case 0:
                    btnDsrBinary.Visible = true;
                    string filepath0 = @"C:\Files\binary5.3.txt";
                    FileStream fsbinary = new FileStream(filepath0, FileMode.OpenOrCreate,
                        FileAccess.ReadWrite);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fsbinary, student);
                    MessageBox.Show("Data is serialized in Binary");
                    fsbinary.Close();
                    break;
                case 1:
                    btnDsrXML.Visible = true;
                    string filepath1 = @"C:\Files\XML5.3.xml";
                    FileStream fsxml = new FileStream(filepath1, FileMode.OpenOrCreate,
                        FileAccess.ReadWrite);
                    SoapFormatter xmlF = new SoapFormatter();
                    xmlF.Serialize(fsxml, student);
                    MessageBox.Show("Data is serialized in XML");
                    fsxml.Close();
                    break;
                case 2:
                    btnDsrJson.Visible = true;
                    string filepath2 = @"C:\Files\JSON5.3.txt";
                    FileStream fsjson = new FileStream(filepath2, FileMode.OpenOrCreate,
                        FileAccess.ReadWrite);
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(student.GetType());
                    jsonSerializer.WriteObject(fsjson, student);
                    fsjson.Close();
                    MessageBox.Show("Data is serialized in JSON");
                    break;



            }



        }

        private void btnDsrBinary_Click(object sender, EventArgs e)
        {        
            FileStream stream = new FileStream(@"C:\Files\binary5.3.txt",
                FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Student student = (Student)bf.Deserialize(stream);
            MessageBox.Show($"Deserialized data: {student.Id}, {student.Name}, " +
                $"{student.Address}");
            stream.Close();
            btnDsrBinary.Visible = false;
        }

        private void btnDsrXML_Click(object sender, EventArgs e)
        {
            FileStream streamXML = new FileStream(@"C:\Files\XML5.3.xml",
                FileMode.Open, FileAccess.Read);
            SoapFormatter soapFormatter = new SoapFormatter();
            Student student = (Student)soapFormatter.Deserialize(streamXML);
            MessageBox.Show($"Deserialized data: {student.Id}, {student.Name}, " +
                $"{student.Address}");
            streamXML.Close();
            btnDsrXML.Visible = false;
        }

        private void btnDsrJson_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            FileStream fsjson = new FileStream(@"C:\Files\JSON5.3.txt", FileMode.OpenOrCreate,
                        FileAccess.ReadWrite);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(student.GetType());
            student=jsonSerializer.ReadObject(fsjson) as Student;
            MessageBox.Show($"Deserialized data: {student.Id}, {student.Name}, " +
                $"{student.Address}");
            fsjson.Close();
            btnDsrJson.Visible = false; 
        }
    }
}
