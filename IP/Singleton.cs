using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP
{
    static class Singleton
    {
        private static int _globalVar = 0;

        public static int GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
}
