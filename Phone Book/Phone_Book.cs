using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Phone_Book : Form
    {
        public Phone_Book()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Reg_Data rg = new Reg_Data();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Search_form rg = new Search_form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            About_us rg = new About_us();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Phone_Book_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
            {
                toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton5_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton4_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton3_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton1_Click(sender, e);
            }
        }
    }
}
