using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace DiscogsTagger
{
    partial class DiscogsTagger
    {
        private IContainer components = null;
        private TextBox resleaseNumberTextBox;
        private Button searchButton;
        private TextBox debugTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            resleaseNumberTextBox = new TextBox();
            searchButton = new Button();
            debugTextBox = new TextBox();
            SuspendLayout();

            resleaseNumberTextBox.Location = new Point(13, 13);
            resleaseNumberTextBox.Name = "txb_release";
            resleaseNumberTextBox.Size = new Size(100, 20);
            resleaseNumberTextBox.TabIndex = 0;
            resleaseNumberTextBox.KeyPress += new KeyPressEventHandler(releaseNumberTextBoxKeyPressEvent);

            searchButton.Location = new Point(197, 9);
            searchButton.Name = "btn_search";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += new EventHandler(searchButtonClickEvent);
            
            debugTextBox.Location = new Point(13, 187);
            debugTextBox.Multiline = true;
            debugTextBox.Name = "txb_debug";
            debugTextBox.Size = new Size(259, 66);
            debugTextBox.TabIndex = 2;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(284, 265);
            Controls.Add(debugTextBox);
            Controls.Add(searchButton);
            Controls.Add(resleaseNumberTextBox);
            Name = "DiscogsTagger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discogs-Tagger";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

