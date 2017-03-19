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

namespace EBSDownloader
{
	public partial class MainForm : Form
	{
		string url = "http://wstrotu.ebs.co.kr/ebsvod/lang/2016/10021633/mp3/20160922_110013_f97c8384_mp3.mp3?key=c2673c3448249de11cd8d8d1713ef69a04d45241";
		string fileName = "20160922_110013_f97c8384_mp3.mp3";
		

		public MainForm()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
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

		private string HTMLfrom(string Url) 
		{
			string urlAddress = Url;
			string temp;
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			if (response.StatusCode == HttpStatusCode.OK)
			{
				Stream receiveStream = response.GetResponseStream();
				StreamReader readStream = null;

				if (response.CharacterSet == null)
				{
					readStream = new StreamReader(receiveStream);
				}
				else
				{
					readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
				}

				temp = readStream.ReadToEnd();

				response.Close();
				readStream.Close();
			}
			else
			{
				throw new ArgumentException("주소가 응답하지 않습니다.");
			}

			return temp;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string temp = HTMLfrom(downloadUrlTextBox.Text);
			MessageBox.Show(temp);

			//int index1 = temp.IndexOf("<audio");
			//int index2 = temp.IndexOf("</audio>");

			//string a= temp.Substring(index1, index2 - index1);

			//MessageBox.Show(index1.ToString()+" "+index2.ToString());
		}
	}
}
