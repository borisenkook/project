using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        WF_Udvoitel.Udvoitel udvoitel;
        public Form1()
        {
            InitializeComponent();
            //btnCommand1.Text = "+1";
            //btnCommand2.Text = "*2";
            //btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1) .ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel(10, 20);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
    }

    //internal class Udvoitel
    //{
    //    private int v1;
    //    private int v2;

    //    public Udvoitel(int v1, int v2)
    //    {
    //        this.v1 = v1;
    //        this.v2 = v2;
    //    }
    //}
}
