namespace ProyectoErrores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtValorReal = new TextBox();
            txtValorAproximado = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            lblErrorAbsoluto = new Label();
            lblErrorRelativo = new Label();
            SuspendLayout();
            // 
            // txtValorReal
            // 
            txtValorReal.BackColor = Color.OldLace;
            txtValorReal.BorderStyle = BorderStyle.FixedSingle;
            txtValorReal.Font = new Font("Century Gothic", 12F);
            txtValorReal.ForeColor = Color.Black;
            txtValorReal.Location = new Point(40, 82);
            txtValorReal.Name = "txtValorReal";
            txtValorReal.Size = new Size(165, 32);
            txtValorReal.TabIndex = 0;
            // 
            // txtValorAproximado
            // 
            txtValorAproximado.BackColor = Color.OldLace;
            txtValorAproximado.BorderStyle = BorderStyle.FixedSingle;
            txtValorAproximado.Font = new Font("Century Gothic", 12F);
            txtValorAproximado.ForeColor = Color.Black;
            txtValorAproximado.Location = new Point(42, 153);
            txtValorAproximado.Name = "txtValorAproximado";
            txtValorAproximado.Size = new Size(163, 32);
            txtValorAproximado.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Azure;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Century Gothic", 12F);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(42, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(163, 43);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(42, 54);
            label1.Name = "label1";
            label1.Size = new Size(210, 23);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el valor real:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 124);
            label2.Name = "label2";
            label2.Size = new Size(292, 23);
            label2.TabIndex = 4;
            label2.Text = "Ingrese el valor aproximado:";
            // 
            // lblErrorAbsoluto
            // 
            lblErrorAbsoluto.AutoSize = true;
            lblErrorAbsoluto.BackColor = Color.Transparent;
            lblErrorAbsoluto.Font = new Font("Century Gothic", 12F);
            lblErrorAbsoluto.ForeColor = Color.Black;
            lblErrorAbsoluto.Location = new Point(361, 100);
            lblErrorAbsoluto.Name = "lblErrorAbsoluto";
            lblErrorAbsoluto.Size = new Size(0, 23);
            lblErrorAbsoluto.TabIndex = 6;
            lblErrorAbsoluto.Click += lblErrorAbsoluto_Click;
            // 
            // lblErrorRelativo
            // 
            lblErrorRelativo.AutoSize = true;
            lblErrorRelativo.BackColor = Color.Transparent;
            lblErrorRelativo.Font = new Font("Century Gothic", 12F);
            lblErrorRelativo.ForeColor = Color.Black;
            lblErrorRelativo.Location = new Point(361, 203);
            lblErrorRelativo.Name = "lblErrorRelativo";
            lblErrorRelativo.Size = new Size(0, 23);
            lblErrorRelativo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(638, 311);
            Controls.Add(lblErrorRelativo);
            Controls.Add(lblErrorAbsoluto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtValorAproximado);
            Controls.Add(txtValorReal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de Error absoluto y relativo";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtValorReal;
        private TextBox txtValorAproximado;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label lblErrorAbsoluto;
        private Label lblErrorRelativo;
    }
}
