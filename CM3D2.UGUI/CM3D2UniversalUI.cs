using System;
using UnityEngine;
using UniverseLib;
using UniverseLib.UGUI;
using UniverseLib.UI;

namespace CM3D2.UGUI
{
	public static class CM3D2UniversalUI
	{
		/// <inheritdoc cref="UniversalUI.RegisterUI"/>
		public static UIBase RegisterUI(string id, Action updateMethod = null)
		{
			UpdateMethodWrapper wrapper = new UpdateMethodWrapper(updateMethod);
			wrapper.UIBase = UniversalUI.RegisterUI(id, wrapper.Update);
			return wrapper.UIBase;
		}

		/// <inheritdoc cref="UniversalUI.RegisterUI{T}"/>
		public static T RegisterUI<T>(string id, Action updateMethod = null)
			where T : UIBase
		{
			UpdateMethodWrapper wrapper = new UpdateMethodWrapper(updateMethod);
			var tUIBase = UniversalUI.RegisterUI<T>(id, wrapper.Update);
			wrapper.UIBase = tUIBase;
			return tUIBase;
		}

		/// <inheritdoc cref="UniversalUI.RegisterUGUI"/>
		public static UGUIBase RegisterUGUI(string id, Action updateMethod = null, params IUniversalUGUIBehaviour[] behaviours)
		{
			UpdateMethodWrapper wrapper = new UpdateMethodWrapper(updateMethod);
			var uguiBase = UniversalUI.RegisterUGUI(id, wrapper.Update, behaviours);
			uguiBase.Skin = (UGUISkin)Resources.Styles.StandardSkin; 
			wrapper.UIBase = uguiBase;
			return uguiBase;
		}

		/// <inheritdoc cref="UniversalUI.RegisterUGUI"/>
		public static UGUIBase RegisterUGUI(string id, params IUniversalUGUIBehaviour[] behaviours)
		{
			return RegisterUGUI(id, null, behaviours);
		}

		/// <inheritdoc cref="UniversalUI.RegisterUGUI{T}"/>
		public static T RegisterUGUI<T>(string id, Action updateMethod = null, params IUniversalUGUIBehaviour[] behaviours)
			where T : UGUIBase
		{
			UpdateMethodWrapper wrapper = new UpdateMethodWrapper(updateMethod);
			var uguiBase = UniversalUI.RegisterUGUI<T>(id, wrapper.Update, behaviours);
			uguiBase.Skin = (UGUISkin)Resources.Styles.StandardSkin;
			wrapper.UIBase = uguiBase;
			return uguiBase;
		}

		/// <inheritdoc cref="RegisterUGUI{T}"/>
		public static T RegisterUGUI<T>(string id, params IUniversalUGUIBehaviour[] behaviours)
			where T : UGUIBase
		{
			return RegisterUGUI<T>(id, null, behaviours);
		}

		private class UpdateMethodWrapper
		{
			public UIBase UIBase;
			private readonly Action updateMethod;

			public UpdateMethodWrapper(Action updateMethod)
			{
				this.updateMethod = updateMethod;
			}

			public void Update()
			{
				// Allows the UI to be visible in karaoke & VR mode
				UIBase.Canvas.worldCamera = null;

				if (updateMethod != null)
				{
					updateMethod.Invoke();
				}
			}
		}
	}
}
