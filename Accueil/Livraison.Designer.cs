namespace Accueil
{
    partial class Livraison
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewFrsLiv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtChercheFournisseurLi = new System.Windows.Forms.TextBox();
            this.txtNomFrs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdFrs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewLivraison = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPannier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrsLiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivraison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPannier)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(61, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Les Fournisseurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(683, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 30);
            this.label3.TabIndex = 49;
            this.label3.Text = "Les Livraisons";
            // 
            // dataGridViewFrsLiv
            // 
            this.dataGridViewFrsLiv.AllowUserToAddRows = false;
            this.dataGridViewFrsLiv.AllowUserToDeleteRows = false;
            this.dataGridViewFrsLiv.AllowUserToResizeColumns = false;
            this.dataGridViewFrsLiv.AllowUserToResizeRows = false;
            this.dataGridViewFrsLiv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFrsLiv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFrsLiv.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewFrsLiv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFrsLiv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFrsLiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFrsLiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFrsLiv.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewFrsLiv.Location = new System.Drawing.Point(45, 174);
            this.dataGridViewFrsLiv.Name = "dataGridViewFrsLiv";
            this.dataGridViewFrsLiv.ReadOnly = true;
            this.dataGridViewFrsLiv.RowHeadersVisible = false;
            this.dataGridViewFrsLiv.Size = new System.Drawing.Size(331, 298);
            this.dataGridViewFrsLiv.TabIndex = 70;
            this.dataGridViewFrsLiv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFrsLiv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdFrs";
            this.Column1.HeaderText = "Identifiant";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NomFrs";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox5.Image = global::Accueil.Properties.Resources.search_60px;
            this.pictureBox5.Location = new System.Drawing.Point(252, 149);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 88;
            this.pictureBox5.TabStop = false;
            // 
            // txtChercheFournisseurLi
            // 
            this.txtChercheFournisseurLi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txtChercheFournisseurLi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChercheFournisseurLi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChercheFournisseurLi.ForeColor = System.Drawing.Color.White;
            this.txtChercheFournisseurLi.Location = new System.Drawing.Point(45, 149);
            this.txtChercheFournisseurLi.Name = "txtChercheFournisseurLi";
            this.txtChercheFournisseurLi.Size = new System.Drawing.Size(205, 24);
            this.txtChercheFournisseurLi.TabIndex = 87;
            this.txtChercheFournisseurLi.TextChanged += new System.EventHandler(this.txtChercheFournisseurLi_TextChanged);
            // 
            // txtNomFrs
            // 
            this.txtNomFrs.BackColor = System.Drawing.Color.White;
            this.txtNomFrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomFrs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFrs.Location = new System.Drawing.Point(110, 116);
            this.txtNomFrs.Name = "txtNomFrs";
            this.txtNomFrs.Size = new System.Drawing.Size(266, 20);
            this.txtNomFrs.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 85;
            this.label4.Text = "Nom";
            // 
            // txtIdFrs
            // 
            this.txtIdFrs.BackColor = System.Drawing.Color.White;
            this.txtIdFrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFrs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFrs.Location = new System.Drawing.Point(114, 73);
            this.txtIdFrs.Name = "txtIdFrs";
            this.txtIdFrs.Size = new System.Drawing.Size(113, 20);
            this.txtIdFrs.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 83;
            this.label5.Text = "Identifiant";
            // 
            // dataGridViewLivraison
            // 
            this.dataGridViewLivraison.AllowUserToAddRows = false;
            this.dataGridViewLivraison.AllowUserToDeleteRows = false;
            this.dataGridViewLivraison.AllowUserToResizeColumns = false;
            this.dataGridViewLivraison.AllowUserToResizeRows = false;
            this.dataGridViewLivraison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLivraison.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLivraison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.Column6,
            this.Column8});
            this.dataGridViewLivraison.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewLivraison.Location = new System.Drawing.Point(488, 174);
            this.dataGridViewLivraison.Name = "dataGridViewLivraison";
            this.dataGridViewLivraison.ReadOnly = true;
            this.dataGridViewLivraison.RowHeadersVisible = false;
            this.dataGridViewLivraison.Size = new System.Drawing.Size(559, 298);
            this.dataGridViewLivraison.TabIndex = 89;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdCli";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identifiant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NomCli";
            this.Column7.HeaderText = "Nom";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Nomprod";
            this.Column6.HeaderText = "Nom produit";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "QttCom";
            this.Column8.HeaderText = "Quantite";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(484, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Cliquer ici pour livrer de produit     -->";
            // 
            // pictureBoxPannier
            // 
            this.pictureBoxPannier.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBoxPannier.Image = global::Accueil.Properties.Resources.gold_bars_60px1;
            this.pictureBoxPannier.Location = new System.Drawing.Point(797, 98);
            this.pictureBoxPannier.Name = "pictureBoxPannier";
            this.pictureBoxPannier.Size = new System.Drawing.Size(44, 37);
            this.pictureBoxPannier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPannier.TabIndex = 92;
            this.pictureBoxPannier.TabStop = false;
            this.pictureBoxPannier.Click += new System.EventHandler(this.pictureBoxPannier_Click);
            // 
            // Livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accueil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1059, 511);
            this.Controls.Add(this.pictureBoxPannier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLivraison);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtChercheFournisseurLi);
            this.Controls.Add(this.txtNomFrs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdFrs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewFrsLiv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Livraison";
            this.Text = "Achats";
            this.Load += new System.EventHandler(this.Livraison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrsLiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivraison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPannier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewFrsLiv;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtChercheFournisseurLi;
        private System.Windows.Forms.TextBox txtNomFrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdFrs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridViewLivraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPannier;
    }
}