using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Locar class1 = new Locar();

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void BtnCalcularValor_Click(object sender, EventArgs e)
        {
             
           
            class1.Cpf = txtCpf.Text;
            class1.Filme = txtNome.Text;
            class1.DataDevolucao= txtDataD.Value;
            class1.DataLocacao = txtDataL.Value;
            double valorPdia = 4;
            
            string DataL = class1.DataLocacao.ToString();
            string DataD = class1.DataDevolucao.ToString();
            TimeSpan diferenca = Convert.ToDateTime(DataD).Subtract(Convert.ToDateTime(DataL));
           
            
            class1.Valor = valorPdia * diferenca.Days;
          
            MessageBox.Show(this, "CPF" + class1.Cpf + "\n" +
             "Nome do filme:" + class1.Filme + "\n"+
            "Data de locação:" + txtDataL.Value + "\n" +
            "Data Devolução:" + txtDataD.Value + "\n+"+
            "Valor:" + "R$"+ class1.Valor + "\n"+
           "Dias Diferença:"+ diferenca );

        }
    }
}
