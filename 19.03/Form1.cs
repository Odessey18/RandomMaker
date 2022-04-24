using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._03
{
    public partial class Form1 : Form
    {

        List<string> names = new List<string>();
        List<string> randomlist = new List<string>();
        Random rnd = new Random();
        string a = "";

        public Form1()
        {
            InitializeComponent();




        }



        private void button1_Click(object sender, EventArgs e)
        {
            names.Clear();
            listBox4.Items.Clear();
            for (int x = 0; x < listBox1.Items.Count; x++)
            {
                for (int y = 0; y < listBox2.Items.Count; y++)
                {
                    for (int z = 0; z < listBox3.Items.Count; z++)
                    {
                        names.Add(listBox2.Items[y].ToString() + " " + listBox1.Items[x].ToString() + " " + listBox3.Items[z].ToString());
                        randomlist.Add(listBox2.Items[y].ToString() + " " + listBox1.Items[x].ToString() + " " + listBox3.Items[z].ToString());

                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                listBox4.Items.Add(names[i]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox3.Text);
            textBox3.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            int index = rnd.Next(0, randomlist.Count);
            a = randomlist[index];
            listBox4.Items.Add(a);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Multiselect = true;
            OpenFileDialog1.Filter = "TXT Files|*.txt";
            OpenFileDialog1.Title = "Select a TXT File";
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.AddRange(OpenFileDialog1.FileNames);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Multiselect = true;
            OpenFileDialog1.Filter = "TXT Files|*.txt";
            OpenFileDialog1.Title = "Select a TXT File";
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox2.Items.AddRange(OpenFileDialog1.FileNames);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Multiselect = true;
            OpenFileDialog1.Filter = "TXT Files|*.txt";
            OpenFileDialog1.Title = "Select a TXT File";
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox3.Items.AddRange(OpenFileDialog1.FileNames);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);

                    foreach (object item in listBox4.Items)

                        sw.WriteLine(item.ToString());

                    sw.Close();
                };
            }
        }
    }
  
}
