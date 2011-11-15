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
        private string releaseNumber = "";

        public DiscogsTagger()
        {
            InitializeComponent();
        }

        private void handleReleaseNumber()
        {
            if (validReleaseNumber())
            {
                releaseNumber = resleaseNumberTextBox.Text;
            }
            else
            {
                releaseNumber = "";
            }

            debugTextBox.Text = releaseNumber;
        }

        private bool validReleaseNumber()
        {
            int intParse;
            return Int32.TryParse(resleaseNumberTextBox.Text, NumberStyles.None, null, out intParse);
        }
    }
}
