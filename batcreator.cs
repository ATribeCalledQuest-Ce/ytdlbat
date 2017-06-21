using System;
using System.IO;

namespace batcreator
{
    public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("What do you want to name this .bat file?");
			string name = String.Format("{0}.bat", Console.ReadLine());
			Console.WriteLine("What drive do you want to store it in? Type only the drive letter, if you want to have youtube-dl.exe stored in your f drive, input f.  This is also where the .bat file will apear once it is created.");
			string drive = String.Format("{0}:", Console.ReadKey().KeyChar.ToString());
			Console.WriteLine("Where do you want to store it in that drive? i.e. f:\\Music, do not end the directory in a \\, input the directory as seen in earlier.");
			string directory = String.Format("{0}\\{1}", Console.ReadLine(), name);
			string dirCommand = String.Format("cd {0}", directory);
			StreamWriter creator = new StreamWriter(@directory);
			creator.WriteLine(@"@echo OFF");
			creator.WriteLine(drive);
			creator.WriteLine(dirCommand);
			creator.WriteLine(@":loop
set /p url=Paste the url of the video you want to download: 
youtube-dl -f 140 %url%
goto loop");
			creator.Close();
			Console.ReadKey();
		}
	}
}