using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppExperiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl.GetType().Name == "CheckBox")
                {
                    CheckBox cBox = (CheckBox) ctrl;
                    if (cBox.Checked)
                    {
                        listBox1.Items.Add(cBox.Text);
                    }
                }
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton) ctrl;
                    if (radioButton.Checked)
                    {
                        String Text = radioButton.Text;
                        if (Text == "红色")
                        {
                            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), listBox1.Font, Brushes.Red,
                                e.Bounds);
                        }
                        else if (Text == "蓝色")
                        {
                            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), listBox1.Font, Brushes.Blue,
                                e.Bounds);
                        }
                        else if (Text == "紫色")
                        {
                            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), listBox1.Font, Brushes.Purple,
                                e.Bounds);
                        }
                        else if (Text == "黑色")
                        {
                            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), listBox1.Font, Brushes.Black,
                                e.Bounds);
                        } else if (Text == "自定义")
                        {

                            colorDialog1.ShowDialog();
                            Brush brush = new SolidBrush(colorDialog1.Color);
                            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), listBox1.Font, brush,
                                e.Bounds);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Font = new Font(listBox1.Font.Name, listBox1.Font.Size, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Font = new Font(listBox1.Font.Name, listBox1.Font.Size, FontStyle.Italic);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Font = new Font(listBox1.Font.Name, listBox1.Font.Size, FontStyle.Underline);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Font = new Font(listBox1.Font.Name, listBox1.Font.Size, FontStyle.Strikeout);
        }
    }
}