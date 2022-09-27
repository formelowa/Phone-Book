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
    public partial class Reg_Data : Form
    {
        public Reg_Data()
        {
            InitializeComponent();
        }

        private void Reg_Data_Load(object sender, EventArgs e)
        {
            this.info_gBox.Enabled = false;
        }

        private void Info_Button_Click(object sender, EventArgs e)
        {
            this.Info_Button.Enabled = false;
            this.saveButton.Enabled = true;
            this.info_gBox.Enabled = true;

            //----Clear textboxes------//
            this.ID_tb.ResetText();
            this.First_N_tb.ResetText();
            this.Last_N_tb.ResetText();
            this.tel_tb.ResetText();   
            this.cell_tb.ResetText();
            this.adress_tb.ResetText();
            this.comment_tb.ResetText();    
            this.email_tb.ResetText();  
            //--------------------------//

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if(this.ID_tb.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }

            this.Info_Button.Enabled = true;
            this.saveButton.Enabled = false;
            this.info_gBox.Enabled=false;

            //--------Save Changes-------//

            string fn;
            string p;

            fn = "C:\\Nauka\\Phone Book\\";


            //----------- First Name ------------

            p = fn + this.ID_tb.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.First_N_tb.Text, Encoding.UTF8);

            //-----------Last name---------------

            p = fn + this.ID_tb.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.Last_N_tb.Text, Encoding.UTF8);

            //----------- Tel ---------------

            p = fn + this.ID_tb.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.tel_tb.Text, Encoding.UTF8);
           
            //----------- Cell ---------------

            p = fn + this.ID_tb.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.cell_tb.Text, Encoding.UTF8);

            //-----------  email ---------------

            p = fn + this.ID_tb.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.email_tb.Text, Encoding.UTF8);

            //----------- Adress ---------------

            p = fn + this.ID_tb.Text + "_adress.txt";
            System.IO.File.WriteAllText(p, this.adress_tb.Text, Encoding.UTF8);

            //----------- Comment ---------------

            p = fn + this.ID_tb.Text + "_com.txt";
            System.IO.File.WriteAllText(p, this.comment_tb.Text, Encoding.UTF8);


            MessageBox.Show("Saved!");
        }
    }
}
