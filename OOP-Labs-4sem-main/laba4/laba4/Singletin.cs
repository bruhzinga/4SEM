using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal class Singleton
    {
        public Font font;

        public Color col;

        private Singleton()
        {
            font = new Font("Arial", 12, FontStyle.Bold);
            col = Color.Pink;
        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}