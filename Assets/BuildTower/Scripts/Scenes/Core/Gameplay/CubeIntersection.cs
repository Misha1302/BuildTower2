namespace BuildTower.Scripts.Scenes.Core.Gameplay
{
    using System;
    using BuildTower.Scripts.Helpers.Extensions;
    using UnityEngine;

    public static class CubeIntersection
    {
        public static bool Intersect(Transform a, Transform b, out float x, out float z, out Vector3 c)
        {
            // ReSharper disable Unity.InefficientPropertyAccess

            c = ((a.position + b.position) / 2).WithY(Math.Max(a.position.y, b.position.y));
            x = 2 * (a.lossyScale.x / 2 - Math.Abs(c.x - a.position.x));
            z = 2 * (a.lossyScale.z / 2 - Math.Abs(c.z - a.position.z));

            return CanIntersect(a, b);
        }

        private static bool CanIntersect(Transform a, Transform b) =>
            Math.Abs(a.position.x - b.position.x) < a.lossyScale.x / 2 + b.lossyScale.x / 2
            && Math.Abs(a.position.z - b.position.z) < a.lossyScale.z / 2 + b.lossyScale.z / 2;
    }
}