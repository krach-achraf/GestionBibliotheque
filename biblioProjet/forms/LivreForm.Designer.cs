namespace biblioProjet.forms
{
    partial class LivreForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.effacerBtn = new System.Windows.Forms.Button();
            this.afficherBtn = new System.Windows.Forms.Button();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.dataGridLivres = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.editionTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.editeurTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.auteurTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.titreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.coteTxt = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivres)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.effacerBtn);
            this.panel1.Controls.Add(this.ajouterBtn);
            this.panel1.Controls.Add(this.modifierBtn);
            this.panel1.Controls.Add(this.afficherBtn);
            this.panel1.Controls.Add(this.supprimerBtn);
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 54);
            this.panel1.TabIndex = 0;
            // 
            // effacerBtn
            // 
            this.effacerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.effacerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.effacerBtn.FlatAppearance.BorderSize = 0;
            this.effacerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effacerBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.effacerBtn.Location = new System.Drawing.Point(725, 11);
            this.effacerBtn.Name = "effacerBtn";
            this.effacerBtn.Size = new System.Drawing.Size(116, 30);
            this.effacerBtn.TabIndex = 5;
            this.effacerBtn.Text = "EFFACER";
            this.effacerBtn.UseVisualStyleBackColor = false;
            this.effacerBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // afficherBtn
            // 
            this.afficherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.afficherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afficherBtn.FlatAppearance.BorderSize = 0;
            this.afficherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficherBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficherBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.afficherBtn.Location = new System.Drawing.Point(551, 11);
            this.afficherBtn.Name = "afficherBtn";
            this.afficherBtn.Size = new System.Drawing.Size(116, 30);
            this.afficherBtn.TabIndex = 4;
            this.afficherBtn.Text = "AFFICHER";
            this.afficherBtn.UseVisualStyleBackColor = false;
            this.afficherBtn.Click += new System.EventHandler(this.afficherBtn_Click);
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.supprimerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimerBtn.Enabled = false;
            this.supprimerBtn.FlatAppearance.BorderSize = 0;
            this.supprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.supprimerBtn.Location = new System.Drawing.Point(385, 11);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(116, 30);
            this.supprimerBtn.TabIndex = 2;
            this.supprimerBtn.Text = "SUPPRIMER";
            this.supprimerBtn.UseVisualStyleBackColor = false;
            this.supprimerBtn.Click += new System.EventHandler(this.supprimerBtn_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.modifierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifierBtn.Enabled = false;
            this.modifierBtn.FlatAppearance.BorderSize = 0;
            this.modifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.modifierBtn.Location = new System.Drawing.Point(221, 11);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(116, 30);
            this.modifierBtn.TabIndex = 1;
            this.modifierBtn.Text = "MODIFIER";
            this.modifierBtn.UseVisualStyleBackColor = false;
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click);
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.ajouterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajouterBtn.FlatAppearance.BorderSize = 0;
            this.ajouterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.ajouterBtn.Location = new System.Drawing.Point(59, 11);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(116, 30);
            this.ajouterBtn.TabIndex = 0;
            this.ajouterBtn.Text = "AJOUTER";
            this.ajouterBtn.UseVisualStyleBackColor = false;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // dataGridLivres
            // 
            this.dataGridLivres.AllowUserToAddRows = false;
            this.dataGridLivres.AllowUserToDeleteRows = false;
            this.dataGridLivres.BackgroundColor = System.Drawing.Color.White;
            this.dataGridLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivres.Location = new System.Drawing.Point(317, 49);
            this.dataGridLivres.Name = "dataGridLivres";
            this.dataGridLivres.ReadOnly = true;
            this.dataGridLivres.Size = new System.Drawing.Size(584, 422);
            this.dataGridLivres.TabIndex = 1;
            this.dataGridLivres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLivres_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.editionTxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.editeurTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.auteurTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.titreTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.coteTxt);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 422);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(41, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Edition";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel11.Location = new System.Drawing.Point(44, 396);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(223, 1);
            this.panel11.TabIndex = 16;
            // 
            // editionTxt
            // 
            this.editionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editionTxt.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.editionTxt.Location = new System.Drawing.Point(44, 376);
            this.editionTxt.Name = "editionTxt";
            this.editionTxt.Size = new System.Drawing.Size(223, 16);
            this.editionTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(40, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Editeur";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel10.Location = new System.Drawing.Point(43, 314);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(223, 1);
            this.panel10.TabIndex = 13;
            // 
            // editeurTxt
            // 
            this.editeurTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editeurTxt.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeurTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.editeurTxt.Location = new System.Drawing.Point(43, 294);
            this.editeurTxt.Name = "editeurTxt";
            this.editeurTxt.Size = new System.Drawing.Size(223, 16);
            this.editeurTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Auteur";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel9.Location = new System.Drawing.Point(43, 231);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(223, 1);
            this.panel9.TabIndex = 10;
            // 
            // auteurTxt
            // 
            this.auteurTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.auteurTxt.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteurTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.auteurTxt.Location = new System.Drawing.Point(43, 210);
            this.auteurTxt.Name = "auteurTxt";
            this.auteurTxt.Size = new System.Drawing.Size(223, 16);
            this.auteurTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Titre";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel8.Location = new System.Drawing.Point(43, 148);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(223, 1);
            this.panel8.TabIndex = 7;
            // 
            // titreTxt
            // 
            this.titreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titreTxt.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.titreTxt.Location = new System.Drawing.Point(43, 128);
            this.titreTxt.Name = "titreTxt";
            this.titreTxt.Size = new System.Drawing.Size(223, 16);
            this.titreTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cote";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel7.Location = new System.Drawing.Point(43, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 1);
            this.panel7.TabIndex = 4;
            // 
            // coteTxt
            // 
            this.coteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coteTxt.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coteTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.coteTxt.Location = new System.Drawing.Point(43, 45);
            this.coteTxt.Name = "coteTxt";
            this.coteTxt.Size = new System.Drawing.Size(223, 16);
            this.coteTxt.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel6.Location = new System.Drawing.Point(317, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 474);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(344, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des livres";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 50);
            this.panel3.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel14.Location = new System.Drawing.Point(899, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1, 49);
            this.panel14.TabIndex = 61;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 49);
            this.panel13.TabIndex = 60;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel12.Location = new System.Drawing.Point(0, 49);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(901, 1);
            this.panel12.TabIndex = 6;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel15.Location = new System.Drawing.Point(317, 49);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1, 419);
            this.panel15.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(0, 470);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 1);
            this.panel4.TabIndex = 7;
            // 
            // LivreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridLivres);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LivreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LivreForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivres)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridLivres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.Button effacerBtn;
        private System.Windows.Forms.Button afficherBtn;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox editionTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox editeurTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox auteurTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox titreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox coteTxt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel4;
    }
}