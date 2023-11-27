using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Orident_Programming_Method_Clas
{
    internal class Methods_Tutorial
    {
        int _i;
        float _f = 3.14f;

        public Methods_Tutorial(int i)
        {
            this._i = i;
        }
        public float AlaniHesapla()
        {
          return (this._i * this._i * this._f); 
        }
    }
}