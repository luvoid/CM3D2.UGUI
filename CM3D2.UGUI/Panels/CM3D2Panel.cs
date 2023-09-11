using UnityEngine;
using UniverseLib.UI;
using UniverseLib.UI.Models;
using UniverseLib.UI.Panels;
using UniverseLib.UI.Styles;
using CM3D2.UGUI.Resources;
using CM3D2.UGUI.Resources.Sprites;
using UnityEngine.UI;
using UniverseLib;

namespace CM3D2.UGUI.Panels
{
	public abstract class CM3D2Panel : Panel
	{
		public override IReadOnlyUISkin Skin => Styles.StandardSkin;

		protected CM3D2Panel(UIBase owner) : base(owner)
		{ }

		protected override IButtonModel CreateCloseButton(GameObject parent)
		{
			IReadOnlyUISkin skin = Skin ?? UISkin.Default;
			IReadOnlyWindowStyle windowStyle = Style ?? UISkin.Default.Window;

			if (CanDragAndResize)
			{
				ButtonModel resetBtn = Create.Button(parent, "Reset", "", skin.Button);
				Vector2 resetBtnSize = new Vector2(16, 16);
				UIFactory.SetLayoutElement(resetBtn.Component.gameObject, (int)resetBtnSize.x, (int)resetBtnSize.y, 0, 0, (int)resetBtnSize.x, (int)resetBtnSize.y);
				resetBtn.Background.sprite = CommonUI.WinBtnReset;
				resetBtn.OnClick = SetDefaultSizeAndPosition;

				ButtonModel minBtn = Create.Button(parent, "Minimize", "", skin.Button);
				Vector2 minBtnSize = new Vector2(16, 16);
				UIFactory.SetLayoutElement(minBtn.Component.gameObject, (int)minBtnSize.x, (int)minBtnSize.y, 0, 0, (int)minBtnSize.x, (int)minBtnSize.y);
				minBtn.Background.sprite = CommonUI.WinBtnMin;

				return minBtn;
			}
			else
			{
				ButtonModel closeBtn = Create.Button(parent, "Close", "", skin.Button);
				Vector2 minBtnSize = new Vector2(16, 16);
				UIFactory.SetLayoutElement(closeBtn.Component.gameObject, (int)minBtnSize.x, (int)minBtnSize.y, 0, 0, (int)minBtnSize.x, (int)minBtnSize.y);
				closeBtn.Background.sprite = CommonUI.WinBtnEnd;

				return closeBtn;
			}
		}

		protected override GameObject CreateBackground(GameObject parent)
		{
			IReadOnlyWindowStyle windowStyle = Style ?? UISkin.Default.Window;

			GameObject background = base.CreateBackground(parent);

			if (true || windowStyle.Background?.Sprite == Styles.Window.Background.Sprite)
			{
				Image outline = UIFactory.CreateUIObject(background, "Outline").AddComponent<Image>();
				outline.type = Image.Type.Sliced;
				outline.sprite = CommonUI.LineframeWhite;
				UIFactory.SetOffsets(outline.gameObject, Vector4.zero);

				if (true || windowStyle.Titlebar?.Background?.Sprite == Styles.Window.Titlebar.Background.Sprite)
				{
					outline.sprite = CommonUI.LineframeWhiteD;
					var outlineTransform = outline.transform.TryCast<RectTransform>();
					outlineTransform.offsetMax = new Vector2(0, -windowStyle.TitlebarHeight);
					outlineTransform.localScale = new Vector3(1, -1, 1);
				}

			}
			

			return background;
		}
	}
}
