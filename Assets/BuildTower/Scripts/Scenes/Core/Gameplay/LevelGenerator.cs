namespace BuildTower.Scripts.Scenes.Core.Gameplay
{
    using System;
    using System.Collections.Generic;
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Helpers.Extensions;
    using UnityEngine;

    public class LevelGenerator : MonoBehaviour
    {
        [SerializeField] private CubeMovement cubePrefab;

        [SerializeField] private Vector3 startSize;

        [SerializeField] private Transform firstMovementPoint;
        [SerializeField] private Transform secondMovementPoint;
        [SerializeField] private float cubeSpeed;

        private readonly List<Transform> _cubes = new();

        public readonly Lazy<Transform> MiddlePoint;

        public LevelGenerator()
        {
            MiddlePoint = new Lazy<Transform>(() =>
            {
                var t = GameObjectCreator.Create().transform;
                t.position = StartPosition;
                return t;
            });
        }

        public IReadOnlyList<Transform> Cubes => _cubes;
        private Vector3 StartPosition => (firstMovementPoint.position + secondMovementPoint.position) / 2;

        public CubeMovement SpawnCube()
        {
            // ReSharper disable Unity.InefficientPropertyAccess
            GetValues(out var position, out var size);

            var instance = Instantiate(cubePrefab);

            instance.Init(
                firstMovementPoint.position.WithY(position.y),
                secondMovementPoint.position.WithY(position.y),
                cubeSpeed + DataManager.GameData.platformSpeedAdd
            );

            MiddlePoint.Value.transform.position = instance.transform.position = position;
            instance.transform.localScale = size;

            _cubes.Add(instance.transform);

            return instance;
        }

        public CubeMovement SpawnFirstCube() => SpawnCube();

        private void GetValues(out Vector3 position, out Vector3 size)
        {
            if (_cubes.Count == 0)
            {
                position = StartPosition;
                size = startSize;
            }
            else
            {
                position = _cubes[^1].position.AddY(startSize.y);
                size = _cubes[^1].lossyScale;
            }
        }
    }
}