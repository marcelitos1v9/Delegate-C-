namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void operacao (int n1, int n2);
        
        matematica m=new matematica();
        private void btn_exe_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_n1.Text);
            int n2 = Convert.ToInt32(txt_n2.Text);

            operacao calcular = null;

            calcular += m.somar;

            listBox1.Items.Clear();
            listBox1.Items.Add("ultilizando variavel do tipo delegate");
            listBox1.Items.Add(" ");
            listBox1.Items.Add("Exemplo 01 - Atribuindo 1 metodo do tipo delegate");

            calcular(n1, n2);

            listBox1.Items.Add(m.mensagemsoma);
            listBox1.Items.Add(m.mensagemsubtracao);
            listBox1.Items.Add(m.mensagemmultiplicacao);
            listBox1.Items.Add(m.mensagemdivisao);

            m.mensagemsoma = " ";
            m.mensagemsubtracao = " ";
            m.mensagemmultiplicacao = " ";
            m.mensagemdivisao = " ";

            listBox1.Items.Add("-------------------------------------------------------------------");
            listBox1.Items.Add("Exemplo 02 - Atribuindo todos metodos do tipo delegate");

            calcular += m.somar;
            calcular += m.subtrair;
            calcular += m.multiplicar;
            calcular += m.dividir;

            calcular(n1, n2);

            listBox1.Items.Add(m.mensagemsoma);
            listBox1.Items.Add(m.mensagemsubtracao);
            listBox1.Items.Add(m.mensagemmultiplicacao);
            listBox1.Items.Add(m.mensagemdivisao);

            m.mensagemsoma = " ";
            m.mensagemsubtracao = " ";
            m.mensagemmultiplicacao = " ";
            m.mensagemdivisao = " ";

            listBox1.Items.Add("-------------------------------------------------------------------");
            listBox1.Items.Add("Exemplo 03 - removendo metodos do tipo delegate e duplicando outros");

            calcular += m.somar;
            calcular += m.subtrair;
            calcular -= m.multiplicar;
            calcular -= m.dividir;
            calcular += m.somar;

            calcular(n1, n2);

            listBox1.Items.Add(m.mensagemsoma);
            listBox1.Items.Add(m.mensagemsubtracao);
            listBox1.Items.Add(m.mensagemmultiplicacao);
            listBox1.Items.Add(m.mensagemdivisao);
            listBox1.Items.Add(m.mensagemsoma);

            m.mensagemsoma = " ";
            m.mensagemsubtracao = " ";
            m.mensagemmultiplicacao = " ";
            m.mensagemdivisao = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}