namespace JogoFigurasGeometricas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Errou = new System.Windows.Forms.Label();
            this.lbl_Acertou = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.tmr_Contagem = new System.Windows.Forms.Timer(this.components);
            this.tmr_Transicao = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Orientacao = new System.Windows.Forms.Button();
            this.lbl_Circulo = new System.Windows.Forms.Label();
            this.lbl_Triangulo = new System.Windows.Forms.Label();
            this.lbl_Quadrado = new System.Windows.Forms.Label();
            this.lbl_Retangulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbx_retangulo = new System.Windows.Forms.PictureBox();
            this.pbx_quadrado = new System.Windows.Forms.PictureBox();
            this.pbx_triangulo = new System.Windows.Forms.PictureBox();
            this.pbx_circulo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbx_Barra = new System.Windows.Forms.PictureBox();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.pbx_Imagem = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_retangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_quadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_triangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_circulo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Errou
            // 
            this.lbl_Errou.AutoSize = true;
            this.lbl_Errou.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Errou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.lbl_Errou.Location = new System.Drawing.Point(132, 58);
            this.lbl_Errou.Name = "lbl_Errou";
            this.lbl_Errou.Size = new System.Drawing.Size(26, 30);
            this.lbl_Errou.TabIndex = 11;
            this.lbl_Errou.Text = "0";
            // 
            // lbl_Acertou
            // 
            this.lbl_Acertou.AutoSize = true;
            this.lbl_Acertou.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Acertou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.lbl_Acertou.Location = new System.Drawing.Point(132, 15);
            this.lbl_Acertou.Name = "lbl_Acertou";
            this.lbl_Acertou.Size = new System.Drawing.Size(26, 30);
            this.lbl_Acertou.TabIndex = 10;
            this.lbl_Acertou.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Errou: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Acertou: ";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(462, 486);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(188, 100);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "Limpar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(313, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Escolha:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btn_0);
            this.flowLayoutPanel1.Controls.Add(this.btn_1);
            this.flowLayoutPanel1.Controls.Add(this.btn_2);
            this.flowLayoutPanel1.Controls.Add(this.btn_3);
            this.flowLayoutPanel1.Controls.Add(this.btn_4);
            this.flowLayoutPanel1.Controls.Add(this.btn_5);
            this.flowLayoutPanel1.Controls.Add(this.btn_6);
            this.flowLayoutPanel1.Controls.Add(this.btn_7);
            this.flowLayoutPanel1.Controls.Add(this.btn_8);
            this.flowLayoutPanel1.Controls.Add(this.btn_9);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(318, 306);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 117);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_0.Location = new System.Drawing.Point(10, 6);
            this.btn_0.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(46, 43);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(233)))), ((int)(((byte)(108)))));
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_1.Location = new System.Drawing.Point(76, 6);
            this.btn_1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(46, 43);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(96)))));
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_2.Location = new System.Drawing.Point(142, 6);
            this.btn_2.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(46, 43);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_3.Location = new System.Drawing.Point(208, 6);
            this.btn_3.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(46, 43);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_4.Location = new System.Drawing.Point(274, 6);
            this.btn_4.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(46, 43);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_5.Location = new System.Drawing.Point(10, 61);
            this.btn_5.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(46, 43);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(233)))), ((int)(((byte)(108)))));
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_6.Location = new System.Drawing.Point(76, 61);
            this.btn_6.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(46, 43);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(96)))));
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_7.Location = new System.Drawing.Point(142, 61);
            this.btn_7.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(46, 43);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(96)))));
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_8.Location = new System.Drawing.Point(208, 61);
            this.btn_8.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(46, 43);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.btn_9.Location = new System.Drawing.Point(274, 61);
            this.btn_9.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(46, 43);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tempo.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tempo.Location = new System.Drawing.Point(594, 446);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(44, 24);
            this.lbl_Tempo.TabIndex = 14;
            this.lbl_Tempo.Text = "20 s";
            // 
            // tmr_Contagem
            // 
            this.tmr_Contagem.Enabled = true;
            this.tmr_Contagem.Interval = 1000;
            this.tmr_Contagem.Tick += new System.EventHandler(this.tmr_Contagem_Tick);
            // 
            // tmr_Transicao
            // 
            this.tmr_Transicao.Enabled = true;
            this.tmr_Transicao.Tick += new System.EventHandler(this.tmr_Transicao_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(89)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 47);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(546, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Antonio Coelho - 242883";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(546, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Enzo Calvo - 242890";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jogo das Figuras Geométricas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(81)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORIENTAÇÃO: Observe a figura abaixo e conte os circulos, triângulos, quadrados\r\n " +
    "e retângulos na imagem\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Orientacao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 75);
            this.panel2.TabIndex = 16;
            // 
            // btn_Orientacao
            // 
            this.btn_Orientacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Orientacao.BackgroundImage")));
            this.btn_Orientacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Orientacao.Location = new System.Drawing.Point(12, 11);
            this.btn_Orientacao.Name = "btn_Orientacao";
            this.btn_Orientacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Orientacao.Size = new System.Drawing.Size(31, 28);
            this.btn_Orientacao.TabIndex = 2;
            this.btn_Orientacao.UseVisualStyleBackColor = true;
            this.btn_Orientacao.Click += new System.EventHandler(this.btn_Orientacao_Click);
            // 
            // lbl_Circulo
            // 
            this.lbl_Circulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Circulo.Location = new System.Drawing.Point(4, 63);
            this.lbl_Circulo.Name = "lbl_Circulo";
            this.lbl_Circulo.Size = new System.Drawing.Size(69, 61);
            this.lbl_Circulo.TabIndex = 12;
            this.lbl_Circulo.Text = "0";
            this.lbl_Circulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Triangulo
            // 
            this.lbl_Triangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Triangulo.Location = new System.Drawing.Point(80, 63);
            this.lbl_Triangulo.Name = "lbl_Triangulo";
            this.lbl_Triangulo.Size = new System.Drawing.Size(72, 61);
            this.lbl_Triangulo.TabIndex = 13;
            this.lbl_Triangulo.Text = "0";
            this.lbl_Triangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Quadrado
            // 
            this.lbl_Quadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quadrado.Location = new System.Drawing.Point(159, 63);
            this.lbl_Quadrado.Name = "lbl_Quadrado";
            this.lbl_Quadrado.Size = new System.Drawing.Size(75, 61);
            this.lbl_Quadrado.TabIndex = 14;
            this.lbl_Quadrado.Text = "0";
            this.lbl_Quadrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Retangulo
            // 
            this.lbl_Retangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Retangulo.Location = new System.Drawing.Point(241, 63);
            this.lbl_Retangulo.Name = "lbl_Retangulo";
            this.lbl_Retangulo.Size = new System.Drawing.Size(77, 61);
            this.lbl_Retangulo.TabIndex = 15;
            this.lbl_Retangulo.Text = "0";
            this.lbl_Retangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(177)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.07975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.92025F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Retangulo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Quadrado, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Triangulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbx_retangulo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbx_quadrado, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbx_triangulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbx_circulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Circulo, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 125);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pbx_retangulo
            // 
            this.pbx_retangulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_retangulo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_retangulo.Image")));
            this.pbx_retangulo.Location = new System.Drawing.Point(245, 4);
            this.pbx_retangulo.Name = "pbx_retangulo";
            this.pbx_retangulo.Size = new System.Drawing.Size(77, 55);
            this.pbx_retangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_retangulo.TabIndex = 3;
            this.pbx_retangulo.TabStop = false;
            // 
            // pbx_quadrado
            // 
            this.pbx_quadrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_quadrado.Image = ((System.Drawing.Image)(resources.GetObject("pbx_quadrado.Image")));
            this.pbx_quadrado.Location = new System.Drawing.Point(159, 4);
            this.pbx_quadrado.Name = "pbx_quadrado";
            this.pbx_quadrado.Size = new System.Drawing.Size(75, 55);
            this.pbx_quadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_quadrado.TabIndex = 2;
            this.pbx_quadrado.TabStop = false;
            // 
            // pbx_triangulo
            // 
            this.pbx_triangulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_triangulo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_triangulo.Image")));
            this.pbx_triangulo.Location = new System.Drawing.Point(80, 4);
            this.pbx_triangulo.Name = "pbx_triangulo";
            this.pbx_triangulo.Size = new System.Drawing.Size(72, 55);
            this.pbx_triangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_triangulo.TabIndex = 1;
            this.pbx_triangulo.TabStop = false;
            // 
            // pbx_circulo
            // 
            this.pbx_circulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_circulo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_circulo.Image")));
            this.pbx_circulo.Location = new System.Drawing.Point(4, 4);
            this.pbx_circulo.Name = "pbx_circulo";
            this.pbx_circulo.Size = new System.Drawing.Size(69, 55);
            this.pbx_circulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_circulo.TabIndex = 0;
            this.pbx_circulo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            this.panel3.Controls.Add(this.lbl_Errou);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_Acertou);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(23, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 17;
            // 
            // pbx_Barra
            // 
            this.pbx_Barra.Image = global::JogoFigurasGeometricas.Properties.Resources.barra20;
            this.pbx_Barra.Location = new System.Drawing.Point(14, 439);
            this.pbx_Barra.Name = "pbx_Barra";
            this.pbx_Barra.Size = new System.Drawing.Size(579, 35);
            this.pbx_Barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Barra.TabIndex = 18;
            this.pbx_Barra.TabStop = false;
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.btn_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reiniciar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.ForeColor = System.Drawing.Color.White;
            this.btn_Reiniciar.Image = global::JogoFigurasGeometricas.Properties.Resources.iconeReiniciar;
            this.btn_Reiniciar.Location = new System.Drawing.Point(248, 486);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(188, 100);
            this.btn_Reiniciar.TabIndex = 6;
            this.btn_Reiniciar.Text = "Reiniciar";
            this.btn_Reiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reiniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reiniciar.UseVisualStyleBackColor = false;
            this.btn_Reiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // pbx_Imagem
            // 
            this.pbx_Imagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbx_Imagem.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Imagem.Image")));
            this.pbx_Imagem.Location = new System.Drawing.Point(14, 126);
            this.pbx_Imagem.Name = "pbx_Imagem";
            this.pbx_Imagem.Size = new System.Drawing.Size(275, 301);
            this.pbx_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Imagem.TabIndex = 0;
            this.pbx_Imagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(673, 595);
            this.Controls.Add(this.pbx_Barra);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbx_Imagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Jogo Figuras Geométricas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_retangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_quadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_triangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_circulo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Imagem;
        private System.Windows.Forms.PictureBox pbx_circulo;
        private System.Windows.Forms.PictureBox pbx_retangulo;
        private System.Windows.Forms.PictureBox pbx_quadrado;
        private System.Windows.Forms.PictureBox pbx_triangulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Errou;
        private System.Windows.Forms.Label lbl_Acertou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.Timer tmr_Contagem;
        private System.Windows.Forms.Timer tmr_Transicao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Orientacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Circulo;
        private System.Windows.Forms.Label lbl_Triangulo;
        private System.Windows.Forms.Label lbl_Quadrado;
        private System.Windows.Forms.Label lbl_Retangulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbx_Barra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

