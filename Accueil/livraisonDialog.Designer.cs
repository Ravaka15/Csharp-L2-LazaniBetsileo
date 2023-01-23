namespace Accueil
{
    partial class LivraisonDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmerLivrer = new System.Windows.Forms.Button();
            this.btnAnnulerAchat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLivre = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomFournisseur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQttLivrer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLivre = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdFou = new System.Windows.Forms.TextBox();
            this.txtrefprod = new System.Windows.Forms.TextBox();
            this.txtNomprod = new System.Windows.Forms.TextBox();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.prixC = new System.Windows.Forms.TextBox();
            this.qttpro = new System.Windows.Forms.TextBox();
            this.pictureAdd = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnConfirmerLivrer);
            this.panel1.Controls.Add(this.btnAnnulerAchat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 458);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox2.Image = global::Accueil.Properties.Resources.file_delete_48px;
            this.pictureBox2.Location = new System.Drawing.Point(292, 423);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox1.Image = global::Accueil.Properties.Resources.Donex;
            this.pictureBox1.Location = new System.Drawing.Point(132, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmerLivrer
            // 
            this.btnConfirmerLivrer.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnConfirmerLivrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmerLivrer.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerLivrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmerLivrer.Location = new System.Drawing.Point(131, 418);
            this.btnConfirmerLivrer.Name = "btnConfirmerLivrer";
            this.btnConfirmerLivrer.Size = new System.Drawing.Size(116, 33);
            this.btnConfirmerLivrer.TabIndex = 76;
            this.btnConfirmerLivrer.Text = "Confirmer";
            this.btnConfirmerLivrer.UseVisualStyleBackColor = false;
            this.btnConfirmerLivrer.Click += new System.EventHandler(this.btnConfirmerAchat_Click);
            // 
            // btnAnnulerAchat
            // 
            this.btnAnnulerAchat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAnnulerAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerAchat.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerAchat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnulerAchat.Location = new System.Drawing.Point(290, 418);
            this.btnAnnulerAchat.Name = "btnAnnulerAchat";
            this.btnAnnulerAchat.Size = new System.Drawing.Size(105, 33);
            this.btnAnnulerAchat.TabIndex = 78;
            this.btnAnnulerAchat.Text = "Annuler";
            this.btnAnnulerAchat.UseVisualStyleBackColor = false;
            this.btnAnnulerAchat.Click += new System.EventHandler(this.btnAnnulerAchat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nom Fournisseur";
            // 
            // dateLivre
            // 
            this.dateLivre.Location = new System.Drawing.Point(131, 78);
            this.dateLivre.Name = "dateLivre";
            this.dateLivre.Size = new System.Drawing.Size(228, 20);
            this.dateLivre.TabIndex = 51;
            this.dateLivre.Value = new System.DateTime(2022, 3, 27, 17, 30, 28, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 50;
            this.label10.Text = "Date de livraison";
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFournisseur.Location = new System.Drawing.Point(131, 116);
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.Size = new System.Drawing.Size(264, 27);
            this.txtNomFournisseur.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "Livraison";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Produit";
            // 
            // txtQttLivrer
            // 
            this.txtQttLivrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQttLivrer.Location = new System.Drawing.Point(306, 278);
            this.txtQttLivrer.Name = "txtQttLivrer";
            this.txtQttLivrer.Size = new System.Drawing.Size(45, 26);
            this.txtQttLivrer.TabIndex = 71;
            this.txtQttLivrer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQttPannier_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Livrer";
            // 
            // dataGridViewLivre
            // 
            this.dataGridViewLivre.AllowUserToAddRows = false;
            this.dataGridViewLivre.AllowUserToDeleteRows = false;
            this.dataGridViewLivre.AllowUserToResizeColumns = false;
            this.dataGridViewLivre.AllowUserToResizeRows = false;
            this.dataGridViewLivre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLivre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLivre.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLivre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Qtte,
            this.Column1,
            this.refProd});
            this.dataGridViewLivre.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewLivre.Location = new System.Drawing.Point(132, 321);
            this.dataGridViewLivre.Name = "dataGridViewLivre";
            this.dataGridViewLivre.ReadOnly = true;
            this.dataGridViewLivre.RowHeadersVisible = false;
            this.dataGridViewLivre.Size = new System.Drawing.Size(263, 96);
            this.dataGridViewLivre.TabIndex = 73;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Nomprod";
            this.Column3.HeaderText = "Nom ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Qtte
            // 
            this.Qtte.DataPropertyName = "qttCom";
            this.Qtte.HeaderText = "Quantite livrer";
            this.Qtte.Name = "Qtte";
            this.Qtte.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "prixCom";
            this.Column1.HeaderText = "Prix livrer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // refProd
            // 
            this.refProd.DataPropertyName = "Refprod";
            this.refProd.HeaderText = "Reference";
            this.refProd.Name = "refProd";
            this.refProd.ReadOnly = true;
            // 
            // txtIdFou
            // 
            this.txtIdFou.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFou.Location = new System.Drawing.Point(329, 46);
            this.txtIdFou.Name = "txtIdFou";
            this.txtIdFou.Size = new System.Drawing.Size(83, 27);
            this.txtIdFou.TabIndex = 48;
            this.txtIdFou.Visible = false;
            // 
            // txtrefprod
            // 
            this.txtrefprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefprod.Location = new System.Drawing.Point(17, 228);
            this.txtrefprod.Name = "txtrefprod";
            this.txtrefprod.Size = new System.Drawing.Size(83, 27);
            this.txtrefprod.TabIndex = 80;
            this.txtrefprod.Visible = false;
            // 
            // txtNomprod
            // 
            this.txtNomprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomprod.Location = new System.Drawing.Point(131, 277);
            this.txtNomprod.Name = "txtNomprod";
            this.txtNomprod.Size = new System.Drawing.Size(173, 27);
            this.txtNomprod.TabIndex = 81;
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToAddRows = false;
            this.dataGridViewProduit.AllowUserToDeleteRows = false;
            this.dataGridViewProduit.AllowUserToResizeColumns = false;
            this.dataGridViewProduit.AllowUserToResizeRows = false;
            this.dataGridViewProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduit.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column2});
            this.dataGridViewProduit.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewProduit.Location = new System.Drawing.Point(132, 163);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.ReadOnly = true;
            this.dataGridViewProduit.RowHeadersVisible = false;
            this.dataGridViewProduit.Size = new System.Drawing.Size(263, 108);
            this.dataGridViewProduit.TabIndex = 82;
            this.dataGridViewProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduit_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nomprod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QttProd";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantite";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prixprod";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "refprod";
            this.Column2.HeaderText = "Reference";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 34);
            this.panel2.TabIndex = 83;
            // 
            // pictureExit
            // 
            this.pictureExit.Image = global::Accueil.Properties.Resources.close;
            this.pictureExit.Location = new System.Drawing.Point(406, 1);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(30, 30);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 80;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // prixC
            // 
            this.prixC.Location = new System.Drawing.Point(12, 277);
            this.prixC.Name = "prixC";
            this.prixC.Size = new System.Drawing.Size(100, 20);
            this.prixC.TabIndex = 84;
            this.prixC.Visible = false;
            // 
            // qttpro
            // 
            this.qttpro.Location = new System.Drawing.Point(12, 312);
            this.qttpro.Name = "qttpro";
            this.qttpro.Size = new System.Drawing.Size(100, 20);
            this.qttpro.TabIndex = 85;
            this.qttpro.Visible = false;
            // 
            // pictureAdd
            // 
            this.pictureAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureAdd.Image = global::Accueil.Properties.Resources.add;
            this.pictureAdd.Location = new System.Drawing.Point(354, 277);
            this.pictureAdd.Name = "pictureAdd";
            this.pictureAdd.Size = new System.Drawing.Size(41, 27);
            this.pictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAdd.TabIndex = 69;
            this.pictureAdd.TabStop = false;
            this.pictureAdd.Click += new System.EventHandler(this.pictureAdd_Click);
            // 
            // LivraisonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 492);
            this.Controls.Add(this.qttpro);
            this.Controls.Add(this.prixC);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.txtNomprod);
            this.Controls.Add(this.txtrefprod);
            this.Controls.Add(this.txtIdFou);
            this.Controls.Add(this.dataGridViewLivre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQttLivrer);
            this.Controls.Add(this.pictureAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLivre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomFournisseur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LivraisonDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pannier";
            this.Load += new System.EventHandler(this.Pannier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateLivre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomFournisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQttLivrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLivre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAnnulerAchat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmerLivrer;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.TextBox txtIdFou;
        private System.Windows.Forms.TextBox txtrefprod;
        private System.Windows.Forms.TextBox txtNomprod;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox prixC;
        private System.Windows.Forms.TextBox qttpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn refProd;
    }
}