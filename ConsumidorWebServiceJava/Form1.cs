using ConsumidorWebServiceJava.br.com.devmedia.dotnet.webservice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumidorWebServiceJava
{
    public partial class Form1 : Form
    {
        private PrimeiroSoapWSService webService;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webService = new PrimeiroSoapWSService();
            string voltou = webService.ping("Deivison");

            MessageBox.Show("Voltou: " + voltou);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webService = new PrimeiroSoapWSService();
            carro[]  carros = webService.getMeusCarros();

            foreach (carro carro in carros)
            {
                MessageBox.Show(
                    "Nome: " + carro.nome + " " 
                    + "Marca: " + carro.marca + " "
                    + "Cor: " + carro.cor);
            }

        }
    }
}
