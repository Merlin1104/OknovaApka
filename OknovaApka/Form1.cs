using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OknovaApka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            bSend.Tag = 1;
            bSend2.Tag = 2;
            
        }

        private void bSend_Click(object sender, EventArgs e) //sender je objekt kt ten event vyvolal, v tomto pripade to tlacitko send
                                                            //tento event pouzivaju oba buttony
                                                            //dole to pretypovavame ten sender lebo je to object a nie button takze sa to musi pretypovat
        {
            Button b = (Button)sender; //pretypovavame ten sender 

            
            string s = b.Tag + ": " + tbMessage.Text;
            tbChat.Text += s + Environment.NewLine;

            tbMessage.Text = ""; // vymaze text kt sme napisali
        }
    }
}
