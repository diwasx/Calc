using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calc : Form
    {
        int operation=0;
        double tmpOp;                                   //hard temp 
        string accu="";                                 //screenkotext accumalator haru (soft temp)
        double rst;
        double mem = 0;

        public Calc()
        {
            InitializeComponent();
            MemChecker();
        }


        public void MemChecker()                ///memory zore vayema unclickable button
        {
            if (mem == 0)
            {
                MemR.Enabled = false;
                MemC.Enabled = false;
            }
            else
            {
                MemR.Enabled = true;
                MemC.Enabled = true;
            }
        }

        private void button0_Click(object sender, EventArgs e)   
                                    //e ma event data like important args bascha ra sender ma kesle garda event vako ra k garne ta bhanne data huncha
        {
            Screen.Text = "";
            accu += "0";
            Screen.Text = accu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "1";
            Screen.Text = accu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "2";
            Screen.Text = accu;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "3";
            Screen.Text = accu;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "4";
            Screen.Text = accu;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "5";
            Screen.Text = accu;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "6";
            Screen.Text = accu;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "7";
            Screen.Text = accu;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "8";
            Screen.Text = accu;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += "9";
            Screen.Text = accu;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            accu += ".";
            Screen.Text = accu;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            /*              equal button thicna na parne operation haru
            switch (operation)
            {
                case 5:
                    rst = Math.Sqrt(tmpOp);
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
                case 6:
                    rst = (tmpOp * tmpOp);
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
                case 7:
                    rst = Math.Pow(10, tmpOp);
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
                case 8:
                    rst = -(tmpOp);
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
            }
            */

            if (accu == "")
                return;                                     //acc khali hunu vayena adhi vayo bhane temOp(result) bta value lincha operation haru ma
            double equalButton = Convert.ToDouble(accu);
            switch (operation)
            {
                case 1:
                    rst = tmpOp + equalButton;
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
                case 2:
                    rst = tmpOp - equalButton;
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
                case 3:
                    rst = tmpOp * equalButton;
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
                case 4:
                    rst = tmpOp / equalButton;
                    Screen.Text = Convert.ToString(rst);
                    Screen1.Text = "";
                    accu = "";
                    break;
                
                
            }
            tmpOp = rst;
            operation = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (accu != "")                                          //suru ma operator thichyo bhane yo condition mildaina ani accu khali ni hunu vayena
                                                                     //equal operation pxi pheri result lai manipulate garna help garcha
                tmpOp = Convert.ToDouble(accu);
            Screen1.Text = tmpOp + "+";
            operation = 1;
            accu = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            Screen1.Text = tmpOp + "-";
            operation = 2;
            accu = "";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            Screen1.Text = tmpOp + "x";
            operation = 3;
            accu = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            Screen1.Text = tmpOp + "/";
            operation = 4;
            accu = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            accu = "";
            Screen.Text = "0";
            
        }

        private void Del_Click(object sender, EventArgs e)
        {
            
            if (accu == "")
                return;
            accu = accu.Remove(accu.Length - 1);
            Screen.Text = accu;

        }

        private void HardClear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen1.Text = "";
            accu = "";
            tmpOp = 0;
        }


                                                                            //equal button thicna na parne operation haru

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            rst = Math.Sqrt(tmpOp);
            Screen.Text = Convert.ToString(rst);
            tmpOp = rst;
            accu = "";
        }

                                                                             //squareofnumber
        private void button12_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            rst = (tmpOp * tmpOp);
            Screen.Text = Convert.ToString(rst);
            tmpOp = rst;
            accu = "";
        }

        private void Expo_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            if (tmpOp == 0)                                                 //O ko expo na banaune, it leads to infinity
                return;
            rst = Math.Pow(10, tmpOp);
            Screen.Text = Convert.ToString(rst);
            tmpOp = rst;
            accu = "";
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            rst = -tmpOp;
            Screen.Text = Convert.ToString(rst);
            tmpOp = rst;
            accu = "";
        }

        private void DivideByOne_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            if (tmpOp == 0)
                return;
            rst = 1/tmpOp;
            Screen.Text = Convert.ToString(rst);
            tmpOp = rst;
            accu = "";
        }

        
                                                                            //memory buttons
        private void MemPlus_Click(object sender, EventArgs e)
        {
            if(accu!="")
                tmpOp = Convert.ToDouble(accu);
            mem += tmpOp;
            accu = "";
            if(tmpOp!=0)
                Screen1.Text = "Added to Memory";
            MemChecker();

        }

        private void MemMinus_Click(object sender, EventArgs e)
        {
            if (accu != "")
                tmpOp = Convert.ToDouble(accu);
            mem -= tmpOp;
            accu = "";
            if(tmpOp!=0)
                Screen1.Text = "Subtracted from Memory";
            MemChecker();
        }

        private void MemR_Click(object sender, EventArgs e)
        {
            Screen.Text = Convert.ToString(mem);
            accu = Convert.ToString(mem);
            Screen1.Text = "Memory";
            accu = "";
            
        }

        private void MemC_Click(object sender, EventArgs e)
        {
            
            if (tmpOp != 0 && mem!=0)
                Screen1.Text = "Memory Cleared";
            mem = 0;
            accu = "";
            MemChecker();
        }
    }
}
