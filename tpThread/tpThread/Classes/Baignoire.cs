using System;
using System.Collections.Generic;
using System.Text;

namespace tpThread.Classes
{
    public class Baignoire
    {
        public static Eau contenu;

        public Baignoire()
        {
            contenu = new Eau(0);
        }

        public void fuite(int v)
        {
            contenu.Volume -= v;
        }
    }
}
