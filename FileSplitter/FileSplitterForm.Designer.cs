namespace FileSplitter
{
    partial class FileSplitterForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.ofdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailCount = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.valMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(374, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Przeglądaj";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz plik do podziału";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(141, 6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(220, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // ofdBrowse
            // 
            this.ofdBrowse.FileName = "openFileDialog1";
            this.ofdBrowse.Filter = "Pliki tekstowe |*.txt";
            this.ofdBrowse.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba adresów w pliku";
            // 
            // txtEmailCount
            // 
            this.txtEmailCount.Location = new System.Drawing.Point(141, 32);
            this.txtEmailCount.Name = "txtEmailCount";
            this.txtEmailCount.Size = new System.Drawing.Size(220, 20);
            this.txtEmailCount.TabIndex = 5;
            this.txtEmailCount.TextChanged += new System.EventHandler(this.txtFileCount_TextChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(374, 30);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Podziel";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // valMessage
            // 
            this.valMessage.AutoSize = true;
            this.valMessage.ForeColor = System.Drawing.Color.Red;
            this.valMessage.Location = new System.Drawing.Point(12, 65);
            this.valMessage.Name = "valMessage";
            this.valMessage.Size = new System.Drawing.Size(0, 13);
            this.valMessage.TabIndex = 7;
            // 
            // FileSplitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 83);
            this.Controls.Add(this.valMessage);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtEmailCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FileSplitterForm";
            this.Text = "File Splitter by Zyla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog ofdBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailCount;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label valMessage;
    }
}

