using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_subnetting
{
    public partial class Form1 : Form
    {
        private IpNumber ipRed;
        private IpNumber mask;
        private int nBits;
        private int nredes;
        private int nhosts;
        public Form1()
        {
            ipRed = new IpNumber();
            mask = new IpNumber();
            InitializeComponent();
        }

        private void calcBits()
        {
            nredes = int.Parse(txtbox_nredes.Text);
            double temp = Math.Log(nredes, 2);
            nBits = ((int)temp) < temp ? (int)temp + 1 : (int)temp;
        }

        private void readHosts()
        {
            if(txtbox_nhosts.Text == "")
            {
                nhosts = 1;
            }
            else
            {
                nhosts = int.Parse(txtbox_nhosts.Text);
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            txtbox_out.Text = "";

            readHosts();

            ipRed.SetByString(txtbox_inip.Text);/////
            txtbox_out.Text += "RED: " + ipRed.ToString() + Environment.NewLine;

            
            mask.SetMaskByClass(ipRed.ClaseStr);///////

            calcBits();/////////
            txtbox_out.Text += "BITS: "+ nBits.ToString() + Environment.NewLine;

            mask.SetByBits(nBits);////////
            txtbox_out.Text += "MASK: " + mask.ToString() + Environment.NewLine;

            txtbox_out.Text += "CLASE: " + mask.ClaseStr + Environment.NewLine;

            IpNumber maskInv = new IpNumber();
            maskInv.Load(mask);
            maskInv.NOT();
            DualNumber maxHost = new DualNumber();
            maxHost.SetByIpNumber(maskInv);
            maxHost.SetByDec(maxHost.Num - 1);
            txtbox_out.Text += "MAX HOST: " + maxHost.Num.ToString() + Environment.NewLine + Environment.NewLine;

            if (nhosts > maxHost.Num)
            {
                txtbox_out.Text += "ERROR: El numero de host es muy grande " + nhosts.ToString() + Environment.NewLine;
                return;
            }

            int salto = maskInv.GetByIdx() + 1;
            int idx = maskInv.GetIdx();
            txtbox_out.Text += "SALTO: " + salto.ToString() + Environment.NewLine;

            ipRed.formatSubnetting();

            IpNumber ipBroadcast = new IpNumber();
            ipBroadcast.Load(ipRed);
            ipBroadcast.formatBroadcast(salto);
            //txtbox_out.Text += "IP NUEVA!! " + ipBroadcast.ToString() + Environment.NewLine;
            //ipRed.AddJump(salto);
            //txtbox_out.Text += "IP NUEVA!! " + ipRed.ToString() + Environment.NewLine;
            
            for(int i = 0; i < nredes; ++i)
            {
                txtbox_out.Text += "Subred " + i.ToString() + ": " + ipRed.ToString() + " -> " + ipBroadcast.ToString() + Environment.NewLine;
                ipRed.AddJump(salto);
                ipBroadcast.AddJump(salto);
            }
            
        }

        private void run()
        {

        }
    }
}
