using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ManipulandoBotoes
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void Frm_Mascara_Load(object sender, EventArgs e)
        {
        }

        public enum informacao
        {
            cep,
            hora,
            moeda,
            data,
            telefone,
            senha
        }

        private informacao tipoSelecionado;

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            tipoSelecionado = informacao.hora;
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            tipoSelecionado = informacao.moeda;
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "$ 000,000,000.00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.Yes;
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            tipoSelecionado = informacao.data;
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            tipoSelecionado = informacao.telefone;
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.Yes;
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            tipoSelecionado = informacao.cep;
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            tipoSelecionado = informacao.senha;
            Msk_TextBox.UseSystemPasswordChar = true;
            Msk_TextBox.Mask = "";
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();

            Lbl_MascaraAtiva.Text = "Senha";
            Lbl_Conteudo.Text = "";
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            switch (tipoSelecionado)
            {
                case informacao.hora:
                    if (!DateTime.TryParseExact(Msk_TextBox.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    {
                        MessageBox.Show("Insira um horário válido no formato HH:mm.", "Horário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Msk_TextBox.Focus();
                    }
                    else
                    {
                        Lbl_Conteudo.Text = Msk_TextBox.Text;
                    }
                    break;

                case informacao.cep:
                case informacao.data:
                    if (!DateTime.TryParseExact(Msk_TextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    {
                        MessageBox.Show("Insira uma data válida no formato dd/MM/yyyy.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Msk_TextBox.Focus();
                    }
                    else
                    {
                        Lbl_Conteudo.Text = Msk_TextBox.Text;
                    }
                    break;    

                case informacao.senha:
                    string senha = Msk_TextBox.Text;

                    bool temMaiuscula = senha.Any(char.IsUpper);
                    bool temMinuscula = senha.Any(char.IsLower);
                    bool temNumero = senha.Any(char.IsDigit);
                    bool temSimbolo = senha.Any(ch => !char.IsLetterOrDigit(ch));

                    if (temMaiuscula && temMinuscula && temNumero && temSimbolo && senha.Length >= 8)
                    {
                        MessageBox.Show("Senha Válida", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Senha Inválida. Info incompleta.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case informacao.telefone:
                case informacao.moeda:
                    Lbl_Conteudo.Text = Msk_TextBox.Text;
                    break;

                default:
                    MessageBox.Show("Tipo não suportado.");
                    break;
            }
        }

    }
}
