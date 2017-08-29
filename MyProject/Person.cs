using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Person
    {
        private int _age1;
        private string _name;
        private string _address;
        private int _zip;

        public int Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Age
        {
            get
            {
                return _age3;
            }

            set
            {
                _age3 = value;
            }
        }

        public string Name
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

        public int NewMethod()
        {
            return default(int);
        }
    }
}
