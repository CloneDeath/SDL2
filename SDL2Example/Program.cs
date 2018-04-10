using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using SDL2;

namespace SDL2Example {
	public class Program {
		public static void Main() {
			using (var sdl = new SdlEngine())
			using (var window = sdl.CreateWindow()) {
				window.Title = "Hello World";
				window.Show();
				sdl.Delay(TimeSpan.FromSeconds(1));

				window.Size = new Size(300, 300);
				Console.WriteLine(window.Size);
				sdl.Delay(TimeSpan.FromSeconds(1));

				using (var renderer = window.CreateRenderer())
				using (var fontStream = GetFontStream())
				using (var font = renderer.OpenFont(fontStream, 12)) {
					MainLoop(renderer, font, sdl);
				}
			}
		}

		private static Stream GetFontStream() {
			var assembly = Assembly.GetExecutingAssembly();
			return assembly.GetManifestResourceStream($"{nameof(SDL2Example)}.BetterPixels.ttf");
		}

		private static void MainLoop(IRenderer renderer, IFont font, IEngine sdl) {
			var keepRunning = true;
			while (keepRunning) {
				for (var evt = sdl.PollEvent(); evt != null; evt = sdl.PollEvent()) {
					// ReSharper disable once SwitchStatementMissingSomeCases
					switch (evt.Type) {
						case EventType.Quit:
							keepRunning = false;
							break;
						case EventType.KeyDown:
							Console.WriteLine(evt.Key.KeySymbol.Symbol);
							break;
						case EventType.KeyUp:
							Console.WriteLine("-" + evt.Key.KeySymbol.Symbol);
							break;
						case EventType.MouseMotion:
							Console.WriteLine(evt.Motion.DeltaX);
							break;
						case EventType.MouseButtonDown:
							Console.WriteLine(evt.Button.Button + " " + evt.Button.Clicks);
							break;
						case EventType.MouseWheel:
							Console.WriteLine(evt.Wheel.Y);
							break;
					}
				}
				renderer.DrawColor = Color.Black;
				renderer.Clear();

				renderer.DrawColor = Color.White;
				renderer.DrawRectangle(new Rectangle {
					X = 10,
					Y = 10,
					Width = 10,
					Height = 10
				});
				using (var messageSurface = font.RenderText("Hello World", Color.Red))
				using (var messageTexture = renderer.CreateTexture(messageSurface))
				{
					renderer.DrawTexture(messageTexture, Point.Empty);
				}
				
				using (var messageSurface = font.RenderTextWrapped("Hello World", Color.Lime, 30))
				using (var messageTexture = renderer.CreateTexture(messageSurface))
				{
					renderer.DrawTexture(messageTexture, new Point(0, 50));
				}
				renderer.Present();

				sdl.Delay(TimeSpan.FromSeconds(1/60d));
			}
		}
	}
}