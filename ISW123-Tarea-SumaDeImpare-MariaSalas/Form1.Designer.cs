namespace ISW123_Tarea_SumaDeImpare_MariaSalas
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
            lblHasta = new Label();
            nudHasta = new NumericUpDown();
            btnSumar = new Button();
            lstSalida = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudHasta).BeginInit();
            SuspendLayout();
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(54, 48);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(37, 15);
            lblHasta.TabIndex = 0;
            lblHasta.Text = "Hasta";
            // 
            // nudHasta
            // 
            nudHasta.Location = new Point(118, 48);
            nudHasta.Name = "nudHasta";
            nudHasta.Size = new Size(120, 23);
            nudHasta.TabIndex = 1;
            nudHasta.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(561, 48);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lstSalida
            // 
            lstSalida.FormattingEnabled = true;
            lstSalida.Location = new Point(54, 151);
            lstSalida.Name = "lstSalida";
            lstSalida.Size = new Size(596, 184);
            lstSalida.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSalida);
            Controls.Add(btnSumar);
            Controls.Add(nudHasta);
            Controls.Add(lblHasta);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudHasta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHasta;
        private NumericUpDown nudHasta;
        private Button btnSumar;
        private ListBox lstSalida;
    }
}
