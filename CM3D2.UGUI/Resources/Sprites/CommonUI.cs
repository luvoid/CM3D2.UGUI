using UnityEngine;
using UniverseLib.Runtime;

namespace CM3D2.UGUI.Resources.Sprites
{
	public static class CommonUI
	{
		//[System.Obsolete("This atlas varies between game versions.")]
		//public static readonly Texture2D AtlasCommon  = ResourcesSafe.Load<Texture2D>("commonui/atlas/atlascommon");

		public static readonly Texture2D AtlasCommon = Bundles.CommonUI.LoadAsset<Texture2D>("atlascommon");

		public static readonly Texture2D AtlasCommon2 = ResourcesSafe.Load<Texture2D>("commonui/atlas/atlascommon2");

		/// <summary>
		/// A white rectangle with rounded edges.
		/// Used for buttons, toggles, panels, etc.
		/// </summary>
		public static readonly Sprite PlateWhite = ResourcesSafe.Load<Sprite>("commonui/uguicommon/cm3d2_common_plate_white");

		/// <summary>
		/// A Rectangle with rounded corners.
		/// More of a dark navy blue than black, and is slightly-transparent.
		/// Used for window backgrounds.
		/// </summary>
		public static readonly Sprite PlateBlack = ResourcesSafe.Load<Sprite>("commonui/uguicommon/cm3d2_common_plate_black");

		/// <summary>
		/// The white outline of a rectangle with rounded edges.
		/// Used with <see cref="PlateBlack"/> to add a white outline.
		/// </summary>
		public static readonly Sprite LineframeWhite = SpriteHelper.CreateSprite(
			"cm3d2_common_lineframe_white",
			AtlasCommon,
			new Rect(495, 346, 11, 11),
			new Vector4(6, 6, 6, 6)
		);

		/// <summary>
		/// The gray outline of a rectangle with rounded edges.
		/// Used as the outline of toggle buttons when in the "on" state.
		/// </summary>
		/// <remarks>NGUI Padding: (0, 2, 0, 0)</remarks>
		public static readonly Sprite LineframeGray = ResourcesSafe.Load<Sprite>("commonui/uguicommon/cm3d2_common_lineframe_gray");

		/// <summary>
		/// This is really just a plain white square.
		/// Used for dividers and scrollbars.
		/// </summary>
		public static readonly Sprite Line3White = SpriteHelper.CreateSprite(
			"cm3d2_common_line3_white",
			Texture2DExtensions.Fill(TextureHelper.NewTexture2D(3, 3), Color.white),
			//AtlasCommon,
			//new Rect(508, 509, 3, 3),
			new Vector4(1, 1, 1, 1)
		);

		/// <summary>
		/// A small, black, stylistic checkmark.
		/// Used for toggle checkboxes.
		/// </summary>
		public static readonly Sprite Check02 = SpriteHelper.CreateSprite(
			"cm3d2_check02",
			AtlasCommon,
			new Rect(489, 329, 20, 11)
		);

		/// <summary>
		/// A large white circle with a subtle shadow.
		/// Used for buttons.
		/// </summary>
		/// <remarks>NGUI Padding: (1, 1, 1, 1)</remarks>
		public static readonly Sprite MainButton = SpriteHelper.CreateSprite(
			"main_button",
			AtlasCommon2,
			new Rect(359, 170, 118, 118)
		);



		private static class Texture2DExtensions
		{
			public static Texture2D Fill(Texture2D texture, Color color)
			{
				return Fill(texture, new Rect(0, 0, texture.width, texture.height), color);
			}

			public static Texture2D Fill(Texture2D texture, Rect fillArea, Color color)
			{
				for (int x = (int)fillArea.min.x; x < fillArea.max.x; x++)
				{
					for (int y = (int)fillArea.min.y; y < fillArea.max.y; y++)
					{
						texture.SetPixel(x, y, color);
					}
				}
				texture.Apply();
				return texture;
			}
		}
	}
}
