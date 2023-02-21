using System.Drawing;
using System.Drawing.Printing;

namespace Controle_de_restaurante
{
    public partial class Form1 : Form
    {
        public double Subtotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subtotal += Convert.ToDouble(TxtValor.Text);
            TxtSubtotal.Text = Subtotal.ToString();

            string TextoNota = "Buffet a KG    1    " + Convert.ToDouble(TxtValor.Text).ToString("N2");
            AddToNota(TextoNota);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        public void CalculaTotal()
        {
            if (TxtSubtotal.Text == "") { TxtSubtotal.Text = "0"; }
            if (TxtDesconto.Text == "") { TxtDesconto.Text = "0"; }
            double x = Convert.ToDouble(TxtSubtotal.Text);
            double y = Convert.ToDouble(TxtDesconto.Text);
            TxtTotal.Text = (x - y).ToString();
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValorProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtPesagem.Text = TxtTara.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtDesconto.Text = "";
            TxtSubtotal.Text = "";
        }

        private void TxtPesagem_TextChanged(object sender, EventArgs e)
        {
            //Calculo da pesagem final
            if (TxtTara.Text == "") { TxtTara.Text = "0"; }
            if (TxtPesagem.Text == "") { TxtPesagem.Text = "0"; }
            double x = Convert.ToDouble(TxtTara.Text);
            double y = Convert.ToDouble(TxtPesagem.Text);
            double z = y - x;
            TxtPesagemFinal.Text = z.ToString();
            //Calculo do preço
            if (TxtPrecoKG.Text == "") { TxtPrecoKG.Text = "0"; }
            double w = Convert.ToDouble(TxtPrecoKG.Text);
            TxtValor.Text = ((w/1000)*(z*10)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Exibe um prompt com um campo de entrada de texto para o usuário
            string input = Microsoft.VisualBasic.Interaction.InputBox("Compra efetuada no valor de R$" + TxtTotal.Text + ". Qual foi o valor recebido?", "Compra Efetuada!", "");

            // Verifica se o usuário pressionou o botão OK ou Cancelar
            if (input == "")
            {
                MessageBox.Show("Opções de troco cancelada!");
            }
            else
            {
                MessageBox.Show("O valor de Troco é R$" + (Convert.ToDouble(input) - Convert.ToDouble(TxtTotal.Text)));
            }

            DialogResult result = MessageBox.Show("Imprimir Nota?", "Nota Fiscal", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ImprimirNota();
            }
            else
            {
                // O usuário clicou em "não"
                // Faça algo aqui
            }
            
            
        }

        public void ImprimirNota()
        {
            string texto = textBox1.Text;

            StreamWriter esc_texto = new StreamWriter(@"C:\notas\NotaFiscal.txt");

            esc_texto.Write(texto);

            esc_texto.Close();




            // Carrega o arquivo de texto
            string filePath = @"C:\notas\NotaFiscal.txt";
            string textToPrint = System.IO.File.ReadAllText(filePath);

            // Cria uma instância da classe PrintDocument
            PrintDocument pd = new PrintDocument();

            // Define o evento PrintPage para imprimir o conteúdo do arquivo
            pd.PrintPage += (sender, args) =>
            {
                Font font = new Font("Courier New", 10);
                args.Graphics.DrawString(textToPrint, font, Brushes.Black, new PointF(0, 0));
            };

            // Imprime o documento na impressora padrão
            pd.Print();
        }

        public void AddToNota(string TextoAdicional)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine + TextoAdicional;
        }
    }
}