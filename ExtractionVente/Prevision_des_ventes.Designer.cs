using System;

namespace ExtractionVente
{
    partial class Prevision_des_ventes
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
            this.comboProduits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boutonCalculVente = new System.Windows.Forms.Button();
            this.timePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timePicketFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCommandeEtExperdiees = new System.Windows.Forms.RadioButton();
            this.radioTypeCommandees = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.labelDescProduit = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboProduits
            // 
            this.comboProduits.FormattingEnabled = true;
            this.comboProduits.Location = new System.Drawing.Point(189, 87);
            this.comboProduits.Name = "comboProduits";
            this.comboProduits.Size = new System.Drawing.Size(200, 21);
            this.comboProduits.TabIndex = 3;
            this.comboProduits.SelectedIndexChanged += new System.EventHandler(this.comboProduits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prevision des ventes V0.1.2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Veuillez séléctionner un produit";
            // 
            // boutonCalculVente
            // 
            this.boutonCalculVente.Location = new System.Drawing.Point(736, 87);
            this.boutonCalculVente.Name = "boutonCalculVente";
            this.boutonCalculVente.Size = new System.Drawing.Size(209, 96);
            this.boutonCalculVente.TabIndex = 5;
            this.boutonCalculVente.Text = "Calculer les ventes";
            this.boutonCalculVente.UseVisualStyleBackColor = true;
            this.boutonCalculVente.Click += new System.EventHandler(this.boutonCalculVente_Click);
            // 
            // timePickerDepart
            // 
            this.timePickerDepart.Location = new System.Drawing.Point(189, 138);
            this.timePickerDepart.Name = "timePickerDepart";
            this.timePickerDepart.Size = new System.Drawing.Size(200, 20);
            this.timePickerDepart.TabIndex = 6;
            this.timePickerDepart.Value = new System.DateTime(2011, 4, 6, 0, 0, 0, 0);
            this.timePickerDepart.ValueChanged += new System.EventHandler(this.timePickerDepart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date de départ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date de fin";
            // 
            // timePicketFin
            // 
            this.timePicketFin.Location = new System.Drawing.Point(189, 163);
            this.timePicketFin.Name = "timePicketFin";
            this.timePicketFin.Size = new System.Drawing.Size(200, 20);
            this.timePicketFin.TabIndex = 8;
            this.timePicketFin.ValueChanged += new System.EventHandler(this.timePicketFin_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCommandeEtExperdiees);
            this.groupBox1.Controls.Add(this.radioTypeCommandees);
            this.groupBox1.Location = new System.Drawing.Point(453, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 95);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de commande";
            // 
            // radioCommandeEtExperdiees
            // 
            this.radioCommandeEtExperdiees.AutoSize = true;
            this.radioCommandeEtExperdiees.Location = new System.Drawing.Point(6, 42);
            this.radioCommandeEtExperdiees.Name = "radioCommandeEtExperdiees";
            this.radioCommandeEtExperdiees.Size = new System.Drawing.Size(152, 17);
            this.radioCommandeEtExperdiees.TabIndex = 11;
            this.radioCommandeEtExperdiees.TabStop = true;
            this.radioCommandeEtExperdiees.Text = "Commandées et expediées";
            this.radioCommandeEtExperdiees.UseVisualStyleBackColor = true;
            this.radioCommandeEtExperdiees.CheckedChanged += new System.EventHandler(this.radioCommandeEtExperdiees_CheckedChanged);
            // 
            // radioTypeCommandees
            // 
            this.radioTypeCommandees.AutoSize = true;
            this.radioTypeCommandees.Checked = true;
            this.radioTypeCommandees.Location = new System.Drawing.Point(6, 19);
            this.radioTypeCommandees.Name = "radioTypeCommandees";
            this.radioTypeCommandees.Size = new System.Drawing.Size(89, 17);
            this.radioTypeCommandees.TabIndex = 10;
            this.radioTypeCommandees.TabStop = true;
            this.radioTypeCommandees.Text = "Commandées";
            this.radioTypeCommandees.UseVisualStyleBackColor = true;
            this.radioTypeCommandees.CheckedChanged += new System.EventHandler(this.radioTypeCommandees_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 21);
            this.button1.TabIndex = 12;
            this.button1.Text = "V";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 725);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1191, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 502);
            this.dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1071, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "export to excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDescProduit
            // 
            this.labelDescProduit.AutoSize = true;
            this.labelDescProduit.Location = new System.Drawing.Point(187, 113);
            this.labelDescProduit.Name = "labelDescProduit";
            this.labelDescProduit.Size = new System.Drawing.Size(130, 13);
            this.labelDescProduit.TabIndex = 18;
            this.labelDescProduit.Text = "Aucun produit séléctionné";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1081, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Prevision_des_ventes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 747);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelDescProduit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timePicketFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePickerDepart);
            this.Controls.Add(this.boutonCalculVente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboProduits);
            this.Controls.Add(this.label3);
            this.Name = "Prevision_des_ventes";
            this.Text = "Prévision des ventes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FermetureFenetre);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProduits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boutonCalculVente;
        private System.Windows.Forms.DateTimePicker timePickerDepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timePicketFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelDescProduit;
        private System.Windows.Forms.RadioButton radioCommandeEtExperdiees;
        private System.Windows.Forms.RadioButton radioTypeCommandees;
        private System.Windows.Forms.Button button3;
    }
}