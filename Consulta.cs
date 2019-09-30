using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestDevell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          if (txtNomeLivro.Text == ""|| txtNumeroLivro.Text == ""|| txtNumeroPagina.Text == ""|| txtNumeroRegistro.Text =="" || txtDataRegistro.Text =="" || txtNomeRegistrado.Text == ""|| txtSexoRegistrado.Text == ""|| txtDataNascimento.Text == ""|| txtHoraNascimento.Text == ""|| txtNomePai.Text == ""|| DataNascimentoPai.Text == ""|| txtCidadeUfPai.Text == ""|| txtNomeMae.Text == ""|| txtDataNascimentoMae.Text == ""|| txtNumeroDnv.Text == ""|| txtRegistronoPrazo.Text == "")
           {
            MessageBox.Show("Caixa de texto vazia!","Cadastro Incompleto,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            txt.NomeLivro.Focus();
            txt.NumeroLivro.Focus();
            txt.NomePagina.Focus();
            txt.NomeRegistro.Focus();
            txt.DataRegistro.Focus();
            txt.NomeRegistrado.Focus();
            txt.SexoRegistrado.Focus();
            txt.DataNascimento.Focus();
            txt.HoraNascimento.Focus();
            txt.NomePai.Focus();
            txt.DataNascimentoPai.Focus();
            txt.CidadeUfPai.Focus();
            txt.NomeMae.Focus();
            txt.DataNascimentoMae.Focus();
            txt.CidadeUfMae.Focus();
            txt.NomeDnv.Focus();
            txt.RegistronoPrazo.Focus();
           }
           else
           {
             Conexao con = new Conexao();
           
           try
           {
             con.conectar();
             
            string sql = "SELECT * FROM CADASTRONASCIMENTO (NOME_DO_LIVRO,NUMERO_DO_LIVRO,NUMERO_DA_PAGINA,NUMERO_DO_REGISTRO,DATA_DE_REGISTRO,NOME_DO_REGISTRADO,SEXO_DO_REGISTRADO,DATA_DE_NASCIEMNTO,HORA_DO_NASCIMENTO,NOME_DO_PAI,DATA_DE_NASCIMENTO_PAI,CIDADE_UF_PAI,NOME_DA_MAE,DATA_DE_NASCIMENTO_MAE,CIDADE_UF_MAE,NUMERO_DNV,REGISTRO_NO_PRAZO)
            VALUES ("+txtNomeLivro.Text + ","+txtNumeroLivro.Text + "','"+txtNumeroPagina.Text + "','"+txtNumeroRegistro.Text + "','"+txtDataRegistro.Text + "','"+txtNomeRegistrado.Text + "','"+txtSexoRegistrado.Text + "','"+txtDataNascimento.Text + "','"+txtHoraNascimento.Text + "','"+txtNomePai.Text + "','"+txtDataNascimentoPai.Text + "','"+txtCidadeUfPai.Text + "','"+txtNomeMae.Text + "','"+txtDataNascimentoMae.Text + "','"+txtCidadeUfMae.Text + "','"+txtNumeroDnv.Text + "','"+txtRegistronoPrazo.Text + "') 
           

            SQliteDataAdapter dados = new SQliteDataAdapter (sql, con.conn);
            DataTable usuario = new DataTable();
            comando.Fill(CADASTRONASCIMENTO);
            

            con.desconectar();
         }
         catch (Exception E)
         {
              MessageBox.Show(E.Message.ToString(),"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
              Application.Exit();
        
         }      
    
    } 
  } 
