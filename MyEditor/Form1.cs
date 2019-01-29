using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //if they click OK it will do below
            {

                string path = openFileDialog1.FileName; //The string path is going to save the file path
                System.IO.StreamReader sr = new 
                System.IO.StreamReader(path);

                rtb.Text = sr.ReadToEnd(); //loads the file in reads it to the end
                sr.Close();//closes the StreamReader
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string path = openFileDialog1.FileName;

            rtb.SaveFile(path, RichTextBoxStreamType.PlainText);

            //System.IO.StreamWriter sw = new
            //   System.IO.StreamWriter(path);
            //sw.Write(rtb.text);

            // sw.Close();
        }
    }
}
