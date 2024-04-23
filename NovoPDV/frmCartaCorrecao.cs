using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoPDV
{
    public partial class frmCartaCorrecao : Form
    {
        public frmCartaCorrecao()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja prosseguinte com o envio da Carta de Correção ?","Veti PDV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Carta de Correção enviada com sucesso !", "Veti PDV");
            }
        }

        private void FormCartaCorrecao_Load(object sender, EventArgs e)
        {
            //Apresentando mensagem de orientações sobre Carta de Correção. Comando \r\n realiza quebra de linha
            MessageBox.Show("                       Informações Importantes sobre Carta de Correção !" +
                "\r\n" +
                "\r\n" +
                "\r\n" +
                "                   Segue orientações em seu preenchimento:" +
                "\r\n" +
                "\r\n- Descrição clara e objetiva." +
                "\r\n- Preencher no mínimo 15 caracteres e no máximo 1000 caracteres." +
                "\r\n- Não é permitido acentos ou caracteres especiais como:" +
                "\r\n" +
                "\r\n" +
                "\r\n                        @  ,    #  ,    $  ,    ^  ,    &  ,    ´  ,    '  ,   entre outros !" +
                "\r\n" +
                "\r\n" +
                "\r\n" +
                "                   Segue abaixo alguns exemplos sobre o que pode ser escrito na Carta de Correção:" +
                "\r\n" +
                "\r\n" +
                "\r\n- Ajustado o numero de volumes de 18 para 20." +
                "\r\n- Transportadora alterada de Transportadora ABC LTDA para Transportadora XYZ LTDA." +
                "\r\n- Alterado o peso total de 20 para 40 KG." +
                "\r\n" +
                "\r\n" +
                "\r\n" +
                "                   IMPORTANTÍSSIMO: Prazo máximo é de 30 DIAS (720 horas) a contar da data de autorização da Nota Fiscal !" +
                "\r\n" +
                "\r\n" +
                "\r\n O que não pode ser corrigido com a Carta de Correção:" +
                "\r\n" +
                "\r\n- Valores Fiscais que incidam em impostos (Base de Cálculo, Alíquotas, Diferença de Preço, Quantidade, Valor da Operação." +
                "\r\n- Correção de dados cadastrais que implique mudança do remetente ou do destinatário." +
                "\r\n- Descrição da mercadoria que altere as alíquotas de impostos." +
                "\r\n- Destaque de impostos ou quaisquer outros dados que alterem o Cálculo ou a Operação do Imposto." +
                "\r\n- CFOP que incida na alteração de impostos." +
                "\r\n" +
                "\r\n" +
                "\r\nCaso a correção esteja relacionada entre os itens acima, cancele a Nota Fiscal e emita uma nova com os dados devidamente preenchidos !" +
                "\r\n", "Veti PDV");

        }
    }
}
