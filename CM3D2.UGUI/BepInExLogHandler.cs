using BepInEx.Logging;
using UnityEngine;
using UniverseLib;

namespace CM3D2.UGUI
{
	internal class BepInExLogHandler : ILogHandler
	{
		private readonly ManualLogSource manualLogSource;

		public BepInExLogHandler()
		{
			manualLogSource = BepInEx.Logging.Logger.CreateLogSource(Universe.NAME);
		}

		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			object message = GetMessage(context, string.Format(format, args));
			var logLevel = logType switch
			{
				LogType.Warning => LogLevel.Warning,
				LogType.Assert or LogType.Error or LogType.Exception => LogLevel.Error,
				_ => LogLevel.Info,
			};
			manualLogSource.Log(logLevel, message);
		}

		public void LogException(System.Exception exception, Object context)
		{
			object message = GetMessage(context, exception);

			manualLogSource.Log(LogLevel.Error, message);
		}

		private object GetMessage(Object context, object message)
		{
			if (context != null)
			{
				message = $"{context}: {message}";
			}
			return message;
		}
	}
}
