using System;
using System.Collections.Generic;
using System.Text;

namespace Test02_LageEnClassOgEndre
{
    class Ingrediens
    {
        private int _amount;
        private string _unit;

        public Ingrediens(int amount, string unit)
        {
            _amount = amount;
            _unit = unit;
        }

        public string GetDescription()
        {
            return _amount + " " + _unit;
        }
    }


}
