using UnityEngine;
using UnityEngine.UI;
using UniverseLib.UI.Styles;

namespace CM3D2.UGUI.Resources
{
	public static class Styles
	{
		public static readonly ReadOnlyUISkin StandardSkin;

		/// <summary>
		/// Similar to the standard skin, but boxes, windows, etc. are
		/// a bit more transparent. Good for UIs with lots of stacked elements.
		/// </summary>
		public static readonly ReadOnlyUISkin AdvancedSkin;

		public static readonly ReadOnlyFrameStyle FrameOutline;
		public static readonly ReadOnlyFrameStyle FrameDark;
		public static readonly ReadOnlyButtonStyle ButtonRectangle;
		public static readonly ReadOnlyButtonStyle ButtonCircle;
		public static readonly ReadOnlyToggleStyle ToggleCheckbox;
		public static readonly ReadOnlyToggleStyle ToggleButton;
		public static readonly ReadOnlyToggleStyle ToggleButtonGroup;
		public static readonly ReadOnlyInputFieldStyle InputField;
		public static readonly ReadOnlyWindowStyle Window;
		public static readonly ReadOnlyWindowStyle WindowDialog;
		public static readonly ReadOnlyDropdownStyle Dropdown;

		static Styles()
		{
			var defaultSkin = UISkin.Default;

			ColorBlock buttonColorBlock = new ColorBlock()
			{
				normalColor      = new Color32(255, 255, 255, 171),
				highlightedColor = new Color32(255, 255, 255, 255),
				pressedColor     = new Color32(255, 255, 255, 200),
				disabledColor    = new Color32(100, 100, 100, 255),
				colorMultiplier  = 1f,
				fadeDuration     = 0.1f,
			};

			ColorBlock inputFieldColorBlock = new ColorBlock()
			{
				normalColor      = Color.white,
				highlightedColor = buttonColorBlock.highlightedColor,
				pressedColor     = Color.white,
				disabledColor    = buttonColorBlock.disabledColor,
				colorMultiplier  = buttonColorBlock.colorMultiplier,
				fadeDuration     = buttonColorBlock.fadeDuration,
			};

			TextComponentStyle textWhite = new()
			{
				Color = Color.white,
				Alignment = TextAnchor.MiddleCenter,
			};
			TextComponentStyle textBlack = new()
			{
				Color = Color.black,
				Alignment = TextAnchor.MiddleCenter,
			};

			SelectableComponentStyle backgroundButtonWhite = new()
			{
				Sprite = Sprites.CommonUI.PlateWhite,
				Colors = buttonColorBlock,
			};

			LayoutGroupStyle textLayoutGroup = new LayoutGroupStyle()
			{
				Padding = new Vector4(3, 3, 3, 3),
				Spacing = new Vector2(3, 3),
			};
			LayoutGroupStyle frameLayoutGroup = new LayoutGroupStyle()
			{
				Padding = new Vector4(6, 6, 6, 6),
				Spacing = new Vector2(3, 3),
			};



			// ---------- Standard Skin ----------

			var standardSkin = defaultSkin.DeepCopy();
			standardSkin.Name = "CM3D2StandardSkin";
			standardSkin.Text = new()
			{
				Font = Fonts.NotoSansCJKjp.DemiLight,
				FontSize = 16,
			};
			standardSkin.LayoutGroup = new() 
			{ 
				Spacing = new Vector2(3, 3),
			};
			StandardSkin = standardSkin.AsReadOnly();

			var frameOutline = standardSkin.Frame = new()
			{
				Name = "CM3D2FrameOutline",
				Text = textWhite,
				Background = new() { Sprite = Sprites.CommonUI.LineframeWhite, },
				LayoutGroup = frameLayoutGroup,
			};
			FrameOutline = frameOutline.AsReadOnly();

			var frameDark = new FrameStyle(frameOutline)
			{
				Name = "CM3D2FrameDark",
				Background = new() { Sprite = Sprites.CommonUI.PlateBlack, },
				LayoutGroup = frameLayoutGroup,
			};
			FrameDark = frameDark.AsReadOnly();

			var buttonRectangle = standardSkin.Button = new()
			{
				Name = "CM3D2ButtonRectangle",
				Text = textBlack,
				Background = backgroundButtonWhite.Copy(),
				LayoutGroup = textLayoutGroup,
			};
			ButtonRectangle = buttonRectangle.AsReadOnly();

			var buttonCircle = new ButtonStyle(buttonRectangle)
			{
				Name = "CM3D2ButtonCircle",
				Background = new() { Sprite = Sprites.CommonUI.MainButton, },
				LayoutGroup = textLayoutGroup,
			};
			ButtonCircle = buttonCircle.AsReadOnly();

			var toggleCheckbox = standardSkin.Toggle = new()
			{
				Name = "CM3D2ToggleCheckbox",
				Text = new(textWhite) { Alignment = TextAnchor.MiddleLeft, },
				Background = backgroundButtonWhite.Copy(),
				Overflow = new Vector4(0, 0, -1, 0),
				LayoutGroup = new(textLayoutGroup)
				{ 
					Padding = new(0, textLayoutGroup.Padding.y, textLayoutGroup.Padding.z, textLayoutGroup.Padding.w),
				},
				Checkmark = new() { Sprite = Sprites.CommonUI.Check02, },
				CheckboxSize = new Vector2(20, 20),
				CheckboxPadding = new Vector4(1, -1, 4, 4),
			};
			ToggleCheckbox = toggleCheckbox.AsReadOnly();

			var toggleButton = new ToggleStyle()
			{
				Name = "CM3D2ToggleButton",
				Text = textBlack,
				Background = backgroundButtonWhite.Copy(),
				LayoutGroup = textLayoutGroup,
				Checkmark = new()
				{
					Sprite = Sprites.CommonUI.LineframeGray,
					Color = new Color32(0, 86, 255, 255),
				},
				CheckboxPadding = new Vector4(1, 1, 1, 1),
			};
			ToggleButton = toggleButton.AsReadOnly();

			var toggleButtonGroup = new ToggleStyle(toggleButton)
			{
				Name = "CM3D2ToggleButtonGroup",
				Checkmark = new()
				{
					Sprite = Sprites.CommonUI.LineframeWhite,
					Color = new Color32(255, 226, 0, 255),
				},
			};
			ToggleButtonGroup = toggleButtonGroup.AsReadOnly();

			var inputField = standardSkin.InputField = new()
			{
				Name = "CM3D2InputField",
				Text = new(textBlack) { Alignment = TextAnchor.MiddleLeft, },
				Background = new()
				{
					Sprite = Sprites.CommonUI.PlateWhite,
					Colors = inputFieldColorBlock,
				},
				LayoutGroup = textLayoutGroup,
			};
			InputField = inputField.AsReadOnly();

			standardSkin.ScrollInputField = new(inputField)
			{
				Name = "CM3D2ScrollInputField",
			};

			var window = standardSkin.Window = new()
			{
				Name = "CM3D2Window",
				Background = new() { Sprite = Sprites.CommonUI.PlateBlack, },
				LayoutGroup = new(frameLayoutGroup) { Padding = new Vector4(4, 4, 4, 4), },
				Titlebar = new()
				{
					Text = new(textWhite) { Alignment = TextAnchor.MiddleLeft, },
					UseBackground = false,
					LayoutGroup = new(frameLayoutGroup) { ChildAlignment = TextAnchor.MiddleRight, },
				}
			};
			Window = window.AsReadOnly();

			var windowDialog = new WindowStyle(window)
			{
				Name = "CM3D2WindowDialog",
				Text = new(window.Text) { Alignment = TextAnchor.MiddleCenter, },
				Background = new() { Sprite = Sprites.SystemUI.DialogFrame, },
				Overflow = new Vector4(27, 27, 27, 27),
				LayoutGroup = new(frameLayoutGroup) { Padding = new Vector4(0, 0, 0, 0), },
			};
			WindowDialog = windowDialog.AsReadOnly();

			var dropdown = standardSkin.Dropdown = new()
			{
				Name = "CM3D2Dropdown",
				Text = new(textBlack) { Alignment = TextAnchor.MiddleLeft, },
				Background = backgroundButtonWhite.Copy(),
				LayoutGroup = textLayoutGroup,
				Arrow = new() { Sprite = Sprites.SceneEdit.PulldownArrow, },
				Viewport = new()
				{
					Background = new() { Sprite = Sprites.CommonUI.PlateWhite, },
					LayoutGroup = frameLayoutGroup,
				},
				Item = toggleButtonGroup.DeepCopy(),
			};
			Dropdown = dropdown.AsReadOnly();



			// ---------- Advanced Skin ----------

			var advancedSkin = standardSkin.ShallowCopy();
			advancedSkin.Name = "CM3D2AdvanceSkin";
			AdvancedSkin = advancedSkin.AsReadOnly();

			var frameDarkTransparent = advancedSkin.Frame = new(frameDark)
			{
				Name = "CM3D2FrameDarkTransparent",
				Background = new(frameDark.Background) { Color = new Color(1, 1, 1, 0.5f), },
			};

			var windowDialogTransparent = advancedSkin.Window = new(windowDialog)
			{
				Name = "CM3D2WindowDialogTransparent",
				Background = new(windowDialog.Background) { Color = new Color(1, 1, 1, 0.5f), },
			};
		}
	}
}
