﻿namespace DiscogsTagger
{
    partial class DiscogsTagger
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.resleaseNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.releaseNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resleaseNumberTextBox
            // 
            this.resleaseNumberTextBox.Location = new System.Drawing.Point(13, 13);
            this.resleaseNumberTextBox.Name = "resleaseNumberTextBox";
            this.resleaseNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.resleaseNumberTextBox.TabIndex = 0;
            this.resleaseNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.releaseNumberTextBoxKeyPressEvent);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(247, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButtonClickEvent);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(13, 40);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(119, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(13, 67);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 4;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(119, 70);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // releaseNumberLabel
            // 
            this.releaseNumberLabel.AutoSize = true;
            this.releaseNumberLabel.Location = new System.Drawing.Point(119, 16);
            this.releaseNumberLabel.Name = "releaseNumberLabel";
            this.releaseNumberLabel.Size = new System.Drawing.Size(86, 13);
            this.releaseNumberLabel.TabIndex = 6;
            this.releaseNumberLabel.Text = "Release Number";
            // 
            // DiscogsTagger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 437);
            this.Controls.Add(this.releaseNumberLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resleaseNumberTextBox);
            this.Name = "DiscogsTagger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discogs-Tagger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resleaseNumberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label releaseNumberLabel;
    }
}