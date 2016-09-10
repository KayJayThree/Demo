using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace Demo
{
	public partial class FormDemo : Form
	{
		public FormDemo()
		{
			InitializeComponent();
		}

		private void buttonSelectPicture_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxText.Clear();
				textBoxHtml.Clear();
				textBoxUnlv.Clear();
				pictureBoxRegions.Image = null;
				pictureBoxParagraphs.Image = null;
				pictureBoxTextLines.Image = null;
				pictureBoxWords.Image = null;
				pictureBoxComponents.Image = null;

				pictureBox.Image = Image.FromFile(openFileDialog.FileName);

				// changed below per site https://visualstudiogallery.msdn.microsoft.com/33130037-c313-40b1-9c3c-9a776a6c8fd8#
				//commented first line and added second.
				ocr.PictureFileName = openFileDialog.FileName; // comment this line
				//ocr.Picture = Image.FromFile(openFileDialog.FileName); // add this line

				if (!ocr.Active)
				{
					ocr.DataPath = AppDomain.CurrentDomain.BaseDirectory;
					ocr.Active = true;
				}
				buttonRecognize.Enabled = true;
			}
		}

		private bool cancel;

		private void OcrInvoke()
		{
			try
			{
				if (!cancel)
				{
					progressBar.Value = 100;

					textBoxText.Text = ocr.Text.Replace("\xa", "\xd\xa");
					textBoxHtml.Text = ocr.GetHtmlText().Replace("\xa", "\xd\xa");
					textBoxUnlv.Text = ocr.UnlvText.Replace("\xa", "\xd\xa");

					using (var bitmap = new Bitmap(pictureBox.Image))
					{
						pictureBoxWords.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);
						if (ocr.Words != null)
							using (var g = Graphics.FromImage(pictureBoxWords.Image))
							{
								var pen = new Pen(Color.FromArgb(0x00, 0x7F, 0xFF));
								foreach (var rectangle in ocr.Words)
									g.DrawRectangle(pen, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
							}

						pictureBoxRegions.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);
						if (ocr.Regions != null)
							using (var g = Graphics.FromImage(pictureBoxRegions.Image))
							{
								var pen = new Pen(Color.FromArgb(0x7F, 0x00, 0xFF));
								foreach (var rectangle in ocr.Regions)
									g.DrawRectangle(pen, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
							}

						pictureBoxTextLines.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);
						if (ocr.TextLines != null)
							using (var g = Graphics.FromImage(pictureBoxTextLines.Image))
							{
								var pen = new Pen(Color.FromArgb(0x00, 0xFF, 0x7F));
								foreach (var rectangle in ocr.TextLines)
									g.DrawRectangle(pen, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
							}

						pictureBoxComponents.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);
						if (ocr.ConnectedComponents != null)
							using (var g = Graphics.FromImage(pictureBoxComponents.Image))
							{
								var pen = new Pen(Color.FromArgb(0xFF, 0x7F, 0x00));
								foreach (var rectangle in ocr.ConnectedComponents)
									g.DrawRectangle(pen, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
							}

						pictureBoxParagraphs.Image = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);
						if (ocr.Paragraphs != null)
							using (var g = Graphics.FromImage(pictureBoxParagraphs.Image))
							{
								var pen = new Pen(Color.FromArgb(0x7F, 0xFF, 0x00));
								foreach (var paragraph in ocr.Paragraphs)
								{
									var rectangle = paragraph.Location;
									g.DrawRectangle(pen, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
								}
							}
					}
				}
				else
					progressBar.Value = 0;
			}
			finally
			{
				buttonCancel.Visible = false;
				buttonSelectPicture.Enabled = true;
				Cursor.Current = Cursors.Default;
			}
		}

		delegate void OcrDelegate();

		private void Start()
		{
			ocr.Recognize();
			if (InvokeRequired)
			{
				var invoke = new OcrDelegate(OcrInvoke);
				this.Invoke(invoke, null);
			}
			else
				OcrInvoke();
		}

		private void buttonRecognize_Click(object sender, EventArgs e)
		{
			buttonSelectPicture.Enabled = false;
			Cursor.Current = Cursors.WaitCursor;
			cancel = false;
			buttonCancel.Visible = true;
			textBoxText.Clear();
			textBoxHtml.Clear();
			textBoxUnlv.Clear();
			pictureBoxRegions.Image = null;
			pictureBoxParagraphs.Image = null;
			pictureBoxTextLines.Image = null;
			pictureBoxWords.Image = null;
			pictureBoxComponents.Image = null;

			new Thread(Start).Start();
		}

		delegate void ProgressDelegate(int progress);

		void ProgressInvoke(int progress)
		{
			progressBar.Value = progress;
		}

		private void ocr_Progress(object sender, Winsoft.Ocr.ProgressEventArgs e)
		{
			if (progressBar.InvokeRequired)
			{
				var invoke = new ProgressDelegate(ProgressInvoke);
				this.Invoke(invoke, new object[] { e.Progress });
			}
			else
				ProgressInvoke(e.Progress);
			e.Cancel = cancel;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			cancel = true;
		}
	}
}