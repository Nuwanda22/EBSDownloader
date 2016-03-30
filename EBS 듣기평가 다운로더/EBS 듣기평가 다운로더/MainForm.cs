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

namespace EBS_듣기평가_다운로더
{
	public partial class MainForm : Form
	{
		string url = "http://wstrotu.ebs.co.kr/ebsvod/mid/2015/10014892/mp3/20150917_110000_mp3.mp3?key=6733f06e7e8cf25f5ab08a3ddb47f6edb2ea6a15";
		string fileName = "20150917_110000_mp3.mp3";
		WebClient webClient;

		public MainForm()
		{
			InitializeComponent();

			webClient = new WebClient();
			webClient.DownloadProgressChanged += (sender, e) =>
			{
				downloadProgressBar.Value = e.ProgressPercentage;
			};
			webClient.DownloadFileCompleted += (sender, e) =>
			{
				MessageBox.Show("다운로드가 완료되었습니다!");
				downloadProgressBar.Visible = false;
			};
		}

		private void button1_Click(object sender, EventArgs e)
		{
			saveFileDialog.FileName = fileName;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				downloadProgressBar.Visible = true;
				webClient.DownloadFileAsync(new Uri(url), saveFileDialog.FileName);
			}
			webClient.Dispose();
		}
	}
}
