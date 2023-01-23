namespace Accueil
{
    partial class Pannier
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
            this.btnConfirmerAchat = new System.Windows.Forms.Button();
            this.btnAnnulerAchat = new System.Windows.Forms.Button();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.dateCommande = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureAdd = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQttPannier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPannier = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixtotal = new System.Windows.Forms.TextBox();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.txtrefprod = new System.Windows.Forms.TextBox();
            this.txtNomprod = new System.Windows.Forms.TextBox();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prixC = new System.Windows.Forms.TextBox();
            this.qttpro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPannier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnConfirmerAchat);
            this.panel1.Controls.Add(this.btnAnnulerAchat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 461);
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
            // btnConfirmerAchat
            // 
            this.btnConfirmerAchat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnConfirmerAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmerAchat.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerAchat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmerAchat.Location = new System.Drawing.Point(131, 418);
            this.btnConfirmerAchat.Name = "btnConfirmerAchat";
            this.btnConfirmerAchat.Size = new System.Drawing.Size(116, 33);
            this.btnConfirmerAchat.TabIndex = 76;
            this.btnConfirmerAchat.Text = "Confirmer";
            this.btnConfirmerAchat.UseVisualStyleBackColor = false;
            this.btnConfirmerAchat.Click += new System.EventHandler(this.btnConfirmerAchat_Click);
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
            // dateCommande
            // 
            this.dateCommande.Location = new System.Drawing.Point(131, 78);
            this.dateCommande.Name = "dateCommande";
            this.dateCommande.Size = new System.Drawing.Size(228, 20);
            this.dateCommande.TabIndex = 51;
            this.dateCommande.Value = new System.DateTime(2022, 3, 27, 17, 30, 28, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 50;
            this.label10.Text = "Date d\'Achat";
            // 
            // txtNomCli
            // 
            this.txtNomCli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCli.Location = new System.Drawing.Point(131, 116);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(264, 27);
            this.txtNomCli.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "Pannier";
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
            // txtQttPannier
            // 
            this.txtQttPannier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQttPannier.Location = new System.Drawing.Point(306, 278);
            this.txtQttPannier.Name = "txtQttPannier";
            this.txtQttPannier.Size = new System.Drawing.Size(45, 26);
            this.txtQttPannier.TabIndex = 71;
            this.txtQttPannier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQttPannier_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Achats";
            // 
            // dataGridViewPannier
            // 
            this.dataGridViewPannier.AllowUserToAddRows = false;
            this.dataGridViewPannier.AllowUserToDeleteRows = false;
            this.dataGridViewPannier.AllowUserToResizeColumns = false;
            this.dataGridViewPannier.AllowUserToResizeRows = false;
            this.dataGridViewPannier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPannier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPannier.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPannier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPannier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPannier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Qtte,
            this.Column1,
            this.refProd});
            this.dataGridViewPannier.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewPannier.Location = new System.Drawing.Point(132, 321);
            this.dataGridViewPannier.Name = "dataGridViewPannier";
            this.dataGridViewPannier.ReadOnly = true;
            this.dataGridViewPannier.RowHeadersVisible = false;
            this.dataGridViewPannier.Size = new System.Drawing.Size(263, 96);
            this.dataGridViewPannier.TabIndex = 73;
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
            this.Qtte.HeaderText = "Quantite achat";
            this.Qtte.Name = "Qtte";
            this.Qtte.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "prixCom";
            this.Column1.HeaderText = "Prix achat";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Prix Total";
            // 
            // txtPrixtotal
            // 
            this.txtPrixtotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixtotal.Location = new System.Drawing.Point(132, 416);
            this.txtPrixtotal.Name = "txtPrixtotal";
            this.txtPrixtotal.Size = new System.Drawing.Size(263, 27);
            this.txtPrixtotal.TabIndex = 75;
            this.txtPrixtotal.TextChanged += new System.EventHandler(this.txtPrixtotal_TextChanged);
            // 
            // txtIdCli
            // 
            this.txtIdCli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCli.Location = new System.Drawing.Point(329, 46);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(83, 27);
            this.txtIdCli.TabIndex = 48;
            this.txtIdCli.Visible = false;
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
            this.panel2.Size = new System.Drawing.Size(436, 31);
            this.panel2.TabIndex = 83;
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
            // Pannier
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
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.txtPrixtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPannier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQttPannier);
            this.Controls.Add(this.pictureAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateCommande);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pannier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pannier";
            this.Load += new System.EventHandler(this.Pannier_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPannier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateCommande;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQttPannier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPannier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixtotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAnnulerAchat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmerAchat;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.TextBox txtIdCli;
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