namespace practica1
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
            label1 = new Label();
            btnEncender = new Button();
            btnApagar = new Button();
            txtEstado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "INTERFAZ DE LED";
            // 
            // btnEncender
            // 
            btnEncender.BackColor = Color.Lime;
            btnEncender.ForeColor = Color.Cornsilk;
            btnEncender.Location = new Point(76, 75);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(75, 23);
            btnEncender.TabIndex = 1;
            btnEncender.Text = "ENCENDER";
            btnEncender.UseVisualStyleBackColor = false;
            btnEncender.Click += button1_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.Location = new Point(266, 75);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 2;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // txtEstado
            // 
            txtEstado.AutoSize = true;
            txtEstado.Location = new Point(161, 125);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(85, 15);
            txtEstado.TabIndex = 3;
            txtEstado.Text = "Estado Del LED";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 208);
            Controls.Add(txtEstado);
            Controls.Add(btnApagar);
            Controls.Add(btnEncender);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEncender;
        private Button btnApagar;
        private Label txtEstado;
    }
}
