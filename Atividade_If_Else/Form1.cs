using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtCampo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificarNumero_Click(object sender, EventArgs e)
        {
            // 1. Pega o valor da Textbox e converte para número
            // (Certifique-se que o nome da sua TextBox é txtCampo senão vai rolar um erro)
            double numero = double.Parse(txtCampo1.Text);

            // 2. Lógica de verificação para número se ele for positivo ou negativo 
            if (numero > 0)
            {
                MessageBox.Show("O número é Positivo.");
            }
            else if (numero < 0)
            {
                MessageBox.Show("O número é Negativo.");
            }
            else
            {
                MessageBox.Show("O número é Zero.");
            }
        }

        private void btnDeterminarMaior_Click(object sender, EventArgs e)
        {
            {
                // 1. Pega os valores das três dos txtCampo1, txtCampo2 e txtCampo3
                double n1 = double.Parse(txtCampo1.Text);
                double n2 = double.Parse(txtCampo2.Text);
                double n3 = double.Parse(txtCampo3.Text);

                double maior;

                // 2. Compara os números para achar o maior
                if (n1 >= n2 && n1 >= n3)
                {
                    maior = n1;
                }
                else if (n2 >= n1 && n2 >= n3)
                {
                    maior = n2;
                }
                else
                {
                    maior = n3;
                }

                // 3. Mostra o resultado na tela do usuário
                MessageBox.Show("O maior número é: " + maior);
            }
        }

        private void btnValidarLetra_Click(object sender, EventArgs e)
        {
            // 1. Pega a letra da caixa de texto e deixa minúscula (para facilitar)
            string letra = txtCampo1.Text;

            // 2. Verifica se é uma vogal
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                MessageBox.Show("É uma vogal!");
            }
            else
            {
                // 3. Se não for vogal, o programa assume que é consoante
                MessageBox.Show("É uma consoante!");
            }
        }

        private void btnConsultarMes_Click(object sender, EventArgs e)
        {
            // 1. Pega o texto direto da caixa
            string mes = txtCampo1.Text;

            // 2. Verifica meses com 31 dias (nomes e números)
            if (mes == "janeiro" || mes == "01" || mes == "1" ||
                mes == "março" || mes == "03" || mes == "3" ||
                mes == "maio" || mes == "05" || mes == "5" ||
                mes == "julho" || mes == "07" || mes == "7" ||
                mes == "agosto" || mes == "08" || mes == "8" ||
                mes == "outubro" || mes == "10" ||
                mes == "dezembro" || mes == "12")
            {
                MessageBox.Show("Este mês tem 31 dias.");
            }
            // 3. Fevereiro (caso único)
            else if (mes == "fevereiro" || mes == "02" || mes == "2")
            {
                MessageBox.Show("Este mês tem 28 ou 29 dias.");
            }
            // 4. Meses com 30 dias
            else if (mes == "abril" || mes == "04" || mes == "4" ||
                     mes == "junho" || mes == "06" || mes == "6" ||
                     mes == "setembro" || mes == "09" || mes == "9" ||
                     mes == "novembro" || mes == "11")
            {
                MessageBox.Show("Este mês tem 30 dias.");
            }
            else
            {
                MessageBox.Show("Mês não reconhecido. Verifique se escreveu em minúsculo.");
            }
        }


        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            // 1. Pega o nome do aluno
            string nome = txtCampo4.Text;

            // 2. Pega os valores das três notas no txtCampo 1, 2 e 3
            double n1 = double.Parse(txtCampo1.Text);
            double n2 = double.Parse(txtCampo2.Text);
            double n3 = double.Parse(txtCampo3.Text);

            // 3. Calcula a média do aluno 
            double media = (n1 + n2 + n3) / 3;

            // 4. Verifica se está aprovado ou reprovado aluno(a)
            if (media >= 7)
            {
                MessageBox.Show("O aluno " + nome + " está APROVADO com média " + media);
            }
            else
            {
                MessageBox.Show("O aluno " + nome + " está REPROVADO com média " + media);
            }
        }

        private void btnCalcularAumento_Click(object sender, EventArgs e)
        {
            // 1. Pega o salário atual do campo de texto
            double salario = double.Parse(txtCampo1.Text);
            double novoSalario;

            // 2. Aplica as regras de aumento
            if (salario < 1000)
            {
                // 20% de aumento
                novoSalario = salario * 1.20;
            }
            else if (salario >= 1000 && salario <= 2000)
            {
                // 15% de aumento
                novoSalario = salario * 1.15;
            }
            else
            {
                // 10% de aumento (acima de 2000)
                novoSalario = salario * 1.10;
            }

            // 3. Exibe o resultado final
            MessageBox.Show("O novo salário com aumento é: R$ " + novoSalario);
        }
    }
}
