namespace EBSDownloader
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.downloadUrlTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadUrlTextBox
            // 
            this.downloadUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadUrlTextBox.Location = new System.Drawing.Point(12, 12);
            this.downloadUrlTextBox.Name = "downloadUrlTextBox";
            this.downloadUrlTextBox.Size = new System.Drawing.Size(604, 21);
            this.downloadUrlTextBox.TabIndex = 0;
            this.downloadUrlTextBox.Text = "http://home.ebs.co.kr/home1810/replay/53/view?courseId=10021633&stepId=10025259&p" +
    "rodId=119874&pageNo=2&lectId=10500721&lectNm=&bsktPchsYn=&prodDetlId=&oderProdCl" +
    "sCd=&prodFig=&vod=A&oderProdDetlClsCd=";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(541, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "mp3 File|*.mp3";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgressBar.Location = new System.Drawing.Point(12, 39);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(604, 23);
            this.downloadProgressBar.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(460, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 110);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadUrlTextBox);
            this.Name = "MainForm";
            this.Text = "EBS Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox downloadUrlTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ProgressBar downloadProgressBar;
		private System.Windows.Forms.Button button2;
	}
}

