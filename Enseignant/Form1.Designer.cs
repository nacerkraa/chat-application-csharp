namespace Enseignant
{
    partial class EnseignantForm1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnseignantForm1));
            this.btnSender = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.listDesEtudiants = new System.Windows.Forms.ListBox();
            this.labelListEtudiant = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.bttn_StopServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSender
            // 
            this.btnSender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSender.Location = new System.Drawing.Point(699, 392);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(75, 23);
            this.btnSender.TabIndex = 0;
            this.btnSender.Text = "Send";
            this.btnSender.UseVisualStyleBackColor = false;
            this.btnSender.Click += new System.EventHandler(this.btnSender_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(278, 394);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(396, 20);
            this.textMessage.TabIndex = 1;
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.Location = new System.Drawing.Point(278, 116);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(496, 264);
            this.listMessages.TabIndex = 2;
            // 
            // listDesEtudiants
            // 
            this.listDesEtudiants.FormattingEnabled = true;
            this.listDesEtudiants.Location = new System.Drawing.Point(831, 116);
            this.listDesEtudiants.Name = "listDesEtudiants";
            this.listDesEtudiants.Size = new System.Drawing.Size(214, 264);
            this.listDesEtudiants.TabIndex = 3;
            // 
            // labelListEtudiant
            // 
            this.labelListEtudiant.AutoSize = true;
            this.labelListEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelListEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListEtudiant.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelListEtudiant.Location = new System.Drawing.Point(827, 73);
            this.labelListEtudiant.Name = "labelListEtudiant";
            this.labelListEtudiant.Size = new System.Drawing.Size(148, 20);
            this.labelListEtudiant.TabIndex = 4;
            this.labelListEtudiant.Text = "list des Etudiants";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnect.Location = new System.Drawing.Point(895, 407);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 45);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(278, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bttn_StopServer
            // 
            this.bttn_StopServer.Location = new System.Drawing.Point(11, 413);
            this.bttn_StopServer.Name = "bttn_StopServer";
            this.bttn_StopServer.Size = new System.Drawing.Size(102, 31);
            this.bttn_StopServer.TabIndex = 6;
            this.bttn_StopServer.Text = "Stop Server";
            this.bttn_StopServer.UseVisualStyleBackColor = true;
            this.bttn_StopServer.Click += new System.EventHandler(this.bttn_StopServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enseignat";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bttn_StopServer);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 461);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome";
            // 
            // EnseignantForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1096, 464);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelListEtudiant);
            this.Controls.Add(this.listDesEtudiants);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.btnSender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnseignantForm1";
            this.Text = "Enseignant";
            this.Load += new System.EventHandler(this.EnseignantForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSender;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.ListBox listDesEtudiants;
        private System.Windows.Forms.Label labelListEtudiant;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button bttn_StopServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

