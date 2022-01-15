
namespace PontoDeVenda.View
{
    partial class FrmMain
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnProductMenuItem = new System.Windows.Forms.Button();
            this.btnClientMenuItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(122, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(213, 37);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Consultar Dados";
            // 
            // BtnProductMenuItem
            // 
            this.BtnProductMenuItem.Location = new System.Drawing.Point(104, 167);
            this.BtnProductMenuItem.Name = "BtnProductMenuItem";
            this.BtnProductMenuItem.Size = new System.Drawing.Size(244, 43);
            this.BtnProductMenuItem.TabIndex = 1;
            this.BtnProductMenuItem.Text = "Produto";
            this.BtnProductMenuItem.UseVisualStyleBackColor = true;
            this.BtnProductMenuItem.Click += new System.EventHandler(this.BtnProductMenuItem_Click);
            // 
            // btnClientMenuItem
            // 
            this.btnClientMenuItem.Location = new System.Drawing.Point(104, 98);
            this.btnClientMenuItem.Name = "btnClientMenuItem";
            this.btnClientMenuItem.Size = new System.Drawing.Size(244, 43);
            this.btnClientMenuItem.TabIndex = 2;
            this.btnClientMenuItem.Text = "Clientes";
            this.btnClientMenuItem.UseVisualStyleBackColor = true;
            this.btnClientMenuItem.Click += new System.EventHandler(this.btnClientMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 453);
            this.Controls.Add(this.btnClientMenuItem);
            this.Controls.Add(this.BtnProductMenuItem);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 492);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 492);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnProductMenuItem;
        private System.Windows.Forms.Button btnClientMenuItem;
    }
}