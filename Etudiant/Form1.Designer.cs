namespace Etudiant
{
    partial class EtudiantForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtudiantForm1));
            this.btnSender = new System.Windows.Forms.Button();
            this.listMesseges = new System.Windows.Forms.ListBox();
            this.txtMessege = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_Disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSender
            // 
            this.btnSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSender.Location = new System.Drawing.Point(522, 240);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(75, 22);
            this.btnSender.TabIndex = 0;
            this.btnSender.Text = "Sender";
            this.btnSender.UseVisualStyleBackColor = false;
            this.btnSender.Click += new System.EventHandler(this.btnSender_Click);
            // 
            // listMesseges
            // 
            this.listMesseges.FormattingEnabled = true;
            this.listMesseges.Location = new System.Drawing.Point(86, 59);
            this.listMesseges.Name = "listMesseges";
            this.listMesseges.Size = new System.Drawing.Size(511, 160);
            this.listMesseges.TabIndex = 1;
            // 
            // txtMessege
            // 
            this.txtMessege.Location = new System.Drawing.Point(86, 240);
            this.txtMessege.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessege.Name = "txtMessege";
            this.txtMessege.Size = new System.Drawing.Size(411, 20);
            this.txtMessege.TabIndex = 2;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnJoin.Location = new System.Drawing.Point(699, 295);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(140, 47);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join the room";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Etudiant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttn_Disconnect
            // 
            this.bttn_Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttn_Disconnect.Location = new System.Drawing.Point(35, 295);
            this.bttn_Disconnect.Name = "bttn_Disconnect";
            this.bttn_Disconnect.Size = new System.Drawing.Size(110, 46);
            this.bttn_Disconnect.TabIndex = 5;
            this.bttn_Disconnect.Text = "Disconnect";
            this.bttn_Disconnect.UseVisualStyleBackColor = false;
            this.bttn_Disconnect.Click += new System.EventHandler(this.bttn_Disconnect_Click);
            // 
            // EtudiantForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 354);
            this.Controls.Add(this.bttn_Disconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtMessege);
            this.Controls.Add(this.listMesseges);
            this.Controls.Add(this.btnSender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EtudiantForm1";
            this.Text = "Etudiant";
            this.Load += new System.EventHandler(this.EtudiantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSender;
        private System.Windows.Forms.ListBox listMesseges;
        private System.Windows.Forms.TextBox txtMessege;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_Disconnect;
    }
}

