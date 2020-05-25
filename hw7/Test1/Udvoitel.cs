using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUdvoitel
{
    internal enum StatusGame
    {
        Win, Lose, Play
    }
    class Udvoitel
    {
        private StatusGame status = StatusGame.Play;

        public StatusGame Status { get; private set; }

        private void SetStatus(StatusGame value)
        {
            status = value;
        }

        int current=1;// Текущее значение

            public int Finish { get; private set; } 
        
        Stack<int> history = new Stack<int>();

        public int Current
        {
        get {
                if (current == Finish) Status = StatusGame.Win;
                if (current > Finish) Status = StatusGame.Lose;
                return current;
                //lblFinish.Text = udvoitel.Finish.ToString();
                //lblStep.Text = udvoitel.Count.ToString();
                //if (udvoitel.Status==StatusGame.Lose)
                //{
                //    MessageBox.Show("You lose!");
                //}
                //if (udvoitel.Status == StatusGame.Win)
                //{
                //    MessageBox.Show("You Win!", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes; new ToolStripMenuItem.PerformClick();
                //}
                //else
                //{
                //    btnBack.Enabled = false;
                //    btnMulti.Enabled = false;
                //    btnPlus.Enabled = false;
                //    btnReset.Enabled = false;
        //        }
        //    }
        //}

       // int count = 0; //Количество шагов
    

       // Stack<int> history = new Stack<int>();
        private object udvoitel;

        //public int Current
        //{
        //    get { return current; }
        //}
        //public int Count
        //{
        //    get { return count; }
        //}
        public int Steps // Рассчет минимального количества шагов
        {
            get
            {
                int f = Finish;
                int i = 0;
                while (f != 1)
                {
                    if (f % 2 == 0) f /= 2; f--;
                    i++;
                }
                return i;
            }
                
        }
        public Udvoitel (int min, int max) //Формирование значения между мин и мах
        {
            Finish = new Random().Next(min, max + 1);
        }
        public Udvoitel() //Формирование значения в в установленном промежутке
        {
            Finish = new Random().Next(10, 100);
        }
        public Udvoitel(int finish) //Устанавливаем значение
        {
            this.Finish =finish;
        }

        internal class Udvoitel
        {
        }
    }
}
