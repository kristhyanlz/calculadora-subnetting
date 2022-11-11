using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_subnetting
{
    class IpNumber
    {
        public DualNumber[] octeto;
        private int clase;// "ABCDE" - 0 = A
        public IpNumber()
        {
            octeto = new DualNumber[4];
            clase = -1;
            for (int i = 0; i < 4; ++i)
            {
                octeto[i] = new DualNumber();
            }
        }

        public void AddJump(int n)
        {
            int idx = GetIdx();

            int val = octeto[idx].Num;

            octeto[idx].SetByDec(val + n);
        }

        public void formatSubnetting()
        {
            int idx = GetIdx();

            for (int i = idx; i < 4; ++i)
            {
                octeto[i].SetByDec(0);
            }
        }

        public void formatBroadcast(int salto)
        {
            salto -= 1;
            int idx = GetIdx() + 1;

            for (int i = idx; i < 4; ++i)
            {
                octeto[i].SetByDec(255);
            }
            AddJump(salto);
        }

        public void SetByString(string ip)
        {
            //string phrase = "The quick brown    fox     jumps over the lazy dog.";
            string[] oct = ip.Split('.');
            SetClassByString(oct[0]);
            int i = 0;
            foreach (var n in oct)
            {
                octeto[i].SetByDec( int.Parse(n) );// SetByBin(n);
                ++i;
            }
        }

        public void SetByBits(int bits)
        {
            if (clase == -1)
            {
                return;
            }

            string newOct = "";
            for (int i = 0; i < 8; ++i)
            {
                if(i < bits)
                {
                    newOct += "1";// + newOct;
                }
                else
                {
                    newOct += "0";
                }
            }
            octeto[clase + 1].SetByBin(newOct);
        }

        public void SetMaskByClass(char clas)
        {
            bool flag = false;
            foreach (char c in "ABCDE")
            {
                if (c == clas)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                return;
            }

            
            if (clas == 'A')
            {
                SetByString("255.0.0.0");
                clase = 0;
            }
            else if (clas == 'B')
            {
                SetByString("255.255.0.0");
                clase = 1;
            }
            else
            {
                SetByString("255.255.255.0");
                clase = 2;
            }
        }

        public char ClaseStr
        {
            get { return "ABCDE"[clase]; }
            //set { clase = value; }
        }

        public int ClaseInt
        {
            get { return clase; }
            //set { clase = value; }
        }

        private void SetClassByString(string num)
        {
            int n = int.Parse(num);
            if (n < 128)
            {
                clase = 0;
            }
            else if (n < 192)
            {
                clase = 1;
            }
            else if (n < 224)
            {
                clase = 2;
            }
            else if (n < 240)
            {
                clase = 3;
            }
            else
            {
                clase = 4;
            }
             
        }

        public int GetByIdx()
        {
            return octeto[clase + 1].Num;
        }

        public int GetIdx()
        {
            return clase + 1;
        }

        public void NOT()
        {
            for(int i = 0; i < 4; ++i)
            {
                octeto[i].NOT();
            }
        }

        public override string  ToString()
        {
            string rp = "";
            foreach (var i in octeto)
            {
                rp += i.Num.ToString() + ".";
            }
            rp = rp.Substring(0, rp.Length - 1);

            return rp;
        }

        public void Load(IpNumber a)
        {
            SetByString(a.ToString());
            clase = a.ClaseInt;
        }
    }
}
