namespace biblioProjet.forms
{
    partial class EmpruntForm
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.effacerBtn = new System.Windows.Forms.Button();
            this.afficherBtn = new System.Windows.Forms.Button();
            this.rendreBtn = new System.Windows.Forms.Button();
            this.emprunterBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateFinTxt = new System.Windows.Forms.DateTimePicker();
            this.adherentTxt = new System.Windows.Forms.ComboBox();
            this.ouvrageTxt = new System.Windows.Forms.ComboBox();
            this.dataGridEmprunts = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aRendreBtn = new System.Windows.Forms.Label();
            this.empruntésBtn = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprunts)).BeginInit();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 50);
            this.panel3.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(344, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des emprunts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(44, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de fin";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel9.Location = new System.Drawing.Point(47, 315);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(223, 1);
            this.panel9.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.effacerBtn);
            this.panel1.Controls.Add(this.emprunterBtn);
            this.panel1.Controls.Add(this.rendreBtn);
            this.panel1.Controls.Add(this.afficherBtn);
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 63);
            this.panel1.TabIndex = 5;
            // 
            // effacerBtn
            // 
            this.effacerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.effacerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.effacerBtn.FlatAppearance.BorderSize = 0;
            this.effacerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effacerBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.effacerBtn.Location = new System.Drawing.Point(700, 17);
            this.effacerBtn.Name = "effacerBtn";
            this.effacerBtn.Size = new System.Drawing.Size(116, 30);
            this.effacerBtn.TabIndex = 4;
            this.effacerBtn.Text = "EFFACER";
            this.effacerBtn.UseVisualStyleBackColor = false;
            this.effacerBtn.Click += new System.EventHandler(this.effacerBtn_Click);
            // 
            // afficherBtn
            // 
            this.afficherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.afficherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afficherBtn.FlatAppearance.BorderSize = 0;
            this.afficherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficherBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficherBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.afficherBtn.Location = new System.Drawing.Point(489, 17);
            this.afficherBtn.Name = "afficherBtn";
            this.afficherBtn.Size = new System.Drawing.Size(116, 30);
            this.afficherBtn.TabIndex = 2;
            this.afficherBtn.Text = "AFFICHER";
            this.afficherBtn.UseVisualStyleBackColor = false;
            this.afficherBtn.Click += new System.EventHandler(this.afficherBtn_Click);
            // 
            // rendreBtn
            // 
            this.rendreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.rendreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rendreBtn.Enabled = false;
            this.rendreBtn.FlatAppearance.BorderSize = 0;
            this.rendreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rendreBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.rendreBtn.Location = new System.Drawing.Point(267, 17);
            this.rendreBtn.Name = "rendreBtn";
            this.rendreBtn.Size = new System.Drawing.Size(116, 30);
            this.rendreBtn.TabIndex = 1;
            this.rendreBtn.Text = "RENDRE";
            this.rendreBtn.UseVisualStyleBackColor = false;
            this.rendreBtn.Click += new System.EventHandler(this.rendreBtn_Click);
            // 
            // emprunterBtn
            // 
            this.emprunterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.emprunterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emprunterBtn.FlatAppearance.BorderSize = 0;
            this.emprunterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emprunterBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emprunterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.emprunterBtn.Location = new System.Drawing.Point(50, 17);
            this.emprunterBtn.Name = "emprunterBtn";
            this.emprunterBtn.Size = new System.Drawing.Size(116, 30);
            this.emprunterBtn.TabIndex = 0;
            this.emprunterBtn.Text = "EMPRUNTER";
            this.emprunterBtn.UseVisualStyleBackColor = false;
            this.emprunterBtn.Click += new System.EventHandler(this.emprunterBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(44, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adhérent";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel8.Location = new System.Drawing.Point(47, 217);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(223, 1);
            this.panel8.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ouvrage";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel7.Location = new System.Drawing.Point(48, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 1);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel6.Location = new System.Drawing.Point(317, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 474);
            this.panel6.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateFinTxt);
            this.panel2.Controls.Add(this.adherentTxt);
            this.panel2.Controls.Add(this.ouvrageTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 413);
            this.panel2.TabIndex = 7;
            // 
            // dateFinTxt
            // 
            this.dateFinTxt.Location = new System.Drawing.Point(47, 293);
            this.dateFinTxt.Name = "dateFinTxt";
            this.dateFinTxt.Size = new System.Drawing.Size(223, 20);
            this.dateFinTxt.TabIndex = 20;
            // 
            // adherentTxt
            // 
            this.adherentTxt.FormattingEnabled = true;
            this.adherentTxt.Location = new System.Drawing.Point(47, 194);
            this.adherentTxt.Name = "adherentTxt";
            this.adherentTxt.Size = new System.Drawing.Size(223, 21);
            this.adherentTxt.TabIndex = 19;
            // 
            // ouvrageTxt
            // 
            this.ouvrageTxt.FormattingEnabled = true;
            this.ouvrageTxt.Location = new System.Drawing.Point(48, 96);
            this.ouvrageTxt.Name = "ouvrageTxt";
            this.ouvrageTxt.Size = new System.Drawing.Size(223, 21);
            this.ouvrageTxt.TabIndex = 18;
            // 
            // dataGridEmprunts
            // 
            this.dataGridEmprunts.AllowUserToAddRows = false;
            this.dataGridEmprunts.AllowUserToDeleteRows = false;
            this.dataGridEmprunts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmprunts.Location = new System.Drawing.Point(317, 79);
            this.dataGridEmprunts.Name = "dataGridEmprunts";
            this.dataGridEmprunts.ReadOnly = true;
            this.dataGridEmprunts.Size = new System.Drawing.Size(585, 382);
            this.dataGridEmprunts.TabIndex = 6;
            this.dataGridEmprunts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmprunts_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel5.Location = new System.Drawing.Point(318, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 1);
            this.panel5.TabIndex = 10;
            // 
            // aRendreBtn
            // 
            this.aRendreBtn.AutoSize = true;
            this.aRendreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aRendreBtn.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRendreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.aRendreBtn.Location = new System.Drawing.Point(481, 56);
            this.aRendreBtn.Name = "aRendreBtn";
            this.aRendreBtn.Size = new System.Drawing.Size(112, 16);
            this.aRendreBtn.TabIndex = 11;
            this.aRendreBtn.Text = "Livres à rendre";
            this.aRendreBtn.Click += new System.EventHandler(this.aRendreBtn_Click);
            // 
            // empruntésBtn
            // 
            this.empruntésBtn.AutoSize = true;
            this.empruntésBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empruntésBtn.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empruntésBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.empruntésBtn.Location = new System.Drawing.Point(625, 56);
            this.empruntésBtn.Name = "empruntésBtn";
            this.empruntésBtn.Size = new System.Drawing.Size(119, 16);
            this.empruntésBtn.TabIndex = 12;
            this.empruntésBtn.Text = "Livres empruntés";
            this.empruntésBtn.Click += new System.EventHandler(this.empruntésBtn_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel11.Location = new System.Drawing.Point(608, 57);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 16);
            this.panel11.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 1);
            this.panel4.TabIndex = 7;
            // 
            // EmpruntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.empruntésBtn);
            this.Controls.Add(this.aRendreBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridEmprunts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpruntForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpruntForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprunts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button effacerBtn;
        private System.Windows.Forms.Button afficherBtn;
        private System.Windows.Forms.Button rendreBtn;
        private System.Windows.Forms.Button emprunterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateFinTxt;
        private System.Windows.Forms.ComboBox adherentTxt;
        private System.Windows.Forms.ComboBox ouvrageTxt;
        private System.Windows.Forms.DataGridView dataGridEmprunts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label aRendreBtn;
        private System.Windows.Forms.Label empruntésBtn;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel4;
    }
}