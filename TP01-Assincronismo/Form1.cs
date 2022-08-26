using System.Diagnostics;

namespace TP01_Assincronismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            button1.Enabled = false;
            await FolhaDePagamento();
            await Impostos();
            await Receitas();
            await Despesas();
            stopwatch.Stop();
            listBox1.Text = $"Tempo total: {stopwatch.Elapsed.Seconds} s";
            button1.Enabled = true;

        }
     

        private async Task FolhaDePagamento()
        {
            listBox1.Text = "Calculando Folha, aguarde um momento...";
            await Task.Delay(TimeSpan.FromSeconds(3));
            listBox1.Text = "Folha de Pagamento Calculada.";
        }
        private async Task Impostos()
        {
            listBox1.Text = "Calculando Imposto, aguarde um momento...";
            await Task.Delay(TimeSpan.FromSeconds(2));
            listBox1.Text = "Imposto Calculado.";
        }
        private async Task Receitas()
        {
            listBox1.Text = "Calculando Receita, aguarde um momento...";
            await Task.Delay(TimeSpan.FromSeconds(1));
            listBox1.Text = "Receita Calculada";
        }
        private async Task Despesas()
        {
            listBox1.Text = "Calculando Despesa, aguarde um momento...";
            await Task.Delay(TimeSpan.FromSeconds(3));
            listBox1.Text = "Despesas Calculadas";
        }
    }
}