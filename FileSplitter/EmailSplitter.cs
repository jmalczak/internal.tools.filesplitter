using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;

namespace FileSplitter
{
    public class EmailSplitter
    {
        #region PRIVATE VARIABLES

        private readonly string _filePath;
        private readonly int _emailCount;
        private int _fileNumber = 0;

        #endregion

        #region CONSTRUCTOR

        public EmailSplitter(string filePath, int emailCount)
        {
            _emailCount = emailCount;
            _filePath = filePath;
        }

        #endregion

        #region PUBLIC METHODS

        public void ProcessFile()
        {
            List<string> emails = new List<string>(_emailCount);

            using (FileStream fileStream = File.OpenRead(_filePath))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string email = streamReader.ReadLine().Trim();

                        if (!string.IsNullOrEmpty(email))
                        {
                            emails.Add(email);

                            if (emails.Count() == _emailCount || streamReader.EndOfStream)
                            {
                                // Save file
                                SaveFile(emails);
                                emails = new List<string>(_emailCount);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region PRIVATE METHODS

        private void SaveFile(List<string> emails)
        {
            string fileName = string.Format("{0}\\{1}_{2}{3}", Path.GetDirectoryName(_filePath), Path.GetFileNameWithoutExtension(_filePath), _fileNumber, Path.GetExtension(_filePath));

            using (StreamWriter streamWriter = File.CreateText(fileName))
            {
                emails.ForEach(e =>
                {
                    if (!string.IsNullOrEmpty(e))
                    {
                        streamWriter.WriteLine(e);
                    }
                });
                streamWriter.Flush();
            }

            _fileNumber++;
        }

        #endregion
    }
}
