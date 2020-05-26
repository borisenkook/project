using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyNewForm
{
    //enum StatusGame
    //{
    //    Win, Lose, Play
    //}
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        Stack<int> history = new Stack<int>();
        public int Count
        {
            get { return history.Count; }
        }
        
        private void Controler()
        {
            lblStep.Text = (Count.ToString());
            int temp1 = int.Parse(this.lblGoal.Text);
            int temp2 = int.Parse(this.lblNumber.Text);
            if (temp1 == temp2)
            {
                this.rezlabel.Visible = true;
                this.rezlabel.Text = "Вы выиграли!";

            }
            if (temp1 < temp2) MessageBox.Show("Вы проиграли!");
        }
        

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            history.Push(Count);
            Controler();
            
        }

        private void btnMulty_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            history.Push(Count);
            Controler();
           
        }

        //private int btnBack_Click(object sender, EventArgs e)
        //{
        //    if (history.Count != 0) return history.Pop(); else return 1;
        //}

        private void btnReset_Click(object sender, EventArgs e)
        {
            Update(); 
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            int gameGoal = new Random().Next(10, 100);
            lblGoal.Text = gameGoal.ToString();
            lblNumber.Text = "1";
            lblStep.Text = "0";
            this.rezlabel.Visible = false;
            history.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Что-то пошло не так!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Давай поиграем!");
            int gameGoal = new Random().Next(10, 100);
            lblGoal.Text = gameGoal.ToString();
            lblNumber.Text = 1.ToString();
            lblStep.Text = 0.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра Удвоитель\n Разработчик Борисенко О.К.");
        }

        private int btnBack_Click(object sender, EventArgs e)
        {
        if (history.Count != 0) return history.Pop(); else return 1;
        }
    }   

    //private void button2_Click(object sender, EventArgs e)
    //{
    //    lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
    //}
}

