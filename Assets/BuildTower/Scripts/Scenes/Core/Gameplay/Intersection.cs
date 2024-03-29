namespace BuildTower.Scripts.Scenes.Core.Gameplay
{
    using UnityEngine;

    public class Intersection
    {
        public readonly float X;
        public readonly float Z;
        public readonly Vector3 C;

        public Intersection(float x, float z, Vector3 c)
        {
            X = x;
            Z = z;
            C = c;
        }
    }
}