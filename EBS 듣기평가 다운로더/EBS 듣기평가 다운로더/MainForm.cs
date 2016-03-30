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
		string url = "http://wstrotu.ebs.co.kr/ebsvod/mid/2015/10014892/mp3/20150917_110000_mp3.mp3?key=eac13bff8e48aca43e0b11f82b94a39793dcb904";
		string fileName = "20150917_110000_mp3.mp3";

		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (WebClient webClient = new WebClient())
			{
				saveFileDialog.FileName = fileName;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					webClient.DownloadFile(url, saveFileDialog.FileName);
				}
			}
		}
	}
}
