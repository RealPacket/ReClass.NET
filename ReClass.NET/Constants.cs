namespace ReClassNET
{
	public class Constants
	{
		public const string ApplicationName = "ReClass.NET";
		/// <summary>
		/// Used in places like window titles, text, and etc.
		/// Core things not shown to the user won't use this.
		/// </summary>
		public const string ApplicationDisplayName = "ReAss.NET";
		public const string ApplicationExecutableName = $"{ApplicationName}.exe";

		public const string ApplicationVersion = "1.2";

		public const string LauncherExecutableName = $"{ApplicationName}_Launcher.exe";

		public const string Author = "KN4CK3R";

		public const string HomepageUrl = "https://github.com/ReClassNET/ReClass.NET";

		public const string HelpUrl = "https://github.com/ReClassNET/ReClass.NET/issues";

		public const string PluginUrl = "https://github.com/ReClassNET/ReClass.NET#plugins";

#if RECLASSNET64
		public const string Platform = "x64";

		public const string AddressHexFormat = "X016";
#else
		public const string Platform = "x86";

		public const string AddressHexFormat = "X08";
#endif

		public const string SettingsFile = "settings.xml";

		public const string PluginsFolder = "Plugins";

		public static class CommandLineOptions
		{
			public const string AttachTo = "attach_to";

			public const string FileExtRegister = "register_file_ext";
			public const string FileExtUnregister = "unregister_file_ext";
		}
	}
}