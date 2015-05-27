using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SFML_NET
{
	static class Program
	{
		static void Main(string[] args)
		{
			RenderWindow window = new RenderWindow(new VideoMode(800, 600), "Insanity");
			window.SetFramerateLimit(60);
			window.Closed += OnClose;

			Color background = new Color(127, 127, 255);
			Texture texturePerso = new Texture(@"..\..\Ressources\perso.png");
			Sprite perso = new Sprite(texturePerso);

			while (window.IsOpen)
			{
				if (Keyboard.IsKeyPressed(Keyboard.Key.A))
				{
					perso.Position += new Vector2f(-1, 0);
				}
				if (Keyboard.IsKeyPressed(Keyboard.Key.D))
				{
					perso.Position += new Vector2f(1, 0);
				}
				if (Keyboard.IsKeyPressed(Keyboard.Key.W))
				{
					perso.Position += new Vector2f(0, -1);
				}
				if (Keyboard.IsKeyPressed(Keyboard.Key.S))
				{
					perso.Position += new Vector2f(0, 1);
				}
				window.DispatchEvents();
				window.Clear(background);
				window.Draw(perso);
				window.Display();
			}
		}

		static void OnClose(object sender, EventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			window.Close();
		}
	}
}