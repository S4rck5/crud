namespace Crud
{
    partial class CervezaForm
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtEstilo = new TextBox();
            label3 = new Label();
            txtAlcohol = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(21, 362);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(148, 59);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(246, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(148, 59);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 87);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 152);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Estilo";
            // 
            // txtEstilo
            // 
            txtEstilo.Location = new Point(169, 146);
            txtEstilo.Name = "txtEstilo";
            txtEstilo.Size = new Size(150, 31);
            txtEstilo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 232);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 1;
            label3.Text = "Alcohol";
            // 
            // txtAlcohol
            // 
            txtAlcohol.Location = new Point(169, 226);
            txtAlcohol.Name = "txtAlcohol";
            txtAlcohol.Size = new Size(150, 31);
            txtAlcohol.TabIndex = 2;
            // 
            // CervezaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(txtAlcohol);
            Controls.Add(label3);
            Controls.Add(txtEstilo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "CervezaForm";
            Text = "CervezaForm";
            Load += CervezaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEstilo;
        private Label label3;
        private TextBox txtAlcohol;
    }
}