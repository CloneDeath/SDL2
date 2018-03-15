﻿using System;
using System.Drawing;
using SDL2;

namespace SDL2Example {
	public class Program {
		public static void Main() {
			using (var sdl = new SdlEngine()) {
				using (var window = sdl.CreateWindow()) {
					window.Title = "Hello World";
					window.Show();
					sdl.Delay(TimeSpan.FromSeconds(1));
					
					window.Size = new Size(300, 300);
					Console.WriteLine(window.Size);
					sdl.Delay(TimeSpan.FromSeconds(1));


					using (var renderer = window.CreateRenderer()) {
						MainLoop(renderer, sdl);
					}
				}
			}
		}

		private static void MainLoop(IRenderer renderer, IEngine sdl) {
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
				renderer.Present();

				sdl.Delay(TimeSpan.FromSeconds(1/60d));
			}
		}
	}
}