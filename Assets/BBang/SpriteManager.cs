using System.Collections.Generic;
using UnityEngine;

namespace BBang
{
    public class SpriteManager : MonoBehaviour
    {
        private static readonly Dictionary<string, Sprite> dict = new();

        public static Sprite GetSprite(string path)
        {
            if (dict.TryGetValue(path, out var sprite1)) return sprite1;
            var sprite = Resources.Load<Sprite>(path);
            if (sprite is null) return null;
            dict[path] = sprite;
            return sprite;
        }
    }
}
