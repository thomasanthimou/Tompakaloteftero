﻿namespace ΤοΜπακαλοτέφτερο
{
    partial class Neoeksodo
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
            this.button2 = new System.Windows.Forms.Button();
            this.saveeksodo = new System.Windows.Forms.Button();
            this.neoeksodotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.button2.Location = new System.Drawing.Point(155, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "ΑΚΥΡΩΣΗ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveeksodo
            // 
            this.saveeksodo.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.saveeksodo.Location = new System.Drawing.Point(8, 58);
            this.saveeksodo.Name = "saveeksodo";
            this.saveeksodo.Size = new System.Drawing.Size(107, 23);
            this.saveeksodo.TabIndex = 6;
            this.saveeksodo.Text = "ΑΠΟΘΗΚΕΥΣΗ";
            this.saveeksodo.UseVisualStyleBackColor = true;
            this.saveeksodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // neoeksodotextBox
            // 
            this.neoeksodotextBox.Location = new System.Drawing.Point(82, 16);
            this.neoeksodotextBox.Name = "neoeksodotextBox";
            this.neoeksodotextBox.Size = new System.Drawing.Size(173, 26);
            this.neoeksodotextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ΕΞΟΔΟ";
            // 
            // Neoeksodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 97);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveeksodo);
            this.Controls.Add(this.neoeksodotextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Neoeksodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ΝΕΟ ΕΞΟΔΟ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveeksodo;
        private System.Windows.Forms.TextBox neoeksodotextBox;
        private System.Windows.Forms.Label label1;
    }
}