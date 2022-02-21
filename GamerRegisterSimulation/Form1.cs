using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamerRegisterSimulation
{
    public partial class Form1 : Form
    {

        Gamer gamer = new Gamer();
        public Form1()
        {
            InitializeComponent();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gamer.Username = txtUsername.Text;
            gamer.Password = txtPassword.Text;
            gamer.ConfirmPassword = txtConfirm.Text;
            gamer.NationalIdentity = txtIdentityNumber.Text;
            gamer.BirthYear = Int32.Parse(txtBirthYear.Text);
            gamer.Id = 1;
            gamer.Status = true;

            GamerManager gamerManager = new GamerManager(new SystemValidationManager());
            string message = gamerManager.Add(gamer);
            MessageBox.Show(message);
           
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            txtBirthYear.Text = "";
            txtIdentityNumber.Text = "";




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';


        }
    }

}
