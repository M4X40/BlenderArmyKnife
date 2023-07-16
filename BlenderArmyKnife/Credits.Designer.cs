namespace BlenderArmyKnife
{
	partial class Credits
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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.GithubButton = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GithubButton)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("JetBrainsMonoNL Nerd Font Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(49, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Made with ♥️ by M4X4";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BlenderArmyKnife.Properties.Resources.Asset_1;
			this.pictureBox1.Location = new System.Drawing.Point(395, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(123, 123);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// GithubButton
			// 
			this.GithubButton.BackColor = System.Drawing.Color.White;
			this.GithubButton.BackgroundImage = global::BlenderArmyKnife.Properties.Resources.Octicons_mark_github_svg;
			this.GithubButton.Image = global::BlenderArmyKnife.Properties.Resources.Octicons_mark_github_svg;
			this.GithubButton.Location = new System.Drawing.Point(12, 117);
			this.GithubButton.Name = "GithubButton";
			this.GithubButton.Size = new System.Drawing.Size(75, 75);
			this.GithubButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.GithubButton.TabIndex = 2;
			this.GithubButton.TabStop = false;
			this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
			// 
			// Credits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
			this.ClientSize = new System.Drawing.Size(533, 204);
			this.Controls.Add(this.GithubButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("JetBrainsMonoNL Nerd Font Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Credits";
			this.Text = "Credits";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GithubButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox GithubButton;
	}
}