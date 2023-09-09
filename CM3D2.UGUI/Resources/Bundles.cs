using System.IO;
using UnityEngine;
using UniverseLib;

namespace CM3D2.UGUI.Resources
{
	internal static class Bundles
	{
		public static AssetBundle CommonUI => LazyLoadBundle("commonui", ref _commonUI);
		private static AssetBundle _commonUI;

		public static AssetBundle SceneEdit => LazyLoadBundle("sceneedit", ref _sceneEdit);
		private static AssetBundle _sceneEdit;


		private static AssetBundle LazyLoadBundle(string id, ref AssetBundle field)
		{
			if (field == null)
			{
				field = LoadBundle(id);
			}
			return field;
		}

		private static AssetBundle LoadBundle(string id)
		{
#if UNITY_5

			string path = Path.GetFullPath(Application.dataPath + "/../AssetBundles/StandaloneWindows/" + id);
			Debug.Log("Loading AssetBundle \"" + path + "\"");
			AssetBundle bundle = AssetBundle.LoadFromFile(path);
#else
			AssetBundle bundle = AssetBundle.LoadFromMemory(
				ReadFully(
					typeof(Bundles).Assembly.GetManifestResourceStream($"{typeof(Bundles).Namespace}.{id}.bundle")
				)
			);
#endif

			return bundle;
		}

		private static byte[] ReadFully(Stream input)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				byte[] buffer = new byte[81920];
				int read;
				while ((read = input.Read(buffer, 0, buffer.Length)) != 0)
					ms.Write(buffer, 0, read);
				return ms.ToArray();
			}
		}
	}
}
