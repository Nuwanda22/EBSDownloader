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

		private async void button1_Click(object sender, EventArgs e)
		{
            string url = "http://wstrotu.ebs.co.kr/ebsvod/lang/2016/10021633/mp3/20160922_110013_f97c8384_mp3.mp3?key=c2673c3448249de11cd8d8d1713ef69a04d45241";
            string fileName = "20160922_110013_f97c8384_mp3.mp3";

            saveFileDialog.FileName = fileName;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
                await DownloadFileAsync(url, saveFileDialog.FileName);
            }
		}

        async Task DownloadFileAsync(string url, string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += (sender, e) =>
                {
                    downloadProgressBar.Value = e.ProgressPercentage;
                };

                await webClient.DownloadFileTaskAsync(url, fileName);

                MessageBox.Show("다운로드가 완료되었습니다!");
                downloadProgressBar.Value = 0;
            }
        }
        
		private void button2_Click(object sender, EventArgs e)
		{
            var html = CQ.CreateFromUrl(downloadUrlTextBox.Text); 
            var title = html["h5"].Text().Trim();
            var date = html["p.date"].Text().Trim();
            var audio = ExtractAudioSource(html["div.body_in script"].ElementAt(1).InnerText);

            MessageBox.Show($"{title} {DateTime.Parse(date.Replace('.', '-'))}");
        }

        private string ExtractAudioSource(string script)
        {
            string key = "var aodUrl = '";

            var audio = script.Substring(script.IndexOf(key) + key.Length); // Delete front
            audio = audio.Substring(0, audio.IndexOf('\''));                // Delete back

            return audio;
        }
	}
}
