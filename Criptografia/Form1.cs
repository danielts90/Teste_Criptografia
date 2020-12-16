using Criptografia.Algoritimos;
using Criptografia.Extensao;
using System;
using System.Windows.Forms;

namespace Criptografia
{
    /// <summary>
    /// POC para avaliar o uso de algoritmo de criptografia AES. 
    /// o uso do algoritmo consistem na utlização de uma key e um IV. 
    /// a Key é a chave utilizada para decifrar as mensagens, 
    /// o IV é usado para diferenciar as mensagens, sendo que o IV não precisa ser secreto e 
    /// o seu uso impossibilita que os blocos sejam cifrados de maneira igual. 
    /// 
    /// O IV está sendo armazenado concatenado com o texto criptografado. 
    /// </summary>
    public partial class Form1 : Form
    {
        private byte[] msg_criptografada;
        private byte[] iv;
        private AES aes = new AES();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Encriptar_Click(object sender, EventArgs e)
        {
            if(ValidarChave())
            {
                try
                {
                    iv = aes.GerarIV();
                    label3.Text = Convert.ToBase64String(iv);
                    msg_criptografada = aes.EncriptarMensagem(txt_TextoLimpo.Text, txt_chave.Text.ObterStringEmBytes(), iv);
                    txt_cripto.Text = Convert.ToBase64String(msg_criptografada);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao cifrar a mensagem");
                }
            }
        }

        private bool ValidarChave()
        {
            if(txt_chave.Text.Length != 16)
            {
                MessageBox.Show("Chave deve conter 16 caracteres");
                return false;
            }
            return true;
        }

        private void btn_Decriptar_Click(object sender, EventArgs e)
        {
            try
            {
                msg_criptografada = Convert.FromBase64String(txt_cripto.Text);
                txt_decripto.Text = aes.DecriptarMensagem(msg_criptografada, txt_chave.Text.ObterStringEmBytes());
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao decrifrar a mensagem");
            }
            
        }
    }
}
