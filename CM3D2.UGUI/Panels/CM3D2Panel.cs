using UniverseLib.UI;
using UniverseLib.UI.Panels;
using UniverseLib.UI.Styles;

namespace CM3D2.UGUI.Panels
{
	public abstract class CM3D2Panel : Panel
	{
		public override IReadOnlyUISkin Skin => Resources.Styles.StandardSkin;

		protected CM3D2Panel(UIBase owner) : base(owner)
		{ }
	}
}
