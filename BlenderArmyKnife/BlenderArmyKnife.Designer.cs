namespace BlenderArmyKnife
{
	partial class BlenderArmyKnife
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlenderArmyKnife));
			this.UDumpImporter = new System.Windows.Forms.Button();
			this.FindReplaceMat = new System.Windows.Forms.Button();
			this.MatUVDupe = new System.Windows.Forms.Button();
			this.FindNodeType = new System.Windows.Forms.Button();
			this.GroupToPBSDF = new System.Windows.Forms.Button();
			this.RemoveMatClones = new System.Windows.Forms.Button();
			this.Help = new System.Windows.Forms.ToolTip(this.components);
			this.Credits = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// UDumpImporter
			// 
			this.UDumpImporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.UDumpImporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.UDumpImporter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.UDumpImporter.Location = new System.Drawing.Point(47, 41);
			this.UDumpImporter.Margin = new System.Windows.Forms.Padding(0);
			this.UDumpImporter.Name = "UDumpImporter";
			this.UDumpImporter.Size = new System.Drawing.Size(198, 28);
			this.UDumpImporter.TabIndex = 1;
			this.UDumpImporter.Text = "UDump Importer";
			this.Help.SetToolTip(this.UDumpImporter, "For use with ZenCreates/Fnaf99GatorGames\r\n(https://github.com/ZenCreates/Fnaf99Ga" +
        "torGames)\r\n\r\nTakes a umodel dump of a UE4 game and converts\r\nit into a blender s" +
        "cene, with texturing and\r\nUV mapping.");
			this.UDumpImporter.UseVisualStyleBackColor = false;
			this.UDumpImporter.Click += new System.EventHandler(this.UDumpImporter_Click);
			// 
			// FindReplaceMat
			// 
			this.FindReplaceMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FindReplaceMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.FindReplaceMat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FindReplaceMat.Location = new System.Drawing.Point(47, 69);
			this.FindReplaceMat.Margin = new System.Windows.Forms.Padding(0);
			this.FindReplaceMat.Name = "FindReplaceMat";
			this.FindReplaceMat.Size = new System.Drawing.Size(198, 28);
			this.FindReplaceMat.TabIndex = 2;
			this.FindReplaceMat.Text = "Find/Replace Materials";
			this.Help.SetToolTip(this.FindReplaceMat, resources.GetString("FindReplaceMat.ToolTip"));
			this.FindReplaceMat.UseVisualStyleBackColor = false;
			this.FindReplaceMat.Click += new System.EventHandler(this.FindReplaceMat_Click);
			// 
			// MatUVDupe
			// 
			this.MatUVDupe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.MatUVDupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.MatUVDupe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MatUVDupe.Location = new System.Drawing.Point(47, 97);
			this.MatUVDupe.Margin = new System.Windows.Forms.Padding(0);
			this.MatUVDupe.Name = "MatUVDupe";
			this.MatUVDupe.Size = new System.Drawing.Size(198, 28);
			this.MatUVDupe.TabIndex = 3;
			this.MatUVDupe.Text = "Mat-UV Duplicator";
			this.Help.SetToolTip(this.MatUVDupe, "Simplifies copying UV maps between obejcts\r\nby cloning the map to the objects \r\ns" +
        "pecified.\r\n\r\nMay be updated in the future to add \r\nenhanced features.");
			this.MatUVDupe.UseVisualStyleBackColor = false;
			this.MatUVDupe.Click += new System.EventHandler(this.MatUVDupe_Click);
			// 
			// FindNodeType
			// 
			this.FindNodeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FindNodeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.FindNodeType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FindNodeType.Location = new System.Drawing.Point(47, 125);
			this.FindNodeType.Margin = new System.Windows.Forms.Padding(0);
			this.FindNodeType.Name = "FindNodeType";
			this.FindNodeType.Size = new System.Drawing.Size(198, 28);
			this.FindNodeType.TabIndex = 4;
			this.FindNodeType.Text = "Find Node Type";
			this.Help.SetToolTip(this.FindNodeType, "Prints the name of the node that is \r\ncurrently selected. Useful for development\r" +
        "\nof other scripts.");
			this.FindNodeType.UseVisualStyleBackColor = false;
			this.FindNodeType.Click += new System.EventHandler(this.FindNodeType_Click);
			// 
			// GroupToPBSDF
			// 
			this.GroupToPBSDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupToPBSDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.GroupToPBSDF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.GroupToPBSDF.Location = new System.Drawing.Point(47, 153);
			this.GroupToPBSDF.Margin = new System.Windows.Forms.Padding(0);
			this.GroupToPBSDF.Name = "GroupToPBSDF";
			this.GroupToPBSDF.Size = new System.Drawing.Size(198, 28);
			this.GroupToPBSDF.TabIndex = 5;
			this.GroupToPBSDF.Text = "Group to Principled BSDF";
			this.Help.SetToolTip(this.GroupToPBSDF, "Transforms group-typed materials into \r\nPrincipled BSDF materials. Very uncommon\r" +
        "\nto actually need this but it is here\r\nanyways.");
			this.GroupToPBSDF.UseVisualStyleBackColor = false;
			this.GroupToPBSDF.Click += new System.EventHandler(this.GroupToPBSDF_Click);
			// 
			// RemoveMatClones
			// 
			this.RemoveMatClones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveMatClones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.RemoveMatClones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.RemoveMatClones.Location = new System.Drawing.Point(47, 181);
			this.RemoveMatClones.Margin = new System.Windows.Forms.Padding(0);
			this.RemoveMatClones.Name = "RemoveMatClones";
			this.RemoveMatClones.Size = new System.Drawing.Size(198, 28);
			this.RemoveMatClones.TabIndex = 6;
			this.RemoveMatClones.Text = "Remove Material Clones";
			this.Help.SetToolTip(this.RemoveMatClones, "Gets rid of annoying mat.001, mat.002, \r\netc.  Very useful when working with othe" +
        "r\r\nscripts.\r\n");
			this.RemoveMatClones.UseVisualStyleBackColor = false;
			this.RemoveMatClones.Click += new System.EventHandler(this.RemoveMatClones_Click);
			// 
			// Help
			// 
			this.Help.AutoPopDelay = 5000;
			this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.Help.InitialDelay = 500;
			this.Help.ReshowDelay = 100;
			this.Help.ToolTipTitle = "What is this?";
			// 
			// Credits
			// 
			this.Credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
			this.Credits.Location = new System.Drawing.Point(47, 214);
			this.Credits.Name = "Credits";
			this.Credits.Size = new System.Drawing.Size(198, 28);
			this.Credits.TabIndex = 7;
			this.Credits.Text = "Credits";
			this.Credits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Credits.UseVisualStyleBackColor = false;
			this.Credits.Click += new System.EventHandler(this.Credits_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(54, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 18);
			this.label1.TabIndex = 8;
			this.label1.Text = "The Blender Army Knife";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BlenderArmyKnife
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
			this.ClientSize = new System.Drawing.Size(304, 250);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Credits);
			this.Controls.Add(this.RemoveMatClones);
			this.Controls.Add(this.GroupToPBSDF);
			this.Controls.Add(this.FindNodeType);
			this.Controls.Add(this.MatUVDupe);
			this.Controls.Add(this.FindReplaceMat);
			this.Controls.Add(this.UDumpImporter);
			this.Font = new System.Drawing.Font("JetBrainsMono Nerd Font Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.HelpButton = true;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(320, 289);
			this.Name = "BlenderArmyKnife";
			this.Text = "Blender Army Knife";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button UDumpImporter;
		private System.Windows.Forms.Button FindReplaceMat;
		private System.Windows.Forms.Button MatUVDupe;
		private System.Windows.Forms.Button FindNodeType;
		private System.Windows.Forms.Button GroupToPBSDF;
		private System.Windows.Forms.Button RemoveMatClones;
		private System.Windows.Forms.ToolTip Help;
		private System.Windows.Forms.Button Credits;
		private System.Windows.Forms.Label label1;
	}
}

