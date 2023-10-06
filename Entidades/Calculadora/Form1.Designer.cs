namespace Calculadora
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
            lblResultado = new Label();
            lblPrimerOperando = new Label();
            lblOperador = new Label();
            lblSegundoOperando = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperador = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            listBox1 = new ListBox();
            lblHistorial = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(31, 48);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(246, 65);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(31, 276);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(198, 32);
            lblPrimerOperando.TabIndex = 1;
            lblPrimerOperando.Text = "Primer operando:";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperador.Location = new Point(337, 276);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(115, 32);
            lblOperador.TabIndex = 2;
            lblOperador.Text = "Operador";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(549, 276);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(225, 32);
            lblSegundoOperando.TabIndex = 3;
            lblSegundoOperando.Text = "Segundo operando:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(31, 330);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(198, 36);
            txtPrimerOperando.TabIndex = 4;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(563, 332);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(198, 36);
            txtSegundoOperando.TabIndex = 5;
            // 
            // cmbOperador
            // 
            cmbOperador.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Location = new Point(331, 330);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(121, 38);
            cmbOperador.TabIndex = 6;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(31, 388);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(198, 50);
            btnOperar.TabIndex = 7;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(331, 388);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 50);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(563, 388);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(198, 50);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbBinario);
            groupBox1.Controls.Add(rdbDecimal);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(269, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Representacion de sistemas:";
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(29, 39);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(84, 25);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(150, 39);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 25);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(563, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(198, 184);
            listBox1.TabIndex = 11;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(563, 25);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(101, 32);
            lblHistorial.TabIndex = 12;
            lblHistorial.Text = "Historial";
            lblHistorial.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHistorial);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperador);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblOperador);
            Controls.Add(lblPrimerOperando);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de [Lucas Bracuto]";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Label lblPrimerOperando;
        private Label lblOperador;
        private Label lblSegundoOperando;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private GroupBox groupBox1;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private ListBox listBox1;
        private Label lblHistorial;
    }
}