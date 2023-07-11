namespace Pedra_Papel_Tesoura_3
{
    public partial class Form1 : Form
    {
        private string escolhaUsuario;
        private string escolhaMaquina;
        private string[] opcoes =
        {
            "PEDRA",
            "PAPEL",
            "TESOURA"
        };
        private int pontosUsuario, pontosMaquina;
        public Form1()
        {
            InitializeComponent();
        }

        private void SalvaSelecao(string selecao)
        {
            escolhaUsuario = selecao;
            textBox2.Text = escolhaUsuario;
            GerandoSelecaodoComput();
            Comparacao();


        }

        private void GerandoSelecaodoComput()
        {
            //Criando uma função que exiba os valores da array de forma aleatoria
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);
            escolhaMaquina = opcoes[sorteio];
            textBox1.Text = escolhaMaquina;
        }

        public void Comparacao()
        {
            //verificando se ambos fizeram a mesma escolha
            if(escolhaUsuario == escolhaMaquina)
            {
                //exibindo a mensagem de empate
                lblresultado.Text = "Empate";
            }
            //verificando as escolhas, onde a máquina perde
            else if ((escolhaUsuario == "TESOURA" && escolhaMaquina == "PAPEL") || (escolhaUsuario == "PEDRA" && escolhaMaquina == "TESOURA") || (escolhaUsuario == "PAPEL" && escolhaMaquina == "PEDRA"))
            {
                //criando a pontuação do usuário
                pontosUsuario++;
                //exibindo o resultado 
                lblresultado.Text = " Você ganhou ";

            }
            else
            {
                //criando a pontuação da máquina
                pontosMaquina++;
                //exibindo o resultado 
                lblresultado.Text = " Máquina ganhou ";
            }
            // exibindo os pontos 
            textBox3.Text = pontosUsuario.ToString();
            textBox4.Text = pontosMaquina.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[2]);
        }
    }
}