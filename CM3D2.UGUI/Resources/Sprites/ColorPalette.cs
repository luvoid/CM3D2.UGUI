using UnityEngine;

namespace CM3D2.UGUI.Resources.Sprites
{
	public static class ColorPalette
	{
		public static readonly Texture2D AtlasColorPalette = ResourcesSafe.Load<Texture2D>("sceneedit/colorpalette/atlas/atlascolorpalette");
		public static readonly Texture2D AtlasColorPalette2 = ResourcesSafe.Load<Texture2D>("sceneedit/colorpalette/atlas/atlascolorpalette2");

		/// <summary>
		/// A white bar with rounded edges.
		/// Used for the hue slider on the color palettes.
		/// </summary>
		public static readonly Sprite SliderCursor01 = SpriteHelper.CreateSprite(
			"cm3d2_colorpalette_slidercursor01",
			AtlasColorPalette,
			new Rect(393, 344, 36, 26)
		);
	}
}
