using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DiscogsTagger
{
    public partial class DiscogsTagger : Form
    {
        private DiscogsClient discogsClient = new DiscogsClient();

        public DiscogsTagger()
        {
            InitializeComponent();
        }

        private void searchButtonClickEvent(object sender, EventArgs e)
        {
            handleReleaseNumber();
        }

        private void releaseNumberTextBoxKeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                handleReleaseNumber();
            }
        }

        private void handleReleaseNumber()
        {
            if (validReleaseNumber())
            {
                Release release = discogsClient.getReleaseContent(resleaseNumberTextBox.Text);
                titleTextBox.Text = release.Title;
            }
        }

        private bool validReleaseNumber()
        {
            int intParse;
            return Int32.TryParse(resleaseNumberTextBox.Text, NumberStyles.None, null, out intParse);
        }
    }
}
