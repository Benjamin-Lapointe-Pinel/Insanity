using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;
using SFML.Window;

namespace SFML_NET
{
	static class Program
	{
		static void Main(string[] args)
		{
			RenderWindow window = new RenderWindow(new VideoMode(800, 600), "Untitled");
			window.SetFramerateLimit(60);
			window.Closed += OnClose;

			while (window.IsOpen)
			{
				window.DispatchEvents();
				window.Clear();
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