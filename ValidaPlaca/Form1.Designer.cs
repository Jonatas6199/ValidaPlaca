namespace ValidaPlaca
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
            txtPlaca = new TextBox();
            btnValidar = new Button();
            lvPlacas = new ListView();
            columnHeader1 = new ColumnHeader();
            lblPlacas = new Label();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(94, 67);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(128, 23);
            txtPlaca.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(120, 111);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lvPlacas
            // 
            lvPlacas.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvPlacas.FullRowSelect = true;
            lvPlacas.GridLines = true;
            lvPlacas.Location = new Point(73, 172);
            lvPlacas.Name = "lvPlacas";
            lvPlacas.Size = new Size(167, 130);
            lvPlacas.TabIndex = 2;
            lvPlacas.UseCompatibleStateImageBehavior = false;
            lvPlacas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Placa";
            columnHeader1.Width = 130;
            // 
            // lblPlacas
            // 
            lblPlacas.AutoSize = true;
            lblPlacas.Location = new Point(73, 154);
            lblPlacas.Name = "lblPlacas";
            lblPlacas.Size = new Size(0, 15);
            lblPlacas.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 328);
            Controls.Add(lblPlacas);
            Controls.Add(lvPlacas);
            Controls.Add(btnValidar);
            Controls.Add(txtPlaca);
            Name = "Form1";
            Text = "Valida Placa de Carro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaca;
        private Button btnValidar;
        private ListView lvPlacas;
        private Label lblPlacas;
        private ColumnHeader columnHeader1;
    }
}
