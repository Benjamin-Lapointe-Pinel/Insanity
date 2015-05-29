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
		protected SortedList<int, Drawable> entities =
			new SortedList<int, Drawable>(new DuplicateKeyComparer<int>()); 

		public Scene(RenderWindow rw)
		{
			window = rw;
		}

		public abstract void update(Time time);

		protected void automaticDrawAdd(Entity entity)
		{
			entities.Add(entity.Z, entity);
		}

		protected void automaticDrawAdd(Drawable drawable, int z = 0)
		{
			entities.Add(z, drawable);
		}

		public virtual void Draw(RenderTarget target, RenderStates states)
		{
			foreach (KeyValuePair<int, Drawable> keyValue in entities)
			{
				target.Draw(keyValue.Value, states);
			}
		}
	}
}

public class DuplicateKeyComparer<T> : IComparer<T> where T : IComparable
{
	public int Compare(T x, T y)
	{
		int result = x.CompareTo(y);

		if (result == 0)
			return -1;
		else
			return result;
	}
}