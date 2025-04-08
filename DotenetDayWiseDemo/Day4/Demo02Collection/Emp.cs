using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollection01
{
    public class Emp
    {
        
            private int _No;
            private string _Name;
            private string _Address;

            public Emp()
            {

            }

            public Emp(int no, string name, string address)
            {
                _No = no;
                _Name = name;
                _Address = address;
            }

            public string Address
            {
                get { return _Address; }
                set { _Address = value; }
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public int No
            {
                get { return _No; }
                set { _No = value; }
            }


        }
    }

