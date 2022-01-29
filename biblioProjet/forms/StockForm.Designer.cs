namespace biblioProjet.forms.stock
{
    partial class StockForm
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
            this.livreTxt = new System.Windows.Forms.ComboBox();
            this.augmenterBtn = new System.Windows.Forms.Button();
            this.diminuerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.quantiteTxt = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.afficherBtn = new System.Windows.Forms.Button();
            this.effacerBtn = new System.Windows.Forms.Button();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // livreTxt
            // 
            this.livreTxt.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livreTxt.FormattingEnabled = true;
            this.livreTxt.Location = new System.Drawing.Point(90, 63);
            this.livreTxt.Name = "livreTxt";
            this.livreTxt.Size = new System.Drawing.Size(250, 25);
            this.livreTxt.TabIndex = 62;
            // 
            // augmenterBtn
            // 
            this.augmenterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.augmenterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.augmenterBtn.FlatAppearance.BorderSize = 0;
            this.augmenterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.augmenterBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.augmenterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.augmenterBtn.Location = new System.Drawing.Point(90, 233);
            this.augmenterBtn.Name = "augmenterBtn";
            this.augmenterBtn.Size = new System.Drawing.Size(250, 37);
            this.augmenterBtn.TabIndex = 63;
            this.augmenterBtn.Text = "AUGMENTER";
            this.augmenterBtn.UseVisualStyleBackColor = false;
            this.augmenterBtn.Click += new System.EventHandler(this.augmenterBtn_Click);
            // 
            // diminuerBtn
            // 
            this.diminuerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.diminuerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diminuerBtn.FlatAppearance.BorderSize = 0;
            this.diminuerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diminuerBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diminuerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.diminuerBtn.Location = new System.Drawing.Point(90, 293);
            this.diminuerBtn.Name = "diminuerBtn";
            this.diminuerBtn.Size = new System.Drawing.Size(250, 37);
            this.diminuerBtn.TabIndex = 64;
            this.diminuerBtn.Text = "DIMINUER";
            this.diminuerBtn.UseVisualStyleBackColor = false;
            this.diminuerBtn.Click += new System.EventHandler(this.diminuerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(87, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Livre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(87, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Quantité";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel11.Location = new System.Drawing.Point(90, 186);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(250, 1);
            this.panel11.TabIndex = 67;
            // 
            // quantiteTxt
            // 
            this.quantiteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantiteTxt.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.quantiteTxt.Location = new System.Drawing.Point(90, 166);
            this.quantiteTxt.Name = "quantiteTxt";
            this.quantiteTxt.Size = new System.Drawing.Size(250, 16);
            this.quantiteTxt.TabIndex = 66;
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
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 50);
            this.panel3.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(344, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion du stock";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.effacerBtn);
            this.panel1.Controls.Add(this.afficherBtn);
            this.panel1.Controls.Add(this.diminuerBtn);
            this.panel1.Controls.Add(this.livreTxt);
            this.panel1.Controls.Add(this.augmenterBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.quantiteTxt);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 471);
            this.panel1.TabIndex = 71;
            // 
            // afficherBtn
            // 
            this.afficherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.afficherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afficherBtn.FlatAppearance.BorderSize = 0;
            this.afficherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficherBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficherBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.afficherBtn.Location = new System.Drawing.Point(90, 353);
            this.afficherBtn.Name = "afficherBtn";
            this.afficherBtn.Size = new System.Drawing.Size(250, 37);
            this.afficherBtn.TabIndex = 69;
            this.afficherBtn.Text = "AFFICHER";
            this.afficherBtn.UseVisualStyleBackColor = false;
            this.afficherBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // effacerBtn
            // 
            this.effacerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.effacerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.effacerBtn.FlatAppearance.BorderSize = 0;
            this.effacerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effacerBtn.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.effacerBtn.Location = new System.Drawing.Point(90, 413);
            this.effacerBtn.Name = "effacerBtn";
            this.effacerBtn.Size = new System.Drawing.Size(250, 37);
            this.effacerBtn.TabIndex = 70;
            this.effacerBtn.Text = "EFFACER";
            this.effacerBtn.UseVisualStyleBackColor = false;
            this.effacerBtn.Click += new System.EventHandler(this.effacerBtn_Click);
            // 
            // dataGridStock
            // 
            this.dataGridStock.AllowUserToAddRows = false;
            this.dataGridStock.AllowUserToDeleteRows = false;
            this.dataGridStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(433, 49);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.ReadOnly = true;
            this.dataGridStock.Size = new System.Drawing.Size(468, 474);
            this.dataGridStock.TabIndex = 72;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel15.Location = new System.Drawing.Point(433, 49);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1, 474);
            this.panel15.TabIndex = 73;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel12.Location = new System.Drawing.Point(0, 49);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(901, 1);
            this.panel12.TabIndex = 74;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.dataGridStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stockForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button augmenterBtn;
        private System.Windows.Forms.Button diminuerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox quantiteTxt;
        private System.Windows.Forms.ComboBox livreTxt;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button effacerBtn;
        private System.Windows.Forms.Button afficherBtn;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel12;
    }
}