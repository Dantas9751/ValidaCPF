namespace ValidaCPF
{
    partial class Frm_ValidaCPFs
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
            Btn_Reset = new Button();
            Btn_ValidaCPF = new Button();
            Lbl_Resultado = new Label();
            Msk_CPF = new MaskedTextBox();
            SuspendLayout();
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(245, 42);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 23);
            Btn_Reset.TabIndex = 0;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Btn_ValidaCPF
            // 
            Btn_ValidaCPF.Location = new Point(245, 71);
            Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            Btn_ValidaCPF.Size = new Size(111, 23);
            Btn_ValidaCPF.TabIndex = 1;
            Btn_ValidaCPF.Text = "Valida";
            Btn_ValidaCPF.UseVisualStyleBackColor = true;
            Btn_ValidaCPF.Click += Btn_ValidaCPF_Click;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            Lbl_Resultado.Location = new Point(12, 90);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(0, 22);
            Lbl_Resultado.TabIndex = 2;
            // 
            // Msk_CPF
            // 
            Msk_CPF.Font = new Font("Segoe UI", 7F);
            Msk_CPF.Location = new Point(12, 45);
            Msk_CPF.Mask = "000,000,000-00";
            Msk_CPF.Name = "Msk_CPF";
            Msk_CPF.Size = new Size(218, 20);
            Msk_CPF.TabIndex = 3;
            // 
            // Frm_ValidaCPFs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 154);
            Controls.Add(Msk_CPF);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Btn_ValidaCPF);
            Controls.Add(Btn_Reset);
            Name = "Frm_ValidaCPFs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação CPF";
            Load += Frm_ValidaCPFs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Reset;
        private Button Btn_ValidaCPF;
        private Label Lbl_Resultado;
        private MaskedTextBox Msk_CPF;
    }
}
