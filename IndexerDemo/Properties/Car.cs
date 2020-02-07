using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    class Car
    {
        int yr;
        string[] name = new string[4];

        public int Yr
        {
            get => yr;
            set => yr = value;
        }
    }
}
