
namespace PontoDeVenda.View
{
    partial class FrmConsultClient
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.ltvShowClient = new System.Windows.Forms.ListView();
            this.clhId_Client = new System.Windows.Forms.ColumnHeader();
            this.clhName_Client = new System.Windows.Forms.ColumnHeader();
            this.clhCpf_Client = new System.Windows.Forms.ColumnHeader();
            this.clhEmail_Client = new System.Windows.Forms.ColumnHeader();
            this.clhFone_Client = new System.Windows.Forms.ColumnHeader();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(55, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 53);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Voltar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ltvShowClient
            // 
            this.ltvShowClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId_Client,
            this.clhName_Client,
            this.clhCpf_Client,
            this.clhEmail_Client,
            this.clhFone_Client});
            this.ltvShowClient.FullRowSelect = true;
            this.ltvShowClient.HideSelection = false;
            this.ltvShowClient.Location = new System.Drawing.Point(12, 12);
            this.ltvShowClient.Name = "ltvShowClient";
            this.ltvShowClient.Size = new System.Drawing.Size(459, 320);
            this.ltvShowClient.TabIndex = 13;
            this.ltvShowClient.UseCompatibleStateImageBehavior = false;
            this.ltvShowClient.View = System.Windows.Forms.View.Details;
            this.ltvShowClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvShowClient_MouseDoubleClick);
            // 
            // clhId_Client
            // 
            this.clhId_Client.Text = "ID";
            this.clhId_Client.Width = 35;
            // 
            // clhName_Client
            // 
            this.clhName_Client.Text = "Nome";
            this.clhName_Client.Width = 120;
            // 
            // clhCpf_Client
            // 
            this.clhCpf_Client.Text = "CPF";
            this.clhCpf_Client.Width = 80;
            // 
            // clhEmail_Client
            // 
            this.clhEmail_Client.Text = "E-Mail";
            this.clhEmail_Client.Width = 120;
            // 
            // clhFone_Client
            // 
            this.clhFone_Client.Text = "Telefone";
            this.clhFone_Client.Width = 100;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(303, 362);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 53);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Novo Cliente";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FrmConsultClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 441);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ltvShowClient);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(499, 480);
            this.Name = "FrmConsultClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costumer";
            this.Load += new System.EventHandler(this.FrmClient_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView ltvShowClient;
        private System.Windows.Forms.ColumnHeader clhId_Client;
        private System.Windows.Forms.ColumnHeader clhName_Client;
        private System.Windows.Forms.ColumnHeader clhCpf_Client;
        private System.Windows.Forms.ColumnHeader clhEmail_Client;
        private System.Windows.Forms.ColumnHeader clhFone_Client;
        private System.Windows.Forms.Button btnRegister;
    }
}