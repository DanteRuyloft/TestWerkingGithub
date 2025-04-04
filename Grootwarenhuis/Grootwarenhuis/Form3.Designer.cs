namespace Grootwarenhuis
{
    partial class Form3
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
            this.cbBTW = new System.Windows.Forms.ComboBox();
            this.btnVerkoopprijs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbElektrisch = new System.Windows.Forms.CheckBox();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.txtAankoopprijs = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.frmUitvoer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbBTW
            // 
            this.cbBTW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBTW.FormattingEnabled = true;
            this.cbBTW.Items.AddRange(new object[] {
            "6",
            "12",
            "21"});
            this.cbBTW.Location = new System.Drawing.Point(197, 231);
            this.cbBTW.Name = "cbBTW";
            this.cbBTW.Size = new System.Drawing.Size(121, 21);
            this.cbBTW.TabIndex = 19;
            // 
            // btnVerkoopprijs
            // 
            this.btnVerkoopprijs.Location = new System.Drawing.Point(197, 287);
            this.btnVerkoopprijs.Name = "btnVerkoopprijs";
            this.btnVerkoopprijs.Size = new System.Drawing.Size(121, 23);
            this.btnVerkoopprijs.TabIndex = 16;
            this.btnVerkoopprijs.Text = "Bereken Verkoopprijs";
            this.btnVerkoopprijs.UseVisualStyleBackColor = true;
            this.btnVerkoopprijs.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Btw-Percentage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aankoopprijs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ProductID";
            // 
            // cbElektrisch
            // 
            this.cbElektrisch.AutoSize = true;
            this.cbElektrisch.Location = new System.Drawing.Point(31, 287);
            this.cbElektrisch.Name = "cbElektrisch";
            this.cbElektrisch.Size = new System.Drawing.Size(110, 17);
            this.cbElektrisch.TabIndex = 22;
            this.cbElektrisch.Text = "Elektirsch Toestel";
            this.cbElektrisch.UseVisualStyleBackColor = true;
            // 
            // TxtProductID
            // 
            this.TxtProductID.Location = new System.Drawing.Point(197, 90);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(121, 20);
            this.TxtProductID.TabIndex = 23;
            // 
            // txtAankoopprijs
            // 
            this.txtAankoopprijs.Location = new System.Drawing.Point(197, 187);
            this.txtAankoopprijs.Name = "txtAankoopprijs";
            this.txtAankoopprijs.Size = new System.Drawing.Size(121, 20);
            this.txtAankoopprijs.TabIndex = 24;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(197, 136);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(121, 20);
            this.txtNaam.TabIndex = 25;
            // 
            // frmUitvoer
            // 
            this.frmUitvoer.Location = new System.Drawing.Point(432, 90);
            this.frmUitvoer.Multiline = true;
            this.frmUitvoer.Name = "frmUitvoer";
            this.frmUitvoer.Size = new System.Drawing.Size(304, 162);
            this.frmUitvoer.TabIndex = 26;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmUitvoer);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtAankoopprijs);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.cbElektrisch);
            this.Controls.Add(this.cbBTW);
            this.Controls.Add(this.btnVerkoopprijs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBTW;
        private System.Windows.Forms.Button btnVerkoopprijs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbElektrisch;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.TextBox txtAankoopprijs;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox frmUitvoer;
    }
}