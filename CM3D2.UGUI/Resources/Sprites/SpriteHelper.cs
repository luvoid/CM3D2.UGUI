using System;
using UnityEngine;
using UniverseLib.Runtime;

namespace CM3D2.UGUI.Resources.Sprites
{
	internal static class SpriteHelper
	{
		public static Sprite CreateSprite(string name, Texture2D texture)
		{
			if (texture == null) throw new ArgumentNullException("texture");


			var sprite = TextureHelper.CreateSprite(texture);
			sprite.name = texture.name;
			return sprite;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="texture"></param>
		/// <param name="border">The border sizes of the Sprite (X=left, Y=bottom, Z=right, W=top).</param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static Sprite CreateSprite(string name, Texture2D texture, Vector4 border)
		{
			if (texture == null) throw new ArgumentNullException("texture");

			Rect position = new Rect(0, 0, texture.width, texture.height);
			return CreateSprite(name, texture, position, border);
		}

		/// <param name="position">
		/// Position should be defined in NGUI space (0,0 in the top-left corner,
		/// and +y going down the image). It will be converted to UGUI space before creating the sprite.
		/// </param>
		/// <param name="border">The border sizes of the Sprite (X=left, Y=bottom, Z=right, W=top).</param>
		public static Sprite CreateSprite(string name, Texture2D texture, Rect position, Vector4 border = default(Vector4), float pixesPerUnit = 100)
		{
			if (texture == null) throw new ArgumentNullException("texture");

			position.y = texture.height - position.y - position.height;
			position = ClampRectToTexture(position, texture);

			var sprite = TextureHelper.CreateSprite(
				texture,
				position,
				position.center,
				pixesPerUnit,
				0,
				border
			);

			sprite.name = name;

			return sprite;
		}

		private static Rect ClampRectToTexture(Rect rect, Texture2D texture)
		{
			rect.xMin = Mathf.Max(rect.xMin, 0);
			rect.xMax = Mathf.Min(rect.xMax, texture.width);
			rect.yMin = Mathf.Max(rect.yMin, 0);
			rect.yMax = Mathf.Min(rect.yMax, texture.height);
			return rect;
		}
	}
}
