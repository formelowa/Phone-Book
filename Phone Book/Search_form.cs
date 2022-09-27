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
    public partial class Search_form : Form
    {
        public Search_form()
        {
            InitializeComponent();
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            if (this.search_tb.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }

            string fn;
            string p;
            string r;
            fn = "C:\\Nauka\\Phone Book\\";

            //----------- Search for Data-------------//

            //----------- First Name ------------

            p = fn + this.search_tb.Text + "_fn.txt";

            if (System.IO.File.Exists(p)==true)
            {
                r = System.IO.File.ReadAllText(p,Encoding.UTF8);
                this.First_N_tb.Text = r;
            }

            //----------- Last Name ------------

            p = fn + this.search_tb.Text + "_ln.txt";

            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Last_N_tb.Text = r;
            }

            //----------- Tel ------------

            p = fn + this.search_tb.Text + "_tel.txt";

            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tel_tb.Text = r;

            }

            //----------- Cell ------------

            p = fn + this.search_tb.Text + "_cell.txt";

            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.cell_tb.Text = r;
            }
            //----------- email ------------

            p = fn + this.search_tb.Text + "_email.txt";

            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_tb.Text = r;
            }
            //----------- adress ------------

            p = fn + this.search_tb.Text + "_adress.txt";

            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.adress_tb.Text = r;
            }
            //----------- comment ------------

            p = fn + this.search_tb.Text + "_com.txt";

            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.comment_tb.Text = r;
            }
            //--------------------------------------------------------
        }
    }
}
