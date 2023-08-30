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

		public static readonly ReadOnlyPanelStyle BoxOutline;
		public static readonly ReadOnlyPanelStyle BoxDark;
		public static readonly ReadOnlyButtonStyle ButtonRectangle;
		public static readonly ReadOnlyButtonStyle ButtonCircle;
		public static readonly ReadOnlyToggleStyle ToggleCheckbox;
		public static readonly ReadOnlyToggleStyle ToggleButton;
		public static readonly ReadOnlyToggleStyle ToggleButtonGroup;
		public static readonly ReadOnlyInputFieldStyle InputField;
		public static readonly ReadOnlyPanelStyle  Window;
		public static readonly ReadOnlyPanelStyle  WindowDialog;

		static Styles()
		{
			var defaultSkin = UISkin.Default;

			ColorBlock colorBlock = new ColorBlock()
			{
				normalColor      = new Color32(255, 255, 255, 171),
				highlightedColor = new Color32(255, 255, 255, 255),
				pressedColor     = new Color32(255, 255, 255, 200),
				disabledColor    = new Color32(100, 100, 100, 255),
				colorMultiplier = 1f,
				fadeDuration = 0.1f,
			};

			Vector4 textPadding = new Vector4(3, 3, 3, 3);

			var standardSkin = defaultSkin.DeepCopy();
			StandardSkin = standardSkin.AsReadOnly();
			standardSkin.Name = "CM3D2StandardSkin";
			standardSkin.Text.Font = Fonts.NotoSansCJKjp.DemiLight;
			standardSkin.Text.FontSize = 16;

			var boxOutline = standardSkin.Box;
			BoxOutline = boxOutline.AsReadOnly();
			boxOutline.Name = "CM3D2BoxOutline";
			boxOutline.Text.Color = Color.white;
			boxOutline.Background.Sprite = Sprites.CommonUI.LineframeWhite;
			boxOutline.Padding = textPadding;

			var boxDark = boxOutline.DeepCopy();
			BoxDark = boxDark.AsReadOnly();
			boxDark.Name = "CM3D2BoxDark";
			boxDark.Background.Sprite = Sprites.CommonUI.PlateBlack100;
			boxDark.Padding = textPadding;

			var buttonRectangle = standardSkin.Button;
			ButtonRectangle = buttonRectangle.AsReadOnly();
			buttonRectangle.Name = "CM3D2ButtonRectangle";
			buttonRectangle.Text.Color = Color.black;
			buttonRectangle.Background.Sprite = Sprites.CommonUI.PlateWhite;
			buttonRectangle.Background.Colors = colorBlock;
			buttonRectangle.Padding = textPadding;

			var buttonCircle = ButtonRectangle.DeepCopy();
			ButtonCircle = buttonCircle.AsReadOnly();
			buttonCircle.Name = "CM3D2ButtonCircle";
			buttonCircle.Background.Sprite = Sprites.CommonUI.MainButton;
			buttonCircle.Padding = textPadding;

			var toggleCheckbox = standardSkin.Toggle;
			ToggleCheckbox = toggleCheckbox.AsReadOnly();
			toggleCheckbox.Name = "CM3D2ToggleCheckbox";
			toggleCheckbox.Text.Color = Color.white;
			toggleCheckbox.Background.Sprite = Sprites.CommonUI.PlateWhite;
			toggleCheckbox.Background.Colors = colorBlock;
			toggleCheckbox.Checkmark.Sprite = Sprites.CommonUI.Check02;
			toggleCheckbox.CheckboxSize = new Vector2(20, 20);
			toggleCheckbox.Overflow.x = 0;
			toggleCheckbox.Overflow.z = -1;
			toggleCheckbox.Padding = textPadding;
			toggleCheckbox.Padding.x += toggleCheckbox.CheckboxSize.x + textPadding.x;
			toggleCheckbox.CheckboxPadding = new Vector4(1, -1, 4, 4);

			var toggleButton = new ToggleStyle();
			ToggleButton = toggleButton.AsReadOnly();
			toggleButton.Name = "CM3D2ToggleButton";
			toggleButton.Text.Color = Color.black;
			toggleButton.Background.Sprite = Sprites.CommonUI.PlateWhite;
			toggleButton.Background.Colors = colorBlock;
			toggleButton.Checkmark.Sprite = Sprites.CommonUI.LineframeGray;
			toggleButton.Checkmark.Color = new Color32(0, 86, 255, 255);
			toggleButton.Padding = textPadding;
			toggleButton.CheckboxPadding = new Vector4(1, 1, 1, 1);

			var toggleButtonGroup = toggleButton.DeepCopy();
			ToggleButtonGroup = toggleButtonGroup.AsReadOnly();
			toggleButtonGroup.Name = "CM3D2ToggleButtonGroup";
			toggleButtonGroup.Checkmark.Sprite = Sprites.CommonUI.LineframeWhite;
			toggleButtonGroup.Checkmark.Color = new Color32(255, 226, 0, 255);
			toggleButtonGroup.Padding = textPadding;

			var inputField = standardSkin.InputField;
			InputField = inputField.AsReadOnly();
			inputField.Name = "CM3D2InputField";
			inputField.Text.Color = Color.black;
			inputField.Background.Sprite = Sprites.CommonUI.PlateWhite;
			inputField.Background.Colors = colorBlock;
			inputField.Background.Colors.normalColor = Color.white;
			inputField.Background.Colors.pressedColor = Color.white;
			inputField.Padding = textPadding;

			standardSkin.ScrollInputField = InputField.DeepCopy();
			standardSkin.ScrollInputField.Name = "CM3D2ScrollInputField";

			var window = standardSkin.Window;
			Window = window.AsReadOnly();
			window.Name = "CM3D2Window";
			window.Text.Alignment = TextAnchor.UpperLeft;
			window.Text.Color = Color.white;
			window.Background.Sprite = Sprites.CommonUI.PlateBlack100;
			window.ContentOffset = new Vector2(0, -20);
			window.Padding = new Vector4(4, 4, 20, 4);

			var windowDialog = window.DeepCopy();
			WindowDialog = windowDialog.AsReadOnly();
			windowDialog.Name = "CM3D2WindowDialog";
			windowDialog.Text.Alignment = TextAnchor.UpperCenter;
			windowDialog.Text.Color = Color.white;
			windowDialog.Background.Sprite = Sprites.SystemUI.DialogFrame;
			windowDialog.ContentOffset = new Vector2(0, -20);
			windowDialog.Padding = new Vector4(0, 0, 20, 0);
			windowDialog.Overflow = new Vector4(27, 27, 27, 27);


			// --- Advanced Skin ----
			var advancedSkin = standardSkin.ShallowCopy();
			AdvancedSkin = advancedSkin.AsReadOnly();

			var boxDarkTransparent = advancedSkin.Box = boxDark.DeepCopy();
			boxDarkTransparent.Name = "CM3D2BoxDarkTransparent";
			boxDarkTransparent.Background.Color = new Color(1, 1, 1, 0.5f);

			var windowDialogTransparent = advancedSkin.Window = windowDialog.DeepCopy();
			windowDialogTransparent.Name = "CM3D2BoxDarkTransparent";
			windowDialogTransparent.Background.Color = new Color(1, 1, 1, 0.5f);
		}
	}
}
