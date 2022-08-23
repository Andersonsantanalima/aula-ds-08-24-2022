using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void Btndepos_Click(object sender, EventArgs e)
        {
       
        }

        private void Btnsacar_CheckedChanged(object sender, EventArgs e)
        {

        }

        Conta conta = new Conta();
        private void Btnexecutar_Click(object sender, EventArgs e)
        {
            conta.numero = Convert.ToInt32(txtnumero.Text);
            double valor = Convert.ToDouble(txtvalor.Text);

            if (btnsacar.Checked || conta.erro !="erro")
            {
                         conta.saque(valor);
            }
            else 
            {                
                   conta.depoisitar(valor);     
            }

            lblsaldo.Text = conta.versaldo().ToString("C");
            
        }

    }
    
}
