namespace radar
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
            btnAumentar = new Button();
            btnDisminuar = new Button();
            txtAnuncio1 = new Label();
            txtValorMotor = new Label();
            label1 = new Label();
            boxValorIngreso = new TextBox();
            btnAutomatico = new Button();
            btnDetener = new Button();
            label2 = new Label();
            txtvalorRadar = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAumentar
            // 
            btnAumentar.Location = new Point(98, 12);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(123, 27);
            btnAumentar.TabIndex = 0;
            btnAumentar.Text = "Aumentar +10°";
            btnAumentar.UseVisualStyleBackColor = true;
            btnAumentar.Click += button1_Click;
            // 
            // btnDisminuar
            // 
            btnDisminuar.Location = new Point(98, 53);
            btnDisminuar.Name = "btnDisminuar";
            btnDisminuar.Size = new Size(123, 27);
            btnDisminuar.TabIndex = 1;
            btnDisminuar.Text = "Disminuir -10°";
            btnDisminuar.UseVisualStyleBackColor = true;
            btnDisminuar.Click += btnDisminuar_Click;
            // 
            // txtAnuncio1
            // 
            txtAnuncio1.AutoSize = true;
            txtAnuncio1.ForeColor = SystemColors.ControlLightLight;
            txtAnuncio1.Location = new Point(540, 24);
            txtAnuncio1.Name = "txtAnuncio1";
            txtAnuncio1.Size = new Size(101, 15);
            txtAnuncio1.TabIndex = 3;
            txtAnuncio1.Text = "Posicion del radar";
            // 
            // txtValorMotor
            // 
            txtValorMotor.AutoSize = true;
            txtValorMotor.ForeColor = SystemColors.ButtonHighlight;
            txtValorMotor.Location = new Point(582, 51);
            txtValorMotor.Name = "txtValorMotor";
            txtValorMotor.Size = new Size(13, 15);
            txtValorMotor.TabIndex = 0;
            txtValorMotor.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(98, 95);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 4;
            label1.Text = "ingrese el valor de giro";
            // 
            // boxValorIngreso
            // 
            boxValorIngreso.BackColor = SystemColors.Window;
            boxValorIngreso.Location = new Point(245, 88);
            boxValorIngreso.Name = "boxValorIngreso";
            boxValorIngreso.Size = new Size(100, 23);
            boxValorIngreso.TabIndex = 5;
            boxValorIngreso.Text = "en °";
            boxValorIngreso.KeyDown += boxValorIngreso_KeyDown;
            // 
            // btnAutomatico
            // 
            btnAutomatico.Location = new Point(387, 12);
            btnAutomatico.Name = "btnAutomatico";
            btnAutomatico.Size = new Size(123, 27);
            btnAutomatico.TabIndex = 6;
            btnAutomatico.Text = "Automatico";
            btnAutomatico.UseVisualStyleBackColor = true;
            btnAutomatico.Click += btnAutomatico_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(387, 51);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(123, 27);
            btnDetener.TabIndex = 7;
            btnDetener.Text = "Paro Automatico";
            btnDetener.TextAlign = ContentAlignment.BottomCenter;
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(548, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 8;
            label2.Text = "valor del radar";
            // 
            // txtvalorRadar
            // 
            txtvalorRadar.AutoSize = true;
            txtvalorRadar.ForeColor = SystemColors.ButtonHighlight;
            txtvalorRadar.Location = new Point(582, 133);
            txtvalorRadar.Name = "txtvalorRadar";
            txtvalorRadar.Size = new Size(13, 15);
            txtvalorRadar.TabIndex = 9;
            txtvalorRadar.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(109, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 367);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(45, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 361);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(655, 543);
            Controls.Add(panel1);
            Controls.Add(txtvalorRadar);
            Controls.Add(label2);
            Controls.Add(btnDetener);
            Controls.Add(btnAutomatico);
            Controls.Add(boxValorIngreso);
            Controls.Add(label1);
            Controls.Add(txtValorMotor);
            Controls.Add(txtAnuncio1);
            Controls.Add(btnDisminuar);
            Controls.Add(btnAumentar);
            Name = "Form1";
            Text = "valor en °";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAumentar;
        private Button btnDisminuar;
        private Label txtAnuncio1;
        private Label txtValorMotor;
        private Label label1;
        private TextBox boxValorIngreso;
        private Button btnAutomatico;
        private Button btnDetener;
        private Label label2;
        private Label txtvalorRadar;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
