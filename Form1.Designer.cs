namespace Pedra_Papel_Tesoura_3
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 63);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Pedra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(141, 63);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Papel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(259, 63);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Tesoura";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(194, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(194, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 31);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 43);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "Pontuação";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(488, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(672, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(75, 31);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 70);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 8;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(689, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 25);
            label3.TabIndex = 9;
            label3.Text = "Bot";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 203);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 10;
            label4.Text = "Escolha da máquina:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 112);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 11;
            label5.Text = "Escolha do usuário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 30);
            label6.Name = "label6";
            label6.Size = new Size(218, 25);
            label6.TabIndex = 12;
            label6.Text = "Click em uma das opções:";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(396, 328);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 25);
            lblresultado.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblresultado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblresultado;
    }
}