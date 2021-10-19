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

namespace Write_And_Read_Textfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Output text file with richText in windows forms
        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Application.StartupPath + "\\FILES\\" ///file path
              + txtLastName.Text + " " + txtFirstName.Text + ".txt"); //This will create & rename each textfile

            rtxtResults.Text = reader.ReadToEnd();
            reader.Close();
        }
        //Write text file to your local files
        private void btnWrite_Click(object sender, EventArgs e)
        {
            string gender;
            if (radFemale.Checked)
                gender = "Female";
            else if (radMale.Checked)
                gender = "Male";
            else
                gender = "N/A";
            
            StreamWriter writer = new StreamWriter(Application.StartupPath + "\\FILES\\" ///file path
              + txtLastName.Text + " " + txtFirstName.Text + ".txt"); //This will create & rename each textfile

            writer.WriteLine($"{label1.Text}: {txtFirstName.Text}");
            writer.WriteLine($"{label2.Text}: {txtLastName.Text}");
            writer.WriteLine($"{label3.Text}: {gender}");
            writer.WriteLine($"\n{label4.Text}: \n{txtAddress.Text}");
            writer.Close();
        }
    }
}
