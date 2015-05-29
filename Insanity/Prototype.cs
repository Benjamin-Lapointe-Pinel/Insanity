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
	public class Prototype : Scene
	{
		private Text direction;
		private Sprite perso;
		private Color background;

		public Prototype(RenderWindow rw)
			: base(rw)
		{
			background = new Color(127, 127, 255);
			perso = new Sprite(new Texture(@"..\..\Ressources\perso.png"));
			perso.TextureRect = new IntRect(0, 0, 32, 91);
			//perso.Origin = new Vector2f(perso.GetLocalBounds().Left + (perso.GetLocalBounds().Width / 2),
			//	perso.GetLocalBounds().Top + (perso.GetLocalBounds().Height / 2));
			direction = new Text("test", new Font(@"..\..\Ressources\DigitalDream.ttf"), 12);
			direction.Color = Color.Yellow;
		}

		public override void update(Time time)
		{
            float persoSpeed = 0.4f;
			if (Keyboard.IsKeyPressed(Keyboard.Key.A))
			{
				perso.Position += new Vector2f(-persoSpeed * time.AsMilliseconds(), 0);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.D))
			{
				perso.Position += new Vector2f(persoSpeed * time.AsMilliseconds(), 0);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.W))
			{
				perso.Position += new Vector2f(0, -persoSpeed * time.AsMilliseconds());
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.S))
			{
				perso.Position += new Vector2f(0, persoSpeed * time.AsMilliseconds());
			}

			double angle = Math.Atan2(Mouse.GetPosition(window).Y - perso.Position.Y,
				Mouse.GetPosition(window).X - perso.Position.X) * 180 / Math.PI;

			if ((angle >= 337.5) && (angle < 22.5))
			{
				perso.TextureRect = new IntRect(0, 0, 32, 91);
				perso.Scale = new Vector2f(1, 1);
			}
			else if (angle < 67.5)
			{
				perso.TextureRect = new IntRect(128, 0, 32, 91);
				perso.Scale = new Vector2f(1, 1);
			}
			else if (angle < 112.5)
			{
				perso.TextureRect = new IntRect(64, 0, 32, 91);
				perso.Scale = new Vector2f(1, 1);
			}
			else if (angle < 157.5)
			{
				perso.TextureRect = new IntRect(128, 0, 32, 91);
				perso.Scale = new Vector2f(-1, 1);
			}
			else if (angle < 202.5)
			{
				perso.TextureRect = new IntRect(0, 0, 32, 91);
				perso.Scale = new Vector2f(-1, 1);
			}
			else if (angle < 247.5)
			{
				perso.TextureRect = new IntRect(96, 0, 32, 91);
				perso.Scale = new Vector2f(-1, 1);
			}
			else if (angle < 292.5)
			{
				perso.TextureRect = new IntRect(32, 0, 32, 91);
				perso.Scale = new Vector2f(1, 1);
			}
			else if (angle < 337.5)
			{
				perso.TextureRect = new IntRect(96, 0, 32, 91);
				perso.Scale = new Vector2f(-1, 1);
			}


			direction.DisplayedString = angle.ToString();
		}

		public override void Draw(RenderTarget target, RenderStates states)
		{
			target.Clear(background);
			target.Draw(perso, states);
			target.Draw(direction, states);
		}
	}
}
