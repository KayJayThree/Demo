namespace Demo
{
	partial class FormDemo
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonSelectPicture = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.tabPageHTML = new System.Windows.Forms.TabPage();
            this.textBoxHtml = new System.Windows.Forms.TextBox();
            this.tabPageUnlv = new System.Windows.Forms.TabPage();
            this.textBoxUnlv = new System.Windows.Forms.TextBox();
            this.tabPageRegions = new System.Windows.Forms.TabPage();
            this.pictureBoxRegions = new System.Windows.Forms.PictureBox();
            this.tabPageParagraphs = new System.Windows.Forms.TabPage();
            this.pictureBoxParagraphs = new System.Windows.Forms.PictureBox();
            this.tabPageTextLines = new System.Windows.Forms.TabPage();
            this.pictureBoxTextLines = new System.Windows.Forms.PictureBox();
            this.tabPageWords = new System.Windows.Forms.TabPage();
            this.pictureBoxWords = new System.Windows.Forms.PictureBox();
            this.tabPageComponents = new System.Windows.Forms.TabPage();
            this.pictureBoxComponents = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ocr = new Winsoft.Ocr.Ocr(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.tabPageHTML.SuspendLayout();
            this.tabPageUnlv.SuspendLayout();
            this.tabPageRegions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegions)).BeginInit();
            this.tabPageParagraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParagraphs)).BeginInit();
            this.tabPageTextLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextLines)).BeginInit();
            this.tabPageWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWords)).BeginInit();
            this.tabPageComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComponents)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocr)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            this.splitContainer.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Panel2.Controls.Add(this.panelRight);
            this.splitContainer.Size = new System.Drawing.Size(892, 647);
            this.splitContainer.SplitterDistance = 433;
            this.splitContainer.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(433, 615);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonSelectPicture);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(433, 32);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonSelectPicture
            // 
            this.buttonSelectPicture.Location = new System.Drawing.Point(12, 6);
            this.buttonSelectPicture.MinimumSize = new System.Drawing.Size(100, 23);
            this.buttonSelectPicture.Name = "buttonSelectPicture";
            this.buttonSelectPicture.Size = new System.Drawing.Size(100, 23);
            this.buttonSelectPicture.TabIndex = 0;
            this.buttonSelectPicture.Text = "Select Picture...";
            this.buttonSelectPicture.UseVisualStyleBackColor = true;
            this.buttonSelectPicture.Click += new System.EventHandler(this.buttonSelectPicture_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageText);
            this.tabControl.Controls.Add(this.tabPageHTML);
            this.tabControl.Controls.Add(this.tabPageUnlv);
            this.tabControl.Controls.Add(this.tabPageRegions);
            this.tabControl.Controls.Add(this.tabPageParagraphs);
            this.tabControl.Controls.Add(this.tabPageTextLines);
            this.tabControl.Controls.Add(this.tabPageWords);
            this.tabControl.Controls.Add(this.tabPageComponents);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(455, 615);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.textBoxText);
            this.tabPageText.Location = new System.Drawing.Point(4, 22);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(447, 589);
            this.tabPageText.TabIndex = 0;
            this.tabPageText.Text = "Text";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // textBoxText
            // 
            this.textBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxText.Location = new System.Drawing.Point(3, 3);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxText.Size = new System.Drawing.Size(441, 583);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.WordWrap = false;
            // 
            // tabPageHTML
            // 
            this.tabPageHTML.Controls.Add(this.textBoxHtml);
            this.tabPageHTML.Location = new System.Drawing.Point(4, 22);
            this.tabPageHTML.Name = "tabPageHTML";
            this.tabPageHTML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHTML.Size = new System.Drawing.Size(447, 589);
            this.tabPageHTML.TabIndex = 1;
            this.tabPageHTML.Text = "HTML";
            this.tabPageHTML.UseVisualStyleBackColor = true;
            // 
            // textBoxHtml
            // 
            this.textBoxHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHtml.Location = new System.Drawing.Point(3, 3);
            this.textBoxHtml.Multiline = true;
            this.textBoxHtml.Name = "textBoxHtml";
            this.textBoxHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxHtml.Size = new System.Drawing.Size(441, 583);
            this.textBoxHtml.TabIndex = 1;
            this.textBoxHtml.WordWrap = false;
            // 
            // tabPageUnlv
            // 
            this.tabPageUnlv.Controls.Add(this.textBoxUnlv);
            this.tabPageUnlv.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnlv.Name = "tabPageUnlv";
            this.tabPageUnlv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnlv.Size = new System.Drawing.Size(447, 589);
            this.tabPageUnlv.TabIndex = 3;
            this.tabPageUnlv.Text = "UNLV";
            this.tabPageUnlv.UseVisualStyleBackColor = true;
            // 
            // textBoxUnlv
            // 
            this.textBoxUnlv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUnlv.Location = new System.Drawing.Point(3, 3);
            this.textBoxUnlv.Multiline = true;
            this.textBoxUnlv.Name = "textBoxUnlv";
            this.textBoxUnlv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxUnlv.Size = new System.Drawing.Size(441, 583);
            this.textBoxUnlv.TabIndex = 2;
            this.textBoxUnlv.WordWrap = false;
            // 
            // tabPageRegions
            // 
            this.tabPageRegions.Controls.Add(this.pictureBoxRegions);
            this.tabPageRegions.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegions.Name = "tabPageRegions";
            this.tabPageRegions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegions.Size = new System.Drawing.Size(447, 589);
            this.tabPageRegions.TabIndex = 5;
            this.tabPageRegions.Text = "Regions";
            this.tabPageRegions.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRegions
            // 
            this.pictureBoxRegions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRegions.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRegions.Name = "pictureBoxRegions";
            this.pictureBoxRegions.Size = new System.Drawing.Size(441, 583);
            this.pictureBoxRegions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegions.TabIndex = 1;
            this.pictureBoxRegions.TabStop = false;
            // 
            // tabPageParagraphs
            // 
            this.tabPageParagraphs.Controls.Add(this.pictureBoxParagraphs);
            this.tabPageParagraphs.Location = new System.Drawing.Point(4, 22);
            this.tabPageParagraphs.Name = "tabPageParagraphs";
            this.tabPageParagraphs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParagraphs.Size = new System.Drawing.Size(447, 589);
            this.tabPageParagraphs.TabIndex = 2;
            this.tabPageParagraphs.Text = "Paragraphs";
            this.tabPageParagraphs.UseVisualStyleBackColor = true;
            // 
            // pictureBoxParagraphs
            // 
            this.pictureBoxParagraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxParagraphs.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxParagraphs.Name = "pictureBoxParagraphs";
            this.pictureBoxParagraphs.Size = new System.Drawing.Size(441, 583);
            this.pictureBoxParagraphs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxParagraphs.TabIndex = 2;
            this.pictureBoxParagraphs.TabStop = false;
            // 
            // tabPageTextLines
            // 
            this.tabPageTextLines.Controls.Add(this.pictureBoxTextLines);
            this.tabPageTextLines.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextLines.Name = "tabPageTextLines";
            this.tabPageTextLines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextLines.Size = new System.Drawing.Size(447, 589);
            this.tabPageTextLines.TabIndex = 6;
            this.tabPageTextLines.Text = "Text Lines";
            this.tabPageTextLines.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTextLines
            // 
            this.pictureBoxTextLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTextLines.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTextLines.Name = "pictureBoxTextLines";
            this.pictureBoxTextLines.Size = new System.Drawing.Size(441, 583);
            this.pictureBoxTextLines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTextLines.TabIndex = 1;
            this.pictureBoxTextLines.TabStop = false;
            // 
            // tabPageWords
            // 
            this.tabPageWords.Controls.Add(this.pictureBoxWords);
            this.tabPageWords.Location = new System.Drawing.Point(4, 22);
            this.tabPageWords.Name = "tabPageWords";
            this.tabPageWords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWords.Size = new System.Drawing.Size(447, 589);
            this.tabPageWords.TabIndex = 4;
            this.tabPageWords.Text = "Words";
            this.tabPageWords.UseVisualStyleBackColor = true;
            // 
            // pictureBoxWords
            // 
            this.pictureBoxWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWords.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxWords.Name = "pictureBoxWords";
            this.pictureBoxWords.Size = new System.Drawing.Size(441, 583);
            this.pictureBoxWords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWords.TabIndex = 0;
            this.pictureBoxWords.TabStop = false;
            // 
            // tabPageComponents
            // 
            this.tabPageComponents.Controls.Add(this.pictureBoxComponents);
            this.tabPageComponents.Location = new System.Drawing.Point(4, 22);
            this.tabPageComponents.Name = "tabPageComponents";
            this.tabPageComponents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComponents.Size = new System.Drawing.Size(447, 589);
            this.tabPageComponents.TabIndex = 8;
            this.tabPageComponents.Text = "Components";
            this.tabPageComponents.UseVisualStyleBackColor = true;
            // 
            // pictureBoxComponents
            // 
            this.pictureBoxComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxComponents.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxComponents.Name = "pictureBoxComponents";
            this.pictureBoxComponents.Size = new System.Drawing.Size(441, 583);
            this.pictureBoxComponents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxComponents.TabIndex = 1;
            this.pictureBoxComponents.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.buttonCancel);
            this.panelRight.Controls.Add(this.progressBar);
            this.panelRight.Controls.Add(this.buttonRecognize);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(455, 32);
            this.panelRight.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(4, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(90, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(353, 23);
            this.progressBar.TabIndex = 1;
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Enabled = false;
            this.buttonRecognize.Location = new System.Drawing.Point(3, 6);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(81, 23);
            this.buttonRecognize.TabIndex = 0;
            this.buttonRecognize.Text = "Recognize";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All files|*.*";
            // 
            // ocr
            // 
            this.ocr.DataPath = null;
            this.ocr.Language = Winsoft.Ocr.Language.English;
            this.ocr.LanguageCode = "eng";
            this.ocr.PictureFileName = null;
            this.ocr.Progress += new Winsoft.Ocr.ProgressEventHandler(this.ocr_Progress);
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 647);
            this.Controls.Add(this.splitContainer);
            this.Name = "FormDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR Example";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            this.tabPageHTML.ResumeLayout(false);
            this.tabPageHTML.PerformLayout();
            this.tabPageUnlv.ResumeLayout(false);
            this.tabPageUnlv.PerformLayout();
            this.tabPageRegions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegions)).EndInit();
            this.tabPageParagraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParagraphs)).EndInit();
            this.tabPageTextLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextLines)).EndInit();
            this.tabPageWords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWords)).EndInit();
            this.tabPageComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComponents)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ocr)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageText;
		private System.Windows.Forms.TextBox textBoxText;
		private System.Windows.Forms.TabPage tabPageHTML;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.Button buttonSelectPicture;
		private System.Windows.Forms.TabPage tabPageParagraphs;
		private System.Windows.Forms.TabPage tabPageUnlv;
		private System.Windows.Forms.TabPage tabPageWords;
		private System.Windows.Forms.TabPage tabPageRegions;
		private System.Windows.Forms.TabPage tabPageTextLines;
		private System.Windows.Forms.TabPage tabPageComponents;
		private System.Windows.Forms.Button buttonRecognize;
		private System.Windows.Forms.TextBox textBoxHtml;
		private System.Windows.Forms.TextBox textBoxUnlv;
		private System.Windows.Forms.PictureBox pictureBoxWords;
		private System.Windows.Forms.PictureBox pictureBoxRegions;
		private System.Windows.Forms.PictureBox pictureBoxTextLines;
		private System.Windows.Forms.PictureBox pictureBoxComponents;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private Winsoft.Ocr.Ocr ocr;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.PictureBox pictureBoxParagraphs;
	}
}

