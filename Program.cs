using System;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// main entry point of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (CatalogChooserForm catalogChooserForm = new CatalogChooserForm())
			{
				Application.Run(mainForm: catalogChooserForm);
			}
		}
	}
}
