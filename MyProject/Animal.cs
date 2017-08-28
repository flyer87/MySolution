using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Animal
    {
        private int _age;
        private string _name;

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public string Namedadad
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
