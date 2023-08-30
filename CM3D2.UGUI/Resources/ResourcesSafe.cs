using UnityEngine;
using UniverseLib;
using UniverseLib.Runtime;

namespace CM3D2.UGUI.Resources
{
	public static class ResourcesSafe
	{
		public static T Load<T>(string path) where T : Object
		{
			T obj = UnityEngine.Resources.Load<T>(path);
			if (obj == null)
			{
				Debug.LogError("Could not load resource at path " + path);

				if (typeof(ScriptableObject).IsAssignableFrom(typeof(T)))
				{
					obj = RuntimeHelper.CreateScriptable(typeof(T)) as T;
				}
				else if (typeof(T) == typeof(Texture2D))
				{
					Texture2D tex = TextureHelper.NewTexture2D(1, 1);
					tex.SetPixel(0, 0, Color.magenta);
					tex.name = "MissingTexture: " + path;
					obj = tex as T;
				}
			}

			return obj;
		}
	}
}
