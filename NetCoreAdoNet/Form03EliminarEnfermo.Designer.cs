namespace NetCoreAdoNet
{
    partial class Form03EliminarEnfermo
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
            txtInscripcion = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(24, 53);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(167, 35);
            txtInscripcion.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(25, 104);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 78);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar enfermo";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 16);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(240, 49);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(308, 274);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 381);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtInscripcion);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form03EliminarEnfermo";
            Text = "Form03EliminarEnfermo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInscripcion;
        private Button btnEliminar;
        private Label label2;
        private ListBox lstEnfermos;
    }
}