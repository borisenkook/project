using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Udvoitel;

namespace WF_Udvoitel
{
    enum StatusGame
    {
        Win, Lose, Play
    }
    class Udviotel
    {
        public StatusGame Status { get, private set; } = StatusGame.Play;
        int current = 1;
        public int Finish { get, private set; }
    }
}
public int Current
{
    get
    {
        if (current == Finish) Status = StatusGame.Win;
        if (current > Finish) Status = StatusGame.Lose;
        return current;



    }
}

