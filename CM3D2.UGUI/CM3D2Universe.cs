using BepInEx.Logging;
using UnityEngine;
using UniverseLib;
using UniverseLib.Config;

namespace CM3D2.UGUI
{
	public static class CM3D2Universe
	{
		public static readonly ILogHandler DefaultLogHandler = Application.isEditor ? Debug.logger : new BepInExLogHandler();

		public static readonly UniverseLibConfig DefaultConfig = new UniverseLibConfig()
		{
			Force_Unlock_Mouse = true,
			Allow_UI_Selection_Outside_UIBase = true,
			Disable_EventSystem_Override = false,
			Disable_Fallback_EventSystem_Search = false,
		};

		public static void Init(System.Action onInitialized)
		{
			Universe.Init(0f, onInitialized, DefaultLogHandler, DefaultConfig);
		}

		public static void Init(float startupDelay, System.Action onInitialized)
		{
			Universe.Init(startupDelay, onInitialized, DefaultLogHandler, DefaultConfig);
		}
	}
}
