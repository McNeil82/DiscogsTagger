using System;
using System.Windows.Forms;

namespace DiscogsTagger
{
    partial class DiscogsTagger
    {
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
    }
}
