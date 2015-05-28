using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Insanity
{
	public class Game
	{
		Clock clock;
		RenderWindow window;
		Scene scene;

		public Game()
		{
			window = new RenderWindow(new VideoMode(800, 600), "Insanity");
			window.SetFramerateLimit(60);
			window.Closed += OnClose;
			clock = new Clock();
		}

		public int loop()
		{
			scene = new Prototype(window);

			while (window.IsOpen)
			{
				window.DispatchEvents();
				scene.update(clock.ElapsedTime);
				clock.Restart();

				window.Clear();
				window.Draw(scene);
				window.Display();
			}

			return 0;
		}

		private void OnClose(object sender, EventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			window.Close();
		}
	}
}
