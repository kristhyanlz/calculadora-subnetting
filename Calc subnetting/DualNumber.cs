using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_subnetting
{
    class DualNumber
    {
        private int num;
        private string bin;

        public DualNumber()
        {
            num = 0;
            bin = "0";
        }
        public DualNumber(int n)
        {
            num = n;
            bin = "";
            SetByDec(n);
        }
        public void SetByDec(int n)
        {
            num = n;
            bin = "";
            if (n == 0)
            {
                bin = "00000000";
            }
            while (n > 0)
            {
                if ( (n >> 1 << 1) == n)
                {
                    bin = "0" + bin;
                }
                else
                {
                    bin = "1" + bin;
                }
                
                n >>= 1;
            }
        }

        public void SetByBin(string sn)
        {
            //Verificamos que la cadena sea de un numero binario
            foreach (char c in sn)
            {
                if(c != '0' && c != '1')
                {
                    return;
                }
            }

            bin = sn;
            num = 0;
            int pot2 = 1; 
            while (sn.Length > 0)
            {
                char ultDigit = sn[sn.Length - 1];
                if (ultDigit == '1')
                {
                    num += pot2;
                }
                
                sn = sn.Substring(0, sn.Length - 1);
                pot2 <<= 1;
            }
            
        }

        public void SetByConcat(DualNumber a, DualNumber b)
        {
            string newN = a.Bin + b.Bin;
            SetByBin(newN);
        }

        public void SetByConcat(DualNumber a, DualNumber b, DualNumber c)
        {
            string newN = a.Bin + b.Bin + c.Bin;
            SetByBin(newN);
        }

        public void SetByConcat(DualNumber a, DualNumber b, DualNumber c, DualNumber d)
        {
            string newN = a.Bin + b.Bin + c.Bin + d.Bin;
            SetByBin(newN);
        }

        public void SetByIpNumber(IpNumber a)
        {
            string newN = "";// = a.octeto[0].bin;
            for (int i = 0; i < 4; ++i)
            {
                newN += a.octeto[i].Bin;
            }
            SetByBin(newN);
        }
        public void NOT()
        {
            string newN = "";
            foreach(char c in bin)
            {
                char digit = (c == '1') ? '0' : '1';
                newN += digit.ToString();
            }
            SetByBin(newN);
        }

        public int Num   
        {
            get { return num; }
            set { SetByDec(value); }
        }

        public string Bin
        {
            get { return bin; }
            set { SetByBin(value); }
        }
    }
}
