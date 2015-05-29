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
	public abstract class Scene : IUpdatable
	{
		public RenderWindow Window { get; set; }
		protected Color backgroundColor = Color.Transparent;
		protected SortedList<int, Drawable> entities;

		public Scene(RenderWindow rw)
		{
			Window = rw;
			entities = new SortedList<int, Drawable>(new DuplicateKeyComparer<int>());
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

		public void Draw()
		{
			Window.Clear(backgroundColor);
			foreach (KeyValuePair<int, Drawable> keyValue in entities)
			{
				Window.Draw(keyValue.Value);
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
			return 1;
		else
			return result;
	}
}