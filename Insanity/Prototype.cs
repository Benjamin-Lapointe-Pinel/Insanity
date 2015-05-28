using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insanity
{
	public class Prototype : IScene
	{
		private Texture texturePerso;
		private Sprite perso;
		private Color background;

		public Prototype()
		{
			background = new Color(127, 127, 255);
			texturePerso = new Texture(@"..\..\Ressources\perso.png");
			perso = new Sprite(texturePerso);
		}

		public void update(Time time)
		{
			if (Keyboard.IsKeyPressed(Keyboard.Key.A))
			{
				perso.Position += new Vector2f(-1 * time.AsMilliseconds(), 0);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.D))
			{
				perso.Position += new Vector2f(1 * time.AsMilliseconds(), 0);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.W))
			{
				perso.Position += new Vector2f(0, -1 * time.AsMilliseconds());
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.S))
			{
				perso.Position += new Vector2f(0, 1 * time.AsMilliseconds());
			}
		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			target.Clear(background);
			target.Draw(perso, states);
		}
	}
}
