using Criptografia.Algoritimos;
using Criptografia.Extensao;
using System;
using System.Linq;
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
        private const int TAMANHO_CHAVE = 16;
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
            if(txt_chave.Text.Length != TAMANHO_CHAVE)
            {
                MessageBox.Show($"Chave deve conter {TAMANHO_CHAVE} caracteres");
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

        private void btn_chaveAleatoria_Click(object sender, EventArgs e)
        {
            var caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%¨&*()_+";
            var random = new Random();
            var chavealeatoria = new string(
                Enumerable.Repeat(caracteres, TAMANHO_CHAVE)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
           txt_chave.Text =  chavealeatoria;
        }
    }
}
