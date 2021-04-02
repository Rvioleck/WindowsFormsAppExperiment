using System;
using System.Windows.Forms;

namespace WindowsFormsAppExperiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string origin = "你选择的语言是：\n\n";
            string pop = "";
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType().Name == "CheckBox")
                {
                    CheckBox cBox = (CheckBox) ctrl;
                    if (cBox.Checked)
                    {
                        pop += "->" + cBox.Text + "\n\n";
                    }
                }
            }
            this.label2.Text = origin + pop;
        }
    }
}