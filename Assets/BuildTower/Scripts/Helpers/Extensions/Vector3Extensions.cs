namespace BuildTower.Scripts.Helpers.Extensions
{
    using UnityEngine;

    public static class Vector3Extensions
    {
        public static Vector3 WithY(this Vector3 vec, float y)
        {
            vec.y = y;
            return vec;
        }

        public static Vector3 AddY(this Vector3 vec, float addValue)
        {
            vec.y += addValue;
            return vec;
        }
    }
}