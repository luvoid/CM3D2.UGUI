using UnityEngine;

namespace CM3D2.UGUI.Resources.Fonts
{
	public static class NotoSansCJKjp
	{
		private const string pathPrefix = "font/notosanscjkjp-hinted/NotoSansCJKjp";
		public static readonly Font Black     = ResourcesSafe.Load<Font>(pathPrefix + "-Black"    );
		public static readonly Font Bold      = ResourcesSafe.Load<Font>(pathPrefix + "-Bold"     );
		public static readonly Font DemiLight = ResourcesSafe.Load<Font>(pathPrefix + "-DemiLight");
		public static readonly Font Light     = ResourcesSafe.Load<Font>(pathPrefix + "-Light"    );
		public static readonly Font Medium    = ResourcesSafe.Load<Font>(pathPrefix + "-Medium"   );
		public static readonly Font Regular   = ResourcesSafe.Load<Font>(pathPrefix + "-Regular"  );
		public static readonly Font Thin      = ResourcesSafe.Load<Font>(pathPrefix + "-Thin"     );
	}
}
