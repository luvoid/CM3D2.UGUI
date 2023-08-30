using UnityEngine;

namespace CM3D2.UGUI.Resources.Sprites
{
	public static class Other
	{
		private static Texture2D AtlasCommon = CommonUI.AtlasCommon;
		private static Texture2D AtlasCommon2 = CommonUI.AtlasCommon2;
		private static Texture2D AtlasMessageWindow = SystemUI.AtlasMessageWindow;
		private static Texture2D AtlasSystemDialog = SystemUI.AtlasSystemDialog;


		public static readonly Sprite RectangleButton = SpriteHelper.CreateSprite(
			"RectangleButton",
			AtlasCommon,
			new Rect(359, 286, 120, 50), 
			new Vector4(4, 4, 4, 4)
		);

		public static readonly Sprite RectangleButtonShadow = SpriteHelper.CreateSprite(
			"RectangleButtonShadow",
			AtlasMessageWindow,
			new Rect(1269, 93, 55, 55),
			new Vector4(13, 13, 13, 13),
			200
		);

		public static readonly Sprite CircleButton = SpriteHelper.CreateSprite(
			"CircleButton",
			AtlasCommon2,
			new Rect(358, 223, 120, 120)
		);

		public static readonly Sprite LargeCircleButton = SpriteHelper.CreateSprite(
			"LargeCircleButton",
			ResourcesSafe.Load<Texture2D>("commonui/uguicommon/buttonframe120")
		);

		public static readonly Sprite PanelBackgroundBlack = SpriteHelper.CreateSprite(
			"PanelBackgroundBlack",
			ResourcesSafe.Load<Texture2D>("commonui/uguicommon/cm3d2_common_plate_black"),
			new Vector4(8, 8, 8, 8)
		);

		public static readonly Sprite PanelBackgroundWhite = SpriteHelper.CreateSprite(
			"PanelBackgroundWhite",
			ResourcesSafe.Load<Texture2D>("commonui/uguicommon/cm3d2_common_plate_white"),
			new Vector4(5, 5, 5, 5)
		);

		public static readonly Sprite PanelOutlineGray = SpriteHelper.CreateSprite(
			"PanelOutlineGray",
			ResourcesSafe.Load<Texture2D>("commonui/uguicommon/cm3d2_common_lineframe_gray"),
			new Vector4(5, 5, 5, 5)
		);

		public static readonly Sprite PanelOutlineGold = SpriteHelper.CreateSprite(
			"PanelOutlineGold",
			AtlasCommon2, 
			new Rect(0, 0, 362, 104), 
			new Vector4(6, 6, 6, 6)
		);

		public static readonly Sprite WindowBackground = SpriteHelper.CreateSprite(
			"WindowBackground",
			AtlasSystemDialog,
			new Rect(75, 199, 55, 56),
			new Vector4(27, 27, 27, 27)
		);
		
		public static readonly Sprite ToggleCheckbox = SpriteHelper.CreateSprite(
			"ToggleCheckbox",
			AtlasSystemDialog,
			new Rect(75, 199, 55, 56),
			new Vector4(27, 27, 27, 27)
		);
	}



	
}
