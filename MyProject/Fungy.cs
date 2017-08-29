using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Fungy
    {
        private int _age3;
        private string _name;
        private string _color;

        public string Color
        {
            get { return _color; }
            private set { _color = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age3; }
            set { _age3 = value; }
        }

    }
}
