namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonVirgula = new Button();
            buttonIgual = new Button();
            buttonMais = new Button();
            buttonDividir = new Button();
            buttonMutiplicar = new Button();
            buttonMenos = new Button();
            buttonClear = new Button();
            labelOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ActiveCaptionText;
            txtResultado.ForeColor = SystemColors.Info;
            txtResultado.Location = new Point(30, 15);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(277, 27);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(103, 238);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(169, 238);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(37, 238);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(169, 172);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(103, 172);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(37, 172);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(37, 106);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaptionText;
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(103, 106);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaptionText;
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(169, 106);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ActiveCaptionText;
            button0.ForeColor = SystemColors.Control;
            button0.Location = new Point(103, 304);
            button0.Name = "button0";
            button0.Size = new Size(60, 60);
            button0.TabIndex = 10;
            button0.Text = "0\r\n";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonVirgula
            // 
            buttonVirgula.BackColor = SystemColors.ActiveCaptionText;
            buttonVirgula.ForeColor = SystemColors.Control;
            buttonVirgula.Location = new Point(37, 304);
            buttonVirgula.Name = "buttonVirgula";
            buttonVirgula.Size = new Size(60, 60);
            buttonVirgula.TabIndex = 11;
            buttonVirgula.Text = ",";
            buttonVirgula.UseVisualStyleBackColor = false;
            buttonVirgula.Click += buttonVirgula_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.BackColor = SystemColors.ActiveCaptionText;
            buttonIgual.ForeColor = SystemColors.Control;
            buttonIgual.Location = new Point(169, 304);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(60, 60);
            buttonIgual.TabIndex = 12;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = false;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonMais
            // 
            buttonMais.BackColor = SystemColors.ActiveCaptionText;
            buttonMais.ForeColor = SystemColors.Control;
            buttonMais.Location = new Point(235, 304);
            buttonMais.Name = "buttonMais";
            buttonMais.Size = new Size(60, 60);
            buttonMais.TabIndex = 16;
            buttonMais.Text = "+";
            buttonMais.UseVisualStyleBackColor = false;
            buttonMais.Click += buttonMais_Click;
            // 
            // buttonDividir
            // 
            buttonDividir.BackColor = SystemColors.ActiveCaptionText;
            buttonDividir.ForeColor = SystemColors.Control;
            buttonDividir.Location = new Point(235, 106);
            buttonDividir.Name = "buttonDividir";
            buttonDividir.Size = new Size(60, 60);
            buttonDividir.TabIndex = 15;
            buttonDividir.Text = "/";
            buttonDividir.UseVisualStyleBackColor = false;
            buttonDividir.Click += buttonDividir_Click;
            // 
            // buttonMutiplicar
            // 
            buttonMutiplicar.BackColor = SystemColors.ActiveCaptionText;
            buttonMutiplicar.ForeColor = SystemColors.Control;
            buttonMutiplicar.Location = new Point(235, 172);
            buttonMutiplicar.Name = "buttonMutiplicar";
            buttonMutiplicar.Size = new Size(60, 60);
            buttonMutiplicar.TabIndex = 14;
            buttonMutiplicar.Text = "x";
            buttonMutiplicar.UseVisualStyleBackColor = false;
            buttonMutiplicar.Click += buttonMutiplicar_Click;
            // 
            // buttonMenos
            // 
            buttonMenos.BackColor = SystemColors.ActiveCaptionText;
            buttonMenos.ForeColor = SystemColors.Control;
            buttonMenos.Location = new Point(235, 238);
            buttonMenos.Name = "buttonMenos";
            buttonMenos.Size = new Size(60, 60);
            buttonMenos.TabIndex = 13;
            buttonMenos.Text = "-";
            buttonMenos.UseVisualStyleBackColor = false;
            buttonMenos.Click += buttonMenos_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ActiveCaptionText;
            buttonClear.ForeColor = SystemColors.Control;
            buttonClear.Location = new Point(235, 64);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(60, 36);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.ForeColor = SystemColors.Control;
            labelOperacao.Location = new Point(37, 18);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(0, 20);
            labelOperacao.TabIndex = 18;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(307, 373);
            Controls.Add(labelOperacao);
            Controls.Add(buttonClear);
            Controls.Add(buttonMais);
            Controls.Add(buttonDividir);
            Controls.Add(buttonMutiplicar);
            Controls.Add(buttonMenos);
            Controls.Add(buttonIgual);
            Controls.Add(buttonVirgula);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtResultado);
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonVirgula;
        private Button buttonIgual;
        private Button buttonMais;
        private Button buttonDividir;
        private Button buttonMutiplicar;
        private Button buttonMenos;
        private Button buttonClear;
        private Label labelOperacao;
    }
}
