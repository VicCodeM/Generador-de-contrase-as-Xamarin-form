using System;
using System.Collections.Generic;
using System.Text;

namespace GenerarPassword
{
    public class NumeroBits
    {
        public string  CalcularBits(string pass)
        {
            int num = 8;
            int res = pass.Length*num;
            pass = res.ToString();
            return pass;
        }

    }
}
