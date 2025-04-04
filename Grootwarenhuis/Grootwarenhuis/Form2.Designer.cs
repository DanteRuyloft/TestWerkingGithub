namespace Grootwarenhuis
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerkoopprijs = new System.Windows.Forms.Button();
            this.CbBTW = new System.Windows.Forms.ComboBox();
            this.dtpHoudbaarheidsDatum = new System.Windows.Forms.DateTimePicker();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.TxtAankoopprijs = new System.Windows.Forms.TextBox();
            this.TxtNaam = new System.Windows.Forms.TextBox();
            this.frmUitvoer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aankoopprijs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BTW-Percentage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "houdbaar tot";
            // 
            // btnVerkoopprijs
            // 
            this.btnVerkoopprijs.Location = new System.Drawing.Point(25, 322);
            this.btnVerkoopprijs.Name = "btnVerkoopprijs";
            this.btnVerkoopprijs.Size = new System.Drawing.Size(217, 23);
            this.btnVerkoopprijs.TabIndex = 5;
            this.btnVerkoopprijs.Text = "Bereken verkoopprijs";
            this.btnVerkoopprijs.UseVisualStyleBackColor = true;
            this.btnVerkoopprijs.Click += new System.EventHandler(this.btnVerkoopprijs_Click);
            // 
            // CbBTW
            // 
            this.CbBTW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBTW.FormattingEnabled = true;
            this.CbBTW.Items.AddRange(new object[] {
            "6",
            "12",
            "21"});
            this.CbBTW.Location = new System.Drawing.Point(337, 200);
            this.CbBTW.Name = "CbBTW";
            this.CbBTW.Size = new System.Drawing.Size(200, 21);
            this.CbBTW.TabIndex = 8;
            // 
            // dtpHoudbaarheidsDatum
            // 
            this.dtpHoudbaarheidsDatum.Location = new System.Drawing.Point(337, 245);
            this.dtpHoudbaarheidsDatum.Name = "dtpHoudbaarheidsDatum";
            this.dtpHoudbaarheidsDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpHoudbaarheidsDatum.TabIndex = 11;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(337, 63);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(200, 20);
            this.txtProductID.TabIndex = 12;
            // 
            // TxtAankoopprijs
            // 
            this.TxtAankoopprijs.Location = new System.Drawing.Point(337, 155);
            this.TxtAankoopprijs.Name = "TxtAankoopprijs";
            this.TxtAankoopprijs.Size = new System.Drawing.Size(200, 20);
            this.TxtAankoopprijs.TabIndex = 14;
            // 
            // TxtNaam
            // 
            this.TxtNaam.Location = new System.Drawing.Point(337, 105);
            this.TxtNaam.Name = "TxtNaam";
            this.TxtNaam.Size = new System.Drawing.Size(200, 20);
            this.TxtNaam.TabIndex = 15;
            // 
            // frmUitvoer
            // 
            this.frmUitvoer.Location = new System.Drawing.Point(577, 66);
            this.frmUitvoer.Multiline = true;
            this.frmUitvoer.Name = "frmUitvoer";
            this.frmUitvoer.Size = new System.Drawing.Size(195, 158);
            this.frmUitvoer.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmUitvoer);
            this.Controls.Add(this.TxtNaam);
            this.Controls.Add(this.TxtAankoopprijs);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.dtpHoudbaarheidsDatum);
            this.Controls.Add(this.CbBTW);
            this.Controls.Add(this.btnVerkoopprijs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerkoopprijs;
        private System.Windows.Forms.ComboBox CbBTW;
        private System.Windows.Forms.DateTimePicker dtpHoudbaarheidsDatum;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox TxtAankoopprijs;
        private System.Windows.Forms.TextBox TxtNaam;
        private System.Windows.Forms.TextBox frmUitvoer;
    }
}