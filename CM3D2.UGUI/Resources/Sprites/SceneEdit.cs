using UnityEngine;

namespace CM3D2.UGUI.Resources.Sprites
{
	public static class SceneEdit
	{
		public static readonly Texture2D AtlasSceneEdit = ResourcesSafe.Load<Texture2D>("sceneedit/mainmenu/atlas/atlassceneedit");

		public static readonly Sprite SliderRail = SpriteHelper.CreateSprite(
			"cm3d2_edit_slideberrail", // Yes, this is how KISS spelled it.
			AtlasSceneEdit,
			new Rect(463, 940, 7, 6),
			new Vector4(3, 0, 3, 0)
		);

		/// <summary>
		/// A white circle.
		/// Used for slider thumbs.
		/// </summary>
		public static readonly Sprite SliderCursor = SpriteHelper.CreateSprite(
			"cm3d2_edit_slidercursor",
			AtlasSceneEdit,
			new Rect(142, 483, 25, 25)
		);

		/// <summary>
		/// A small white circle with a shadow.
		/// Used for scrollbar thumbs.
		/// </summary>
		public static readonly Sprite ScrollCursor = SpriteHelper.CreateSprite(
			"cm3d2_edit_scrollcursor",
			AtlasSceneEdit,
			new Rect(100, 501, 33, 33)
		);

		/// <summary>
		/// A white circle outline around a triangle pointing up.
		/// Used for the up button on scrollbars.
		/// </summary>
		public static readonly Sprite ScrollButtonUp = SpriteHelper.CreateSprite(
			"cm3d2_edit_scrollbutton_up",
			AtlasSceneEdit,
			new Rect(84, 383, 51, 51)
		);

		/// <summary>
		/// A white circle outline around a triangle pointing down.
		/// Used for the down button on scrollbars.
		/// </summary>
		public static readonly Sprite ScrollButtonDown = SpriteHelper.CreateSprite(
			"cm3d2_edit_scrollbutton_down",
			AtlasSceneEdit,
			new Rect(84, 215, 51, 51)
		);

		/// <summary>
		/// A gray triangle pointing down.
		/// Used for dropdown controls.
		/// </summary>
		public static readonly Sprite PulldownArrow = SpriteHelper.CreateSprite(
			"cm3d2_edit_pulldown_arrow",
			AtlasSceneEdit,
			new Rect(632, 939, 17, 15)
		);
	}
}
