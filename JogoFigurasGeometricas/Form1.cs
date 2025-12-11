using JogoFigurasGeometricas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoFigurasGeometricas
{
    public partial class Form1 : Form
    {
        #region Váriaveis Globais
        private List<ImagemDesafio> desafios;
        private List<ImagemDesafio> desafiosOriginais;
        private Random sorteio = new Random();
        private ImagemDesafio imagemAtual;

        private int tempoRestante = 20;
        private int acertos = 0;
        private int erros = 0;
        private int total = 0;
        private int indicePreenchimento = 0;
        private int respCirculo = -1;
        private int respTriangulo = -1;
        private int respQuadrado = -1;
        private int respRetangulo = -1;
        #endregion

        public Form1()
        {
            InitializeComponent();            
        }

        #region LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDesafios();
            SortearImagem();
        }
        #endregion

        #region Cria a lista com as imagens
        private void CarregarDesafios()
        {
            desafiosOriginais = new List<ImagemDesafio>
            {
                new ImagemDesafio("Imagens/img1.png", 3, 4, 1, 1),
                new ImagemDesafio("Imagens/img2.png", 4, 5, 1, 1),
                new ImagemDesafio("Imagens/img3.png", 3, 5, 2, 5),
                new ImagemDesafio("Imagens/img4.png", 7, 3, 2, 3),
                new ImagemDesafio("Imagens/img5.png", 6, 0, 0, 2),
                new ImagemDesafio("Imagens/img6.png", 2, 2, 4, 2),
                new ImagemDesafio("Imagens/img7.png", 3, 1, 1, 1),
                new ImagemDesafio("Imagens/img8.png", 0, 3, 5, 1),
                new ImagemDesafio("Imagens/img9.png", 3, 3, 5, 8),
                new ImagemDesafio("Imagens/img10.png", 1, 2, 0, 5),
                new ImagemDesafio("Imagens/img11.png", 3, 4, 4, 0),
                new ImagemDesafio("Imagens/img12.png", 4, 2, 2, 2),
                new ImagemDesafio("Imagens/img13.png", 2, 3, 2, 2),
                new ImagemDesafio("Imagens/img14.png", 8, 2, 2, 4),
                new ImagemDesafio("Imagens/img15.png", 2, 5, 4, 8),
                new ImagemDesafio("Imagens/img16.png", 7, 2, 2, 5),
                new ImagemDesafio("Imagens/img17.png", 1, 8, 0, 0),
                new ImagemDesafio("Imagens/img18.png", 3, 1, 5, 1),
                new ImagemDesafio("Imagens/img19.png", 5, 2, 2, 5),
                new ImagemDesafio("Imagens/img20.png", 5, 1, 4, 0),
            };
            desafios = new List<ImagemDesafio>(desafiosOriginais);
        }
        #endregion

        #region Sorteia a imagem
        private void SortearImagem()
        {
            if (desafios.Count == 0)
            {
                total = Convert.ToInt16(acertos) + Convert.ToInt16(erros);
                string caminho = "Sons/Vitoria.wav";
                if (System.IO.File.Exists(caminho))
                {

                    using (SoundPlayer sp = new SoundPlayer(caminho))
                    {
                        sp.Play();
                    }
                }
                MessageBox.Show("🎉 Parabéns! Você completou todas as imagens!\n\nPLACAR FINAL:\nNúmero total de tentativas: " + Convert.ToString(total) + 
                    "\nQuantidade de acertos: " + Convert.ToString(acertos) + "\nQuantidade de erros: " + Convert.ToString(erros));
                tmr_Contagem.Stop();
                Reiniciar();
            }

            int indice = sorteio.Next(desafios.Count);
            imagemAtual = desafios[indice];
            pbx_Imagem.Image = Image.FromFile(imagemAtual.CaminhoImagem);

            AtualizarCamposSelecionados();
            indicePreenchimento = 0;
            tmr_Contagem.Start();
        }
        #endregion

        #region Timer Tempo
        private void tmr_Contagem_Tick(object sender, EventArgs e)
        {
            pbx_Barra.Image = Image.FromFile("Imagens/barra" + Convert.ToString(tempoRestante) + ".png");
            tempoRestante--;
            lbl_Tempo.Text = tempoRestante + " s";

            if (tempoRestante <= 0)
            {
                tmr_Contagem.Stop();
                VerificarResposta();
                respCirculo = -1;
                AtualizarCamposSelecionados();
            }
        }
        #endregion

        #region Timer Transição
        private void tmr_Transicao_Tick(object sender, EventArgs e)
        {
            tmr_Transicao.Stop();
            SortearImagem();
        }
        #endregion

        #region Botões Números
        private void BtnNumero_Click(object sender, EventArgs e)
        {
            if (!(sender is Button botao)) return;
            if (!int.TryParse(botao.Text, out int valor)) return;

            switch (indicePreenchimento)
            {
                case 0:
                    respCirculo = valor;
                    break;
                case 1:
                    respTriangulo = valor;
                    break;
                case 2:
                    respQuadrado = valor;
                    break;
                case 3:
                    respRetangulo = valor;
                    break;
            }


            indicePreenchimento++;

            AtualizarCamposSelecionados();
            if (indicePreenchimento > 3)
            {
                tmr_Contagem.Stop();
                VerificarResposta();
            }
        }
        #endregion

        #region Atualizar Campos Selecionados
        private void AtualizarCamposSelecionados()
        {
            lbl_Circulo.Text = respCirculo >= 0 ? respCirculo.ToString() : "";
            lbl_Triangulo.Text = respTriangulo >= 0 ? respTriangulo.ToString() : "";
            lbl_Quadrado.Text = respQuadrado >= 0 ? respQuadrado.ToString() : "";
            lbl_Retangulo.Text = respRetangulo >= 0 ? respRetangulo.ToString() : "";

            lbl_Circulo.BackColor = indicePreenchimento == 0 ? Color.LightGreen : SystemColors.Control;
            pbx_circulo.BackColor = indicePreenchimento == 0 ? Color.LightGreen : SystemColors.Control;
            lbl_Triangulo.BackColor = indicePreenchimento == 1 ? Color.LightGreen : SystemColors.Control;
            pbx_triangulo.BackColor = indicePreenchimento == 1 ? Color.LightGreen : SystemColors.Control;
            lbl_Quadrado.BackColor = indicePreenchimento == 2 ? Color.LightGreen : SystemColors.Control;
            pbx_quadrado.BackColor = indicePreenchimento == 2 ? Color.LightGreen : SystemColors.Control;
            lbl_Retangulo.BackColor = indicePreenchimento == 3 ? Color.LightGreen : SystemColors.Control;
            pbx_retangulo.BackColor = indicePreenchimento == 3 ? Color.LightGreen : SystemColors.Control;

        }
        #endregion

        #region Verificar Resposta
        private void VerificarResposta()
        {
            int circulo = respCirculo >= 0 ? respCirculo : -1;
            int triangulo = respTriangulo >= 0 ? respTriangulo : -1;
            int quadrado = respQuadrado >= 0 ? respQuadrado : -1;
            int retangulo = respRetangulo >= 0 ? respRetangulo : -1;

            bool acertou = (circulo == imagemAtual.Circulos)
                        && (triangulo == imagemAtual.Triangulos)
                        && (quadrado == imagemAtual.Quadrados)
                        && (retangulo == imagemAtual.Retangulos);

            if (acertou)
            {
                acertos++;
                TocarSomFeedback(true);
                MessageBox.Show("Parabéns! Você acertou ✅");
                desafios.Remove(imagemAtual);
            }
            else
            {
                erros++;
                TocarSomFeedback(false);

                string solucao =
                $"🔵 Círculos: {imagemAtual.Circulos}\n" +
                $"🔺 Triângulos: {imagemAtual.Triangulos}\n" +
                $"🟩 Quadrados: {imagemAtual.Quadrados}\n" +
                $"🟥 Retângulos: {imagemAtual.Retangulos}";

                MessageBox.Show(
                    "❌ Ops! Não foi dessa vez!\n\n" +
                    "Vamos ver a resposta correta:\n\n" + solucao +
                    "\n\nTente novamente!",
                    "Tente outra vez!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            AtualizarPlacar();
            respCirculo = -1;
            respTriangulo = -1;
            respQuadrado = -1;
            respRetangulo = -1;
            indicePreenchimento = 0;
            AtualizarCamposSelecionados();
            tmr_Transicao.Start();
            tempoRestante = 20;
        }
        #endregion

        #region Atualizar Placar
        private void AtualizarPlacar()
        {
            if (acertos > 0)
            {
                lbl_Acertou.ForeColor = Color.Green;
            }
            else lbl_Acertou.ForeColor = Color.FromArgb(29, 81, 127);

            if (erros > 0)
            {
                lbl_Errou.ForeColor = Color.Red;
            }
            else lbl_Errou.ForeColor = Color.FromArgb(29, 81, 127);

            lbl_Acertou.Text = acertos.ToString();
            lbl_Errou.Text = erros.ToString();
        }
        #endregion

        #region Botão Orientação
        private void btn_Orientacao_Click(object sender, EventArgs e)
        {
            string caminho = "Sons/Orientacao.wav";
            if (System.IO.File.Exists(caminho))
            {
                try
                {
                    using (SoundPlayer sp = new SoundPlayer(caminho))
                    {
                        sp.Play();
                    }
                }
                catch { MessageBox.Show("Erro ao tocar som"); }
            }
        }
        #endregion

        #region Som de Feedback
        private void TocarSomFeedback(bool sucesso)
        {
            string relative = sucesso ? "Sons/Sucesso.wav" : "Sons/Erro.wav";
            string caminho = (relative);

            if (System.IO.File.Exists(caminho))
            {
                try
                {
                    using (SoundPlayer sp = new SoundPlayer(caminho))
                    {
                        sp.Play();
                    }
                }
                catch { MessageBox.Show("Erro ao tocar som"); }
            }
        }
        #endregion

        #region Botão e Função Reiniciar 
        private void Reiniciar()
        {
            desafios = new List<ImagemDesafio>(desafiosOriginais);
            string caminho = "Sons/Reiniciar.wav";
            respCirculo = respTriangulo = respQuadrado = respRetangulo = -1;
            indicePreenchimento = 0;
            acertos = erros = 0;
            tempoRestante = 20;
            AtualizarCamposSelecionados();
            AtualizarPlacar();
            SortearImagem();
           

            if (System.IO.File.Exists(caminho))
            {

                using (SoundPlayer sp = new SoundPlayer(caminho))
                {
                    sp.Play();
                }
            }
        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
        #endregion

        #region Botão Voltar
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            if (indicePreenchimento == 1)
            {
                respCirculo = -1;
                indicePreenchimento--;
            }
            else if (indicePreenchimento == 2)
            {
                respTriangulo = -1;
                indicePreenchimento--;
            }
            else if (indicePreenchimento == 3)
            {
                respQuadrado = -1;
                indicePreenchimento--;
            }

            AtualizarCamposSelecionados();         
        }
        #endregion

        #region Sair
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Lixeira
        private void btn_0_Click(object sender, EventArgs e)
        {
            BtnNumero_Click(sender, e);
        }
        #endregion

    }
}
