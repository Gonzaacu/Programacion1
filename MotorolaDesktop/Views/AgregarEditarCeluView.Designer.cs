namespace MotorolaDesktop.Views
{
    partial class AgregarEditarCeluView
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtModelo = new TextBox();
            txtAutor = new TextBox();
            txtUrlimagen = new TextBox();
            txtDescripcion = new TextBox();
            btnCanse = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 60);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 128);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 203);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 273);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 4;
            label4.Text = "Url_Imagen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 336);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 5;
            label5.Text = "Descripcion";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(150, 128);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(256, 23);
            txtModelo.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(150, 200);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(256, 23);
            txtAutor.TabIndex = 7;
            txtAutor.TextChanged += textBox3_TextChanged;
            // 
            // txtUrlimagen
            // 
            txtUrlimagen.Location = new Point(150, 265);
            txtUrlimagen.Name = "txtUrlimagen";
            txtUrlimagen.Size = new Size(256, 23);
            txtUrlimagen.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(150, 328);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(256, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // btnCanse
            // 
            btnCanse.Location = new Point(196, 379);
            btnCanse.Name = "btnCanse";
            btnCanse.Size = new Size(75, 23);
            btnCanse.TabIndex = 10;
            btnCanse.Text = "&Guardar";
            btnCanse.UseVisualStyleBackColor = true;
            btnCanse.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(289, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarEditarCeluView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 414);
            Controls.Add(btnCancelar);
            Controls.Add(btnCanse);
            Controls.Add(txtDescripcion);
            Controls.Add(txtUrlimagen);
            Controls.Add(txtAutor);
            Controls.Add(txtModelo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "AgregarEditarCeluView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarCeluView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtModelo;
        private TextBox txtAutor;
        private TextBox txtUrlimagen;
        private TextBox txtDescripcion;
        private Button btnCanse;
        private Button btnCancelar;
    }
}