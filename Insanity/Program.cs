using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using Insanity;

namespace SFML_NET
{
	static class Program
	{
		static void Main(string[] args)
		{
			Game insanity = new Game();
			insanity.loop();
		}
	}
}