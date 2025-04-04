namespace Grootwarenhuis
{
    partial class Form1
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
            this.BtnVerder = new System.Windows.Forms.Button();
            this.RbFood = new System.Windows.Forms.RadioButton();
            this.RbNonFood = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVerder
            // 
            this.BtnVerder.Location = new System.Drawing.Point(78, 199);
            this.BtnVerder.Name = "BtnVerder";
            this.BtnVerder.Size = new System.Drawing.Size(75, 23);
            this.BtnVerder.TabIndex = 0;
            this.BtnVerder.Text = "Verder";
            this.BtnVerder.UseVisualStyleBackColor = true;
            this.BtnVerder.Click += new System.EventHandler(this.BtnVerder_Click);
            // 
            // RbFood
            // 
            this.RbFood.AutoSize = true;
            this.RbFood.Checked = true;
            this.RbFood.Location = new System.Drawing.Point(81, 104);
            this.RbFood.Name = "RbFood";
            this.RbFood.Size = new System.Drawing.Size(49, 17);
            this.RbFood.TabIndex = 1;
            this.RbFood.TabStop = true;
            this.RbFood.Text = "Food";
            this.RbFood.UseVisualStyleBackColor = true;
            // 
            // RbNonFood
            // 
            this.RbNonFood.AutoSize = true;
            this.RbNonFood.Location = new System.Drawing.Point(81, 148);
            this.RbNonFood.Name = "RbNonFood";
            this.RbNonFood.Size = new System.Drawing.Size(72, 17);
            this.RbNonFood.TabIndex = 2;
            this.RbNonFood.Text = "Non-Food";
            this.RbNonFood.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecteer een catogorie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbNonFood);
            this.Controls.Add(this.RbFood);
            this.Controls.Add(this.BtnVerder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerder;
        private System.Windows.Forms.RadioButton RbFood;
        private System.Windows.Forms.RadioButton RbNonFood;
        private System.Windows.Forms.Label label1;
    }
}

