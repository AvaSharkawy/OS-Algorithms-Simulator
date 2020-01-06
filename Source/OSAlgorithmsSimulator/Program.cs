using System;
using System.Drawing;
using System.Windows.Forms;

namespace OSAlgorithmsSimulator
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
			ACMessageBox.MsgBoxConfig(
				new Font(new FontFamily("Cantarell"), 20f, FontStyle.Regular), 
				new Font(new FontFamily("Cantarell"), 16f, FontStyle.Regular), 
				Color.FromArgb(51, 54, 63),
				Color.White,
				Color.FromArgb(28, 30, 35));
			ACMessageBox.ShowSuccessMessage();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainDashboard());
		}
	}

	/// <summary>
	/// Represents a class that is used to find the licensing file for Syncfusion controls.
	/// </summary>
	public class DemoCommon
	{
		/// <summary>
		/// Finds the license key from the Common folder.
		/// </summary>
		/// <returns>Returns the license key.</returns>
		public static string FindLicenseKey()
		{
			string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
			for (int n = 0; n < 20; n++)
			{
				if (!System.IO.File.Exists(licenseKeyFile))
				{
					licenseKeyFile = @"..\" + licenseKeyFile;
					continue;
				}
				return System.IO.File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}
}
