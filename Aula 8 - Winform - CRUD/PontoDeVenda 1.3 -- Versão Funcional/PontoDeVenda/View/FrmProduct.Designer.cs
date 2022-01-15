
namespace PontoDeVenda.View
{
    partial class FrmCostumer
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblQuant = new System.Windows.Forms.Label();
            this.nmcQuant = new System.Windows.Forms.NumericUpDown();
            this.mskValue = new System.Windows.Forms.MaskedTextBox();
            this.LblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(47, 134);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 30);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Cadastrar";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(223, 134);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 30);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(12, 39);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(339, 23);
            this.txbDescription.TabIndex = 2;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescription.Location = new System.Drawing.Point(30, 16);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(80, 20);
            this.LblDescription.TabIndex = 4;
            this.LblDescription.Text = "Descrição*";
            // 
            // LblQuant
            // 
            this.LblQuant.AutoSize = true;
            this.LblQuant.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuant.Location = new System.Drawing.Point(30, 65);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.Size = new System.Drawing.Size(93, 20);
            this.LblQuant.TabIndex = 5;
            this.LblQuant.Text = "Quantidade*";
            // 
            // nmcQuant
            // 
            this.nmcQuant.Location = new System.Drawing.Point(12, 88);
            this.nmcQuant.Name = "nmcQuant";
            this.nmcQuant.Size = new System.Drawing.Size(138, 23);
            this.nmcQuant.TabIndex = 6;
            // 
            // mskValue
            // 
            this.mskValue.Location = new System.Drawing.Point(171, 88);
            this.mskValue.Mask = "12,12";
            this.mskValue.Name = "mskValue";
            this.mskValue.Size = new System.Drawing.Size(180, 23);
            this.mskValue.TabIndex = 7;
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblValue.Location = new System.Drawing.Point(182, 65);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(49, 20);
            this.LblValue.TabIndex = 8;
            this.LblValue.Text = "Valor*";
            // 
            // FrmCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 176);
            this.Controls.Add(this.LblValue);
            this.Controls.Add(this.mskValue);
            this.Controls.Add(this.nmcQuant);
            this.Controls.Add(this.LblQuant);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Name = "FrmCostumer";
            this.Text = "FrmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblQuant;
        private System.Windows.Forms.NumericUpDown nmcQuant;
        private System.Windows.Forms.MaskedTextBox mskValue;
        private System.Windows.Forms.Label LblValue;
    }
}