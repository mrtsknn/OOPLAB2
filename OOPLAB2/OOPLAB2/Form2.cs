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

namespace OOPLAB2
{
    public partial class Form2 : Form
    {
        int i, j;
        bool triangle, square, round;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
     
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxMed_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxSqr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            square = checkBox2.Checked ? true : false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            round = checkBox3.Checked ? true : false;
        }

        private void txti_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtj_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete("settings.txt");
            FileStream fs = new FileStream("settings.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);

            void writeShapes() //şekillerden hangilerinin seçili durumda olduğunu settings.txt'ye kaydeder
            {
                sw.WriteLine(triangle.ToString());
                sw.WriteLine(square.ToString());
                sw.WriteLine(round.ToString());
            }

            if (rdCstm.Checked) //custom seçili ise değerlerin boş olup olmadığını kontrol et, değilse settings.txt'ye kaydeder
            {
                if (txti.Text == "" || txtj.Text == "")
                {
                    MessageBox.Show("Custom values cant be blank", "Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sw.WriteLine( txti.Text + "," + txtj.Text);
                    writeShapes();

                }
            }
            else if (rdEasy.Checked)
            {
                sw.WriteLine("easy");
                writeShapes();
            }

            else if (rdMed.Checked)
            {
                sw.WriteLine("medium");
                writeShapes();
            }
            else if (rdHard.Checked)
            {
                sw.WriteLine("hard");
                writeShapes();
            }
            sw.Close();
        }

        private void Form2_Load(object sender, EventArgs e) //settings.txt içerisine ayar kaydedilmiş ise o ayarları uygular
        {
            if (File.Exists("settings.txt"))
            {
                StreamReader sr = new StreamReader("settings.txt");
                string[] lines = sr.ReadToEnd().Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                if (lines[0] == "easy")
                {
                    rdEasy.Checked = true;
                }
                else if (lines[0] == "medium")
                {
                    rdMed.Checked = true;
                }
                else if (lines[0] == "hard")
                {
                    rdHard.Checked = true;
                }
                else
                {
                    rdCstm.Checked = true;
                    string[] values = lines[0].Split(',');
                    txti.Text = values[0];
                    txtj.Text = values[1];
                }

                if (lines[1] == "True")
                {
                    checkBox1.Checked = true;
                }
                if (lines[2] == "True")
                {
                    checkBox2.Checked = true;
                }
                if (lines[3] == "True")
                {
                    checkBox3.Checked = true;
                }
                sr.Close();

            }
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            triangle = checkBox1.Checked ? true : false;
        }

        public void FillMatrix(string[,] v)
        {
            //Burası matrix oluşturursak tamamlanacak
            txti.Text = i.ToString();
            txtj.Text = j.ToString();

        }

    }
}
