using System;
using System.Drawing;
using System.Threading;
using SDL2;

namespace SDL2Example {
	public class Program {
		public static void Main() {
			using (var sdl = new SdlEngine()) {
				using (var window = sdl.CreateWindow()) {
					window.Title = "Hello World";
					window.Show();
					Thread.Sleep(1000);
					window.Size = new Size(300, 300);
					Console.WriteLine(window.Size);
					Thread.Sleep(2000);
				}
			}
		}
	}
}