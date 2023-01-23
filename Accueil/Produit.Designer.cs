namespace Accueil
{
    partial class Produit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRefprod = new System.Windows.Forms.TextBox();
            this.txtNomprod = new System.Windows.Forms.TextBox();
            this.txtPrixprod = new System.Windows.Forms.TextBox();
            this.txtQttprod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTypeprod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjoutProduit = new System.Windows.Forms.Button();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtChercheProduit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libelle";
            // 
            // txtRefprod
            // 
            this.txtRefprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefprod.Location = new System.Drawing.Point(125, 124);
            this.txtRefprod.Name = "txtRefprod";
            this.txtRefprod.Size = new System.Drawing.Size(100, 27);
            this.txtRefprod.TabIndex = 3;
            // 
            // txtNomprod
            // 
            this.txtNomprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomprod.Location = new System.Drawing.Point(125, 179);
            this.txtNomprod.Name = "txtNomprod";
            this.txtNomprod.Size = new System.Drawing.Size(282, 27);
            this.txtNomprod.TabIndex = 5;
            // 
            // txtPrixprod
            // 
            this.txtPrixprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixprod.Location = new System.Drawing.Point(125, 283);
            this.txtPrixprod.Name = "txtPrixprod";
            this.txtPrixprod.Size = new System.Drawing.Size(282, 27);
            this.txtPrixprod.TabIndex = 6;
            this.txtPrixprod.TextChanged += new System.EventHandler(this.txtChercheProduit_TextChanged);
            this.txtPrixprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrixprod_KeyPress);
            // 
            // txtQttprod
            // 
            this.txtQttprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQttprod.Location = new System.Drawing.Point(125, 338);
            this.txtQttprod.Name = "txtQttprod";
            this.txtQttprod.Size = new System.Drawing.Size(100, 27);
            this.txtQttprod.TabIndex = 7;
            this.txtQttprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQttprod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prix ";
            // 
            // comboBoxTypeprod
            // 
            this.comboBoxTypeprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeprod.FormattingEnabled = true;
            this.comboBoxTypeprod.Items.AddRange(new object[] {
            "Vin normaux",
            "Vin effervescent",
            "Vin doux et aromatises",
            "Produit Derive"});
            this.comboBoxTypeprod.Location = new System.Drawing.Point(125, 234);
            this.comboBoxTypeprod.Name = "comboBoxTypeprod";
            this.comboBoxTypeprod.Size = new System.Drawing.Size(282, 27);
            this.comboBoxTypeprod.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantite";
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Qtte});
            this.dataGridViewProduit.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewProduit.Location = new System.Drawing.Point(534, 100);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.Size = new System.Drawing.Size(498, 380);
            this.dataGridViewProduit.TabIndex = 11;
            this.dataGridViewProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduit_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Refprod";
            this.Column1.HeaderText = "Reference";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Typeprod";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Prixprod";
            this.Column3.HeaderText = "Prix";
            this.Column3.Name = "Column3";
            // 
            // Qtte
            // 
            this.Qtte.DataPropertyName = "Qttprod";
            this.Qtte.HeaderText = "Quantite";
            this.Qtte.Name = "Qtte";
            // 
            // btnAjoutProduit
            // 
            this.btnAjoutProduit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAjoutProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutProduit.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutProduit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjoutProduit.Location = new System.Drawing.Point(36, 438);
            this.btnAjoutProduit.Name = "btnAjoutProduit";
            this.btnAjoutProduit.Size = new System.Drawing.Size(140, 42);
            this.btnAjoutProduit.TabIndex = 12;
            this.btnAjoutProduit.Text = "Enregistrer";
            this.btnAjoutProduit.UseVisualStyleBackColor = false;
            this.btnAjoutProduit.Click += new System.EventHandler(this.btnAjoutProduit_Click);
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSupprimerProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerProduit.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerProduit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimerProduit.Location = new System.Drawing.Point(363, 438);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(146, 42);
            this.btnSupprimerProduit.TabIndex = 13;
            this.btnSupprimerProduit.Text = "Supprimer";
            this.btnSupprimerProduit.UseVisualStyleBackColor = false;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierProduit.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierProduit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifierProduit.Location = new System.Drawing.Point(199, 438);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(142, 42);
            this.btnModifierProduit.TabIndex = 14;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = false;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label6.Location = new System.Drawing.Point(235, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Les produits";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox3.Image = global::Accueil.Properties.Resources.edit_60px;
            this.pictureBox3.Location = new System.Drawing.Point(208, 446);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox2.Image = global::Accueil.Properties.Resources.Delete_60px;
            this.pictureBox2.Location = new System.Drawing.Point(370, 446);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox1.Image = global::Accueil.Properties.Resources.Donex;
            this.pictureBox1.Location = new System.Drawing.Point(40, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox5.Image = global::Accueil.Properties.Resources.search_60px;
            this.pictureBox5.Location = new System.Drawing.Point(791, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 74;
            this.pictureBox5.TabStop = false;
            // 
            // txtChercheProduit
            // 
            this.txtChercheProduit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txtChercheProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChercheProduit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChercheProduit.ForeColor = System.Drawing.Color.White;
            this.txtChercheProduit.Location = new System.Drawing.Point(534, 29);
            this.txtChercheProduit.Name = "txtChercheProduit";
            this.txtChercheProduit.Size = new System.Drawing.Size(257, 20);
            this.txtChercheProduit.TabIndex = 73;
            this.txtChercheProduit.TextChanged += new System.EventHandler(this.txtChercheProduit_TextChanged);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accueil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1059, 511);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtChercheProduit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.btnSupprimerProduit);
            this.Controls.Add(this.btnAjoutProduit);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTypeprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQttprod);
            this.Controls.Add(this.txtPrixprod);
            this.Controls.Add(this.txtNomprod);
            this.Controls.Add(this.txtRefprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRefprod;
        private System.Windows.Forms.TextBox txtNomprod;
        private System.Windows.Forms.TextBox txtPrixprod;
        private System.Windows.Forms.TextBox txtQttprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTypeprod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.Button btnAjoutProduit;
        private System.Windows.Forms.Button btnSupprimerProduit;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtte;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtChercheProduit;
    }
}