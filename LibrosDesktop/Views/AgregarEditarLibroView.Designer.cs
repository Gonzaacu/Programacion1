namespace LibrosDesktop.Views
{
    partial class AgregarEditarLibroView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtPortadaUrl = new TextBox();
            txtSinopsis = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericPaginas = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            txtGenero = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPaginas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(321, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(137, 100);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(321, 23);
            txtAutor.TabIndex = 2;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(137, 157);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(321, 23);
            txtEditorial.TabIndex = 3;
            // 
            // txtPortadaUrl
            // 
            txtPortadaUrl.Location = new Point(137, 216);
            txtPortadaUrl.Name = "txtPortadaUrl";
            txtPortadaUrl.Size = new Size(321, 23);
            txtPortadaUrl.TabIndex = 4;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(137, 400);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(321, 55);
            txtSinopsis.TabIndex = 5;
            txtSinopsis.TextChanged += textBox5_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 157);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Editorial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 216);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 8;
            label4.Text = "Portada Url:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 400);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "Sinopsis:";
            label5.Click += label5_Click;
            // 
            // numericPaginas
            // 
            numericPaginas.Location = new Point(137, 339);
            numericPaginas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericPaginas.Name = "numericPaginas";
            numericPaginas.Size = new Size(94, 23);
            numericPaginas.TabIndex = 10;
            numericPaginas.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 339);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Paginas:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 277);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Genero:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(137, 277);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(321, 23);
            txtGenero.TabIndex = 13;
            txtGenero.TextChanged += textBox1_TextChanged_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(156, 480);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(360, 480);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 519);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtGenero);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericPaginas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSinopsis);
            Controls.Add(txtPortadaUrl);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "AgregarEditarLibroView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar Libro";
            Load += AgregarEditarLibroView_Load;
            ((System.ComponentModel.ISupportInitialize)numericPaginas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtPortadaUrl;
        private TextBox txtSinopsis;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericPaginas;
        private Label label6;
        private Label label7;
        private TextBox txtGenero;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}