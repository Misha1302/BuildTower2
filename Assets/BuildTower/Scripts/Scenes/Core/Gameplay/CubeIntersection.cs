namespace BuildTower.Scripts.Scenes.Core.Gameplay
{
    using System;
    using BuildTower.Scripts.Helpers.Extensions;
    using UnityEngine;

    public static class CubeIntersection
    {
        // ReSharper disable Unity.InefficientPropertyAccess

        public static bool Intersect(Transform a, Transform b, out Intersection intersection)
        {
            Intersection(a, b, out intersection);

            return CanIntersect(a, b);
        }

        private static void Intersection(Transform a, Transform b, out Intersection intersection)
        {
            var c = ((a.position + b.position) / 2).WithY(Math.Max(a.position.y, b.position.y));
            var x = 2 * (a.lossyScale.x / 2 - Math.Abs(c.x - a.position.x));
            var z = 2 * (a.lossyScale.z / 2 - Math.Abs(c.z - a.position.z));
            intersection = new Intersection(x, z, c);
        }

        private static bool CanIntersect(Transform a, Transform b) =>
            Math.Abs(a.position.x - b.position.x) < a.lossyScale.x / 2 + b.lossyScale.x / 2
            && Math.Abs(a.position.z - b.position.z) < a.lossyScale.z / 2 + b.lossyScale.z / 2;
    }
}