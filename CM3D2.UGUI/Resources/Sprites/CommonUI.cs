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
		/// A black bar with a rounded top. 
		/// Used for window titlebars.
		/// </summary>
		public static readonly Sprite PlateBlackTopWin = SpriteHelper.CreateSprite(
			"cm3d2_common_plate_black_top_win",
			AtlasCommon,
			new Rect(484, 413, 19, 19),
			new Vector4(8, 8, 8, 8)
		);

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
		/// The white outline of a rectangle with rounded edges that fades away at the top.
		/// Used with <see cref="PlateBlack"/> and <see cref="PlateBlackTopWin"/> to add a white outline to windows.
		/// </summary>
		public static readonly Sprite LineframeWhiteD = SpriteHelper.CreateSprite(
			"cm3d2_common_lineframe_white_d",
			AtlasCommon,
			new Rect(67, 4, 11, 11),
			new Vector4(4, 0, 4, 5)
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

		/// <summary>
		/// A small white circle with a <c>_</c>.
		/// Used for titlebar minimize button.
		/// </summary>
		public static readonly Sprite WinBtnMin = SpriteHelper.CreateSprite(
			"cm3d2_common_win_btn_min",
			AtlasCommon,
			new Rect(101, 16, 16, 16)
		);

		/// <summary>
		/// A small white circle with a <i>?</i>.
		/// Used for titlebar help button.
		/// </summary>
		public static readonly Sprite WinBtnHelp = SpriteHelper.CreateSprite(
			"cm3d2_common_win_btn_help",
			AtlasCommon,
			new Rect(84, 16, 16, 16)
		);

		/// <summary>
		/// A small white circle with an <i>X</i>.
		/// Used for titlebar end button.
		/// </summary>
		public static readonly Sprite WinBtnEnd = SpriteHelper.CreateSprite(
			"cm3d2_common_win_btn_end",
			AtlasCommon,
			new Rect(67, 16, 16, 16)
		);

		/// <summary>
		/// A small white circle with an <i>R</i>.
		/// Used for titlebar reset button.
		/// </summary>
		public static readonly Sprite WinBtnReset = SpriteHelper.CreateSprite(
			"cm3d2_common_win_btn_reset",
			AtlasCommon,
			new Rect(478, 341, 16, 16)
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
