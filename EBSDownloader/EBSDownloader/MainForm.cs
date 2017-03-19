using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using CsQuery;

namespace EBSDownloader
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private async void DownloadButton_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrWhiteSpace(DownloadUrlTextBox.Text))
            {
                MessageBox.Show("Please fill in the black space.");
                return;
            }
            
            // Parse HTML
            var html = CQ.CreateFromUrl(DownloadUrlTextBox.Text);

            // Get Info from HTML
            TitleLabel.Text = html["h5"].Text().Trim();
            DateLabel.Text = html["p.date"].Text().Trim().Replace('.', '-');

            // Download mp3
            var audio = ExtractAudioSource(html["div.body_in script"].ElementAt(1).InnerText);
            saveFileDialog.FileName = ExtractFilePath(audio);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
                await DownloadFileAsync(audio, saveFileDialog.FileName);
            }
		}

        async Task DownloadFileAsync(string url, string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += (sender, e) =>
                {
                    DownloadProgressBar.Value = e.ProgressPercentage;
                };

                await webClient.DownloadFileTaskAsync(url, fileName);

                MessageBox.Show("Download Complete.");
                DownloadProgressBar.Value = 0;
            }
        }

        private string ExtractAudioSource(string script)
        {
            string key = "var aodUrl = '";

            var audio = script.Substring(script.IndexOf(key) + key.Length); // Delete front
            audio = audio.Substring(0, audio.IndexOf('\''));                // Delete back

            return audio;
        }

        private string ExtractFilePath(string url)
        {
            var filePath = Path.GetFileName(url);
            return filePath.Substring(0, filePath.IndexOf('?'));
        }
	}
}
