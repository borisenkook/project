using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUdvoitel;

namespace Test1
{
    public partial class FrmMain : Form
    {
        Udvoitel.Udvoitel udvoitel;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение Удвоитель\nРазработчик Борисенко О.К.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (udvoitel == null) return;
            udvoitel.Plus();
            UpdateInfo();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Udvoitel udvoitel = new Udvoitel(10, 20);
            класс о,ект = создание о,екта скласа
            UpdateInfo();
        }
        void UpdateInfo()
        {
            lblCarrent.Text = 1.ToString();
            lblFinish.Text = udvoitel.Finish.ToString();
            lblStep.Text = 1.ToString();

        }

        private void btnMulty_Click(object sender, EventArgs e)
        {
            udvoitel.Multy();
            UpdateInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            udvoitel.Back();
            UpdateInfo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            udvoitel.Reset();
            UpdateInfo();
        }
    }
}
