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
    public partial class Lotto2 : Form
    {
        public Lotto2()
        {
            InitializeComponent();
        }

      
        private void Lotto2_Load(object sender, EventArgs e)
        {

            
            ticketTxt.Text = "Your Lotto Ticket";
            ticketTx1.Text = " _______________________";

            ticketTxtPrice.Text = "Ticket Price: € " + Lotto1.ticPrice;

            ticketTxt2.Text = " _______________________";
            ticketTxtUrNos.Text = "Your Numbers \n\n";

            ticketTxtLn1.Text = Lotto1.printLn1;
            ticketTxtLn2.Text = Lotto1.printLn2;
            ticketTxtLn3.Text = Lotto1.printLn3;
            ticketTxtLn4.Text = Lotto1.printLn4;
            ticketTxtLn5.Text = Lotto1.printLn5;

            ticketTxt3.Text = " _______________________";

            ticketTxt4.Text = "Winning ticket wins a ";
            ticketTxt5.Text = "box of QUALITY STREET!";

            ticketTxt6.Text = " _______________________";

            ticketTxtGdLk.Text = "Good luck!";

        }
    }
}
