using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaCircularEstatica
{
    public partial class Form1 : Form
    {
        public Fila fila { get; set; }

        public Form1()
        {
            InitializeComponent();
            fila = new Fila();
            fila.Enfileirar("A");
            fila.Enfileirar("B");
            fila.Enfileirar("C");
            fila.Enfileirar("D");
        }

        private void btnRetornaInicio_Click(object sender, EventArgs e)
        {
            try
            {
                tbResultado.Text += "Início da fila: " + fila.RetornaInicio() + "\r\n";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetornaFim_Click(object sender, EventArgs e)
        {
            try
            {
                tbResultado.Text += "Fim da fila: " + fila.RetornaFim() + "\r\n";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                tbResultado.Text += "Fila: " + fila.Listar() + "\r\n";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInverterFila_Click(object sender, EventArgs e)
        {
            try
            {
                var tempFila = new string[fila.Tamanho()];
                for (int i = 0; i < tempFila.Length; i++)
                {
                    tempFila[i] = fila.Desenfileira();
                }

                for (int i = tempFila.Length - 1; i >= 0; i--)
                {
                    fila.Enfileirar(tempFila[i]);
                }
                tbResultado.Text += "A fila foi invertida: " + fila.Listar() + "\r\n";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
