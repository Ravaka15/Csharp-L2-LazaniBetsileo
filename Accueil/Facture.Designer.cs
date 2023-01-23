namespace Accueil
{
    partial class Facture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAchats = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnActualiserFournisseur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAchats
            // 
            this.dataGridViewAchats.AllowUserToAddRows = false;
            this.dataGridViewAchats.AllowUserToDeleteRows = false;
            this.dataGridViewAchats.AllowUserToResizeColumns = false;
            this.dataGridViewAchats.AllowUserToResizeRows = false;
            this.dataGridViewAchats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAchats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAchats.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAchats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAchats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAchats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.Column6,
            this.Column8});
            this.dataGridViewAchats.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewAchats.Location = new System.Drawing.Point(99, 72);
            this.dataGridViewAchats.Name = "dataGridViewAchats";
            this.dataGridViewAchats.ReadOnly = true;
            this.dataGridViewAchats.RowHeadersVisible = false;
            this.dataGridViewAchats.Size = new System.Drawing.Size(792, 365);
            this.dataGridViewAchats.TabIndex = 62;
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox4.Image = global::Accueil.Properties.Resources.print_60px;
            this.pictureBox4.Location = new System.Drawing.Point(871, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            // 
            // btnActualiserFournisseur
            // 
            this.btnActualiserFournisseur.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnActualiserFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiserFournisseur.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiserFournisseur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualiserFournisseur.Location = new System.Drawing.Point(864, 1);
            this.btnActualiserFournisseur.Name = "btnActualiserFournisseur";
            this.btnActualiserFournisseur.Size = new System.Drawing.Size(146, 42);
            this.btnActualiserFournisseur.TabIndex = 63;
            this.btnActualiserFournisseur.Text = "Imprimer";
            this.btnActualiserFournisseur.UseVisualStyleBackColor = false;
            this.btnActualiserFournisseur.Click += new System.EventHandler(this.btnActualiserFournisseur_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accueil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1075, 550);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnActualiserFournisseur);
            this.Controls.Add(this.dataGridViewAchats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facture";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAchats;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnActualiserFournisseur;
    }
}