using Syncfusion.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator
{
	public static class ACMessageBox
	{
		/// <summary>
		/// Styles the <see cref="MessageBoxAdv"/>
		/// </summary>
		public static void MsgBoxConfig(Font messageFont, Font captionFont, Color caprionColor, Color foreColor, Color backColor)
		{
			MessageBoxAdv.RightToLeft = RightToLeft.No;
			MessageBoxAdv.MessageFont = messageFont;
			MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
			MessageBoxAdv.CaptionFont = captionFont;
			MessageBoxAdv.MetroColorTable = new MetroStyleColorTable
			{
				BackColor = backColor,
				ForeColor = foreColor,

				YesButtonBackColor = caprionColor,
				AbortButtonBackColor = caprionColor,
				CancelButtonBackColor = caprionColor,
				DetailsButtonBackColor = caprionColor,
				IgnoreButtonBackColor = caprionColor,
				NoButtonBackColor = caprionColor,
				OKButtonBackColor = caprionColor,
				RetryButtonBackColor = caprionColor,
				CaptionBarColor = caprionColor,

				AbortButtonForeColor = foreColor,
				CancelButtonForeColor = foreColor,
				CaptionForeColor = foreColor,
				DetailsButtonForeColor = foreColor,
				IgnoreButtonForeColor = foreColor,
				NoButtonForeColor = foreColor,
				OKButtonForeColor = foreColor,
				RetryButtonForeColor = foreColor,
				YesButtonForeColor = foreColor
			};
		}


		public static void ShowSuccessMessage(string message = null)
		{
			MessageBoxAdv.Show(message ?? "Operation done successfully.", "Successful Operation");
		}

		public static void ShowFillRequiredFields(string message = null)
		{
			MessageBoxAdv.Show(message ?? "You must fill all fields with (*) sign.", "Fill Required Fields");
		}

		public static void ShowFailedMessage(string message = null)
		{
			MessageBoxAdv.Show(message ?? "Operation failed.", "Failed Operation");
		}

		public static void ShowSelectObjectToContinue(string message = null)
		{
			MessageBoxAdv.Show(message ?? "You must select object to continue.", "Error");
		}

		public static bool EnsureToContinue(string message = null)
		{
			return MessageBoxAdv.Show(message ?? "Are you sure you want to continue?", "Confirm operation", MessageBoxButtons.YesNo) == DialogResult.Yes;
		}

		public static void CantPerformOnObject(string message = null)
		{
			MessageBoxAdv.Show(message ?? "Can't perform action on this object", "Invalid Operation");
		}
	}
}
