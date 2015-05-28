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
	public abstract class Scene : IUpdatable, Drawable
	{
		protected RenderWindow window;

		public Scene(RenderWindow rw)
		{
			window = rw;
		}

		public abstract void update(Time time);
		public abstract void Draw(RenderTarget target, RenderStates states);
	}
}
