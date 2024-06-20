namespace LibrosDesktop.Views
{
    partial class GestionLibrosViews
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
            dataGridLibros = new DataGridView();
            BTNAg = new Button();
            BTNEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridLibros).BeginInit();
            SuspendLayout();
            // 
            // dataGridLibros
            // 
            dataGridLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibros.Location = new Point(27, 22);
            dataGridLibros.Name = "dataGridLibros";
            dataGridLibros.Size = new Size(748, 376);
            dataGridLibros.TabIndex = 0;
            dataGridLibros.CellContentClick += dataGridLibros_CellContentClick;
            // 
            // BTNAg
            // 
            BTNAg.Location = new Point(68, 419);
            BTNAg.Name = "BTNAg";
            BTNAg.Size = new Size(75, 23);
            BTNAg.TabIndex = 1;
            BTNAg.Text = "&Agregar";
            BTNAg.UseVisualStyleBackColor = true;
            BTNAg.Click += BTNAg_Click;
            // 
            // BTNEditar
            // 
            BTNEditar.Location = new Point(208, 419);
            BTNEditar.Name = "BTNEditar";
            BTNEditar.Size = new Size(75, 23);
            BTNEditar.TabIndex = 2;
            BTNEditar.Text = "E&ditar";
            BTNEditar.UseVisualStyleBackColor = true;
            BTNEditar.Click += BTNEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(346, 419);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "El&iminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(700, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Sal&ir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button3_Click;
            // 
            // GestionLibrosViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 454);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(BTNEditar);
            Controls.Add(BTNAg);
            Controls.Add(dataGridLibros);
            Name = "GestionLibrosViews";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GestionLibrosViews";
            ((System.ComponentModel.ISupportInitialize)dataGridLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridLibros;
        private Button BTNAg;
        private Button BTNEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}