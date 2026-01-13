namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnRead = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            label2 = new Label();
            lstColumnas = new ListBox();
            label3 = new Label();
            lstTipos = new ListBox();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(27, 30);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(147, 49);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(29, 103);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(145, 51);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(29, 171);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(130, 63);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 12);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(200, 46);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(217, 334);
            lstApellidos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 13);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(445, 46);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(207, 334);
            lstColumnas.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(674, 16);
            label3.Name = "label3";
            label3.Size = new Size(110, 30);
            label3.TabIndex = 7;
            label3.Text = "Tipos dato";
            // 
            // lstTipos
            // 
            lstTipos.FormattingEnabled = true;
            lstTipos.Location = new Point(674, 46);
            lstTipos.Name = "lstTipos";
            lstTipos.Size = new Size(186, 334);
            lstTipos.TabIndex = 8;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(29, 397);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(122, 30);
            lblConexion.TabIndex = 9;
            lblConexion.Text = "lblConexion";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 463);
            Controls.Add(lblConexion);
            Controls.Add(lstTipos);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnRead;
        private Label label1;
        private ListBox lstApellidos;
        private Label label2;
        private ListBox lstColumnas;
        private Label label3;
        private ListBox lstTipos;
        private Label lblConexion;
    }
}