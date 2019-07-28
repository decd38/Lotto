using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoCA1
{
    public partial class Lotto1 : Form
    {

        List<int> myNumbers = new List<int>();

        List<string> typeLine = new List<string>();

        List<int> line1 = new List<int>();
        List<int> line2 = new List<int>();
        List<int> line3 = new List<int>();
        List<int> line4 = new List<int>();
        List<int> line5 = new List<int>();

        int value = 0;

        int noOfLines = 0;

        public static string printLn1 = "";
        public static string printLn2 = "";
        public static string printLn3 = "";
        public static string printLn4 = "";
        public static string printLn5 = "";

        public static double ticPrice; 

        List<RoundButton> buttons = new List<RoundButton>();

        public Lotto1()
        {
            InitializeComponent();
            btnConfirm.Enabled = false;
            buttons = new List<RoundButton> {rdBtn1, rdBtn2, rdBtn3, rdBtn4, rdBtn5, rdBtn6, rdBtn7, rdBtn8, rdBtn9, rdBtn10,
                                    rdBtn11, rdBtn12, rdBtn13, rdBtn14,rdBtn15, rdBtn16, rdBtn17, rdBtn18, rdBtn19, rdBtn20,
                                    rdBtn21, rdBtn22, rdBtn23, rdBtn24, rdBtn25, rdBtn26, rdBtn27, rdBtn28, rdBtn29, rdBtn30,
                                    rdBtn31, rdBtn32, rdBtn33, rdBtn34, rdBtn35, rdBtn36, rdBtn37, rdBtn38, rdBtn39, rdBtn40,
                                    rdBtn41, rdBtn42, rdBtn43, rdBtn44, rdBtn45, rdBtn46, rdBtn47, rdBtn48, rdBtn49, rdBtn50};
        }

        public static List<int> QuickPick()
        {
            Random rndNum = new Random();
            List<int> quPk = new List<int>();

            List<string> quickPick = new List<string>();

            int tempNo = 0;

            for (int i = 0; i < 6; i++)
            {
                tempNo = rndNum.Next(1, 51);

                while (quPk.Contains(tempNo) == true)
                {
                    tempNo = rndNum.Next(1, 51);

                }
                quPk.Add(tempNo);
            }
            quPk.Sort();
            return quPk;

        }

        public static bool DuplicateLines(List<int> lottoLn1, List<int> inputLine)
        {          
                for (int i = 0; i < 6; i++)
                {
                    if ((lottoLn1[i] == inputLine[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }          
                return true;
        }

        public static bool DuplicateLines(List<int> lottoLn1, List<int> lottoLn2, List<int> inputLine)
        {
            for (int i = 0; i < 6; i++)
            {
                if ((inputLine[i] == lottoLn1[i]) || (inputLine[i] == lottoLn2[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool DuplicateLines(List<int> lottoLn1, List<int> lottoLn2, List<int> lottoLn3, List<int> inputLine)
        {
            for (int i = 0; i < 6; i++)
            {
                if ((inputLine[i] == lottoLn1[i]) || (inputLine[i] == lottoLn2[i]) || (inputLine[i] == lottoLn3[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool DuplicateLines(List<int> lottoLn1, List<int> lottoLn2, List<int> lottoLn3, List<int> lottoLn4, List<int> inputLine)
        {
            for (int i = 0; i < 6; i++)
            {
                if ((inputLine[i] == lottoLn1[i]) || (inputLine[i] == lottoLn2[i]) || (inputLine[i] == lottoLn3[i]) || (inputLine[i] == lottoLn4[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static void PopulateTicket(List<int> inputList, List<int> lotto1, List<int> lotto2, List<int> lotto3, List<int> lotto4,
        List<int> lotto5)
        {
            if (lotto1.Count != 6)
            {
                lotto1.AddRange(inputList);
            }
            else if (lotto2.Count != 6)
            {
                lotto2.AddRange(inputList);
            }
            else if (lotto3.Count != 6)
            {
                lotto3.AddRange(inputList);
            }
            else if (lotto4.Count != 6)
            {
                lotto4.AddRange(inputList);
            }
            else
            {
                lotto5.AddRange(inputList);
            }

        }

        public static bool ConfirmButton(List<int> firstLine)
        {
            if (firstLine.Count == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool TicketFull(List<int> lotto1, List<int> lotto2, List<int> lotto3,
        List<int> lotto4, List<int> lotto5)
        {
            if ((lotto1.Count == 6) && ((lotto2.Count == 6) && (lotto3.Count == 6) &&
                (lotto4.Count == 6) && (lotto5.Count == 6)))

            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static List<string> nosToString(List<int> noList)
        {
            string tempOutPut = "";

            List<string> outPut = new List<string> {};

            for (int k = 0; k < noList.Count; k++)
             {
                if(noList[k] < 10)
                {
                    tempOutPut = noList[k].ToString("D2");
                    outPut.Add(tempOutPut);
                }
                else
                {
                    tempOutPut = noList[k].ToString();
                    outPut.Add(tempOutPut);
                }
                
             }
                        
            return outPut;
        }

        public static string PrintTicketNos(List<string> inputLine)
        {
            string OutPutLine = "";

            foreach(string no in inputLine)
            {
                OutPutLine += no;
                OutPutLine += "  ";
            }

            return OutPutLine;
        }

        public static double ticketPrice(List<int> lotto1, List<int> lotto2, List<int> lotto3,
        List<int> lotto4, List<int> lotto5)
        {
            if ((lotto1.Count.Equals(6)) && (lotto2.Count.Equals(0)) && (lotto3.Count.Equals(0)) && (lotto4.Count.Equals(0)) && (lotto5.Count.Equals(0)))
            {
                ticPrice = 2.00;
            }

            if ((lotto1.Count.Equals(6)) && (lotto2.Count.Equals(6)) && (lotto3.Count.Equals(0)) && (lotto4.Count.Equals(0)) && (lotto5.Count.Equals(0)))
            {
                ticPrice = 4.00;
            }

            if ((lotto1.Count.Equals(6)) && (lotto2.Count.Equals(6)) && (lotto3.Count.Equals(6)) && (lotto4.Count.Equals(0)) && (lotto5.Count.Equals(0)))
            {
                ticPrice = 6.00;
            }

            if ((lotto1.Count.Equals(6)) && (lotto2.Count.Equals(6)) && (lotto3.Count.Equals(6)) && (lotto4.Count.Equals(6)) && (lotto5.Count.Equals(0)))
            {
                ticPrice = 8.00;
            }
            if ((lotto1.Count.Equals(6)) && (lotto2.Count.Equals(6)) && (lotto3.Count.Equals(6)) && (lotto4.Count.Equals(6)) && (lotto5.Count.Equals(6)))
            {
                ticPrice = 10.00;
            }

            return ticPrice;
        }


        private void rdBtn1_Click(object sender, EventArgs e)
    {
            YourNumbers.Items.Clear();
            RoundButton btn = sender as RoundButton;
            myNumbers.Add(int.Parse(btn.Text));
            value++;
            btn.Enabled = false;

            if (value == 6)
            {
                myNumbers.Sort();

                typeLine = nosToString(myNumbers);

                YourNumbers.Items.Add(typeLine[0] + " - " + typeLine[1] + " - " + typeLine[2] + " - " +
                                typeLine[3] + " - " + typeLine[4] + " - " + typeLine[5]);

                typeLine.Clear();

                if ((line1.Count.Equals(6)) && (line2.Count.Equals(0)) && (line3.Count.Equals(0)) && (line4.Count.Equals(0)))
                {
                    if (DuplicateLines(line1, myNumbers) == true)
                    {
                        myNumbers.Clear();
                        YourNumbers.Items.Clear();
                        MessageBox.Show("Line already Picked!\n\nDon't be greedy!", "DUPLICATION ERROR");
                    }

                }

                else if ((line1.Count.Equals(6)) && (line2.Count.Equals(6)) && (line3.Count.Equals(0)) && (line4.Count.Equals(0)))
                {
                    if (DuplicateLines(line1, line2, myNumbers) == true)
                    {
                        YourNumbers.Items.Clear();
                        MessageBox.Show("Line already Picked!\n\nDon't be greedy!", "DUPLICATION ERROR");
                        myNumbers.Clear();
                    }
                }

                else if ((line1.Count.Equals(6)) && (line2.Count.Equals(6)) && (line3.Count.Equals(6)) && (line4.Count.Equals(0)))
                {
                    if (DuplicateLines(line1, line2, line3, myNumbers) == true)
                    {
                        YourNumbers.Items.Clear();
                        MessageBox.Show("Line already Picked!\n\nDon't be greedy!", "DUPLICATION ERROR");
                        myNumbers.Clear();
                    }

                }

                else if ((line1.Count.Equals(6)) && (line2.Count.Equals(6)) && (line3.Count.Equals(6)) && (line4.Count.Equals(6)))
                 {
                    if (DuplicateLines(line1, line2, line3, line4, myNumbers) == true)
                    {
                        YourNumbers.Items.Clear();
                        MessageBox.Show("Line already Picked!\n\nDon't be greedy!", "DUPLICATION ERROR");
                        myNumbers.Clear();
                    }

                }
                if (myNumbers.Count.Equals(6))
                {
                    PopulateTicket(myNumbers, line1, line2, line3, line4, line5);
                    noOfLines++;
                    numberOfLines.Text = " Line " + noOfLines + " complete";
                }

                if (ConfirmButton(line1) == true)
                {
                    btnConfirm.Enabled = true;
                }

                myNumbers.Clear();

                value = 0;

                foreach (RoundButton b in buttons)
                {
                    b.Enabled = false;

                }
                foreach (RoundButton b in buttons)
                {
                    b.Enabled = true;
                }

            }
   

            if (TicketFull(line1, line2, line3, line4, line5) == true)
            {
                foreach (RoundButton b in buttons)
                {
                    b.Enabled = false;

                }
                MessageBox.Show("Ticket Complete!");
                YourNumbers.Items.Clear();
                btnQuPk.Enabled = false;
            }
        }

        private void btnQuPk_Click(object sender, EventArgs e)
        {

            YourNumbers.Items.Clear();

            List<int> lineQuPk = QuickPick();

            typeLine = nosToString(lineQuPk);

            YourNumbers.Items.Add(typeLine[0] + " - " + typeLine[1] + " - " + typeLine[2] + " - " +
                            typeLine[3] + " - " + typeLine[4] + " - " + typeLine[5]);

            typeLine.Clear();
                                   
            PopulateTicket(lineQuPk, line1, line2, line3, line4, line5);

            noOfLines++;
            numberOfLines.Text = " Line " + noOfLines + " complete";

            if (ConfirmButton(line1) == true)
            {
                btnConfirm.Enabled = true;
            }


            if (TicketFull(line1, line2, line3, line4, line5) == true)
            {
                foreach (RoundButton b in buttons)
                {
                    b.Enabled = false;

                }
                btnQuPk.Enabled = false;
                MessageBox.Show("Ticket Complete!");
                YourNumbers.Items.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numberOfLines.Text = " All Lines Cleared";
            line1.Clear();
            line2.Clear();
            line3.Clear();
            line4.Clear();
            line5.Clear();
            MessageBox.Show("Ticket Cleared");
            YourNumbers.Items.Clear();
            foreach (RoundButton b in buttons)
            {
                b.Enabled = true;

            }
            btnQuPk.Enabled = true;
            btnConfirm.Enabled = false;
            noOfLines = 0;
            numberOfLines.Text = "No Lines Complete";
            
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {            
            List<string> Ln1toString = nosToString(line1);
            List<string> Ln2toString = nosToString(line2);
            List<string> Ln3toString = nosToString(line3);
            List<string> Ln4toString = nosToString(line4);
            List<string> Ln5toString = nosToString(line5);     
            
            printLn1 = PrintTicketNos(Ln1toString);
            printLn2 = PrintTicketNos(Ln2toString);
            printLn3 = PrintTicketNos(Ln3toString);
            printLn4 = PrintTicketNos(Ln4toString);
            printLn5 = PrintTicketNos(Ln5toString);

            ticPrice = ticketPrice(line1, line2, line3, line4, line5);
            
            this.Hide();

            Lotto2 lottoTicket = new Lotto2();
            lottoTicket.Show();
                                   
        }
    }

}