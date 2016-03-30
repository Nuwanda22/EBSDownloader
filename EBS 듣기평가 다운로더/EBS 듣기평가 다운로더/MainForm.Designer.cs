namespace EBS_듣기평가_다운로더
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
			this.SuspendLayout();
			// 
			// downloadUrlTextBox
			// 
			this.downloadUrlTextBox.Location = new System.Drawing.Point(12, 12);
			this.downloadUrlTextBox.Name = "downloadUrlTextBox";
			this.downloadUrlTextBox.Size = new System.Drawing.Size(260, 21);
			this.downloadUrlTextBox.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 75);
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
			this.downloadProgressBar.Location = new System.Drawing.Point(12, 39);
			this.downloadProgressBar.Name = "downloadProgressBar";
			this.downloadProgressBar.Size = new System.Drawing.Size(260, 23);
			this.downloadProgressBar.TabIndex = 2;
			this.downloadProgressBar.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 110);
			this.Controls.Add(this.downloadProgressBar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.downloadUrlTextBox);
			this.Name = "MainForm";
			this.Text = "EBS 다운로더";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox downloadUrlTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ProgressBar downloadProgressBar;
	}
}

