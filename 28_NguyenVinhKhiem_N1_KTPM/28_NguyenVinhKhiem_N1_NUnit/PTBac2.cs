using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_NguyenVinhKhiem_N1_NUnit
{
    public class PTBac2
    {
        //28-Khiem
        private int a, b, c;
        public PTBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //28-Khiem
        public int Execute(string CalSymbol)
        {
            int result = 0;
            switch (CalSymbol)
            {
                case "delta":
                    result = this.b * this.b - 4 * this.a * this.c;
                    break;
            }
            return result;
        }
    }
}
