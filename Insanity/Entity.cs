using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insanity
{
	public abstract class Entity : Drawable
	{
		public int Z { get; set; }
		public abstract void Draw(RenderTarget target, RenderStates states);
	}
}
