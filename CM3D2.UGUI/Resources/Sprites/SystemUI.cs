using UnityEngine;

namespace CM3D2.UGUI.Resources.Sprites
{
	public static class SystemUI
	{
		public static readonly Texture2D AtlasMessageWindow = ResourcesSafe.Load<Texture2D>("systemui/messagewindow/main/atlas/atlasmessagewindow");
		public static readonly Texture2D AtlasSystemDialog = ResourcesSafe.Load<Texture2D>("systemui/systemdialog/atlas/systemdialog");

		/// <summary>
		/// Used for dialog windows. Has a large shadow, white outline,
		/// and slightly-transparent black background.
		/// </summary>
		public static readonly Sprite DialogFrame = SpriteHelper.CreateSprite(
			"cm3d2_dialog_frame",
			AtlasSystemDialog,
			new Rect(75, 256, 56, 58),
			new Vector4(28, 28, 28, 28)
		);
	}
}
