using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FileSplitter
{
    public partial class FileSplitterForm : Form
    {
        #region PRIVATE VARIABLES

        private string FileName { get; set; }
        private int EmailCount { get; set; }
        private EmailSplitter EmailSplitter { get; set; }

        #endregion

        #region EVENT HANDLERS

        public FileSplitterForm()
        {
            InitializeComponent();
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            FileName = ofdBrowse.FileName;
            txtFilePath.Text = FileName;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdBrowse.ShowDialog(this);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                valMessage.Text = "Wybierz plik do podziału";
                return;
            }
            else if (EmailCount < 1)
            {
                valMessage.Text = "Podaj liczbę adresów w pliku";
                return;
            }

            // All validations passed
            valMessage.Text = string.Empty;

            Process();
        }

        private void txtFileCount_TextChanged(object sender, EventArgs e)
        {
            int emailCount = 0;

            if (int.TryParse(txtEmailCount.Text, out emailCount))
            {
                EmailCount = emailCount;
            }
            else
            {
                valMessage.Text = "Niepoprawna liczba adresów";
            }
        }

        #endregion

        #region PRIVATE METHODS

        private void Process()
        {
            EmailSplitter = new EmailSplitter(FileName, EmailCount);
            EmailSplitter.ProcessFile();

            valMessage.Text = "Plik został podzielony";
        }

        #endregion

    }
}
