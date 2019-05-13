using System;
using System.Collections.Generic;
using System.Text;

namespace tpThread.Classes
{
    public class Eau
    {
        public static int volume;

        public Eau(int v)
        {
            volume = v;
        }

        public int Volume { get => volume; set => volume = value; }
    }
}
