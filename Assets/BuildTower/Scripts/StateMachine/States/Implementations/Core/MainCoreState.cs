namespace BuildTower.Scripts.StateMachine.States.Implementations.Core
{
    using BuildTower.Scripts.Game;
    using BuildTower.Scripts.Scenes.Core.Gameplay;
    using BuildTower.Scripts.Scenes.Core.Main;
    using BuildTower.Scripts.StateMachine.States.Implementations.Init;
    using UnityEngine;

    public class MainCoreState : StateBase
    {
        private static LevelGenerator LvlGen => CoreSceneData.Instance.LevelGenerator;

        public override void StateEnter()
        {
            SpawnFirstCube();

            CoreSceneData.Instance.InputManager.OnTouch.AddListener(HandleNextCube);
            HandleNextCube();
        }

        public override void StateLeave()
        {
            CoreSceneData.Instance.InputManager.OnTouch.RemoveListener(HandleNextCube);
        }

        private static void SpawnFirstCube()
        {
            var cube = LvlGen.SpawnFirstCube();
            Destroy(cube.GetComponent<CubeMovement>());
        }

        private static void HandleNextCube()
        {
            if (!IntersectPrevCubeSuccessfully())
                return;

            DataManager.GameData.Score++;
            LvlGen.SpawnCube();
        }

        private static bool IntersectPrevCubeSuccessfully()
        {
            if (LvlGen.Cubes.Count < 2)
                return true;

            var success = CubeIntersection.Intersect(
                LvlGen.Cubes[^1].transform,
                LvlGen.Cubes[^2].transform,
                out var intersection
            );

            Destroy(LvlGen.Cubes[^1].GetComponent<CubeMovement>());

            if (!success)
            {
                GameManager.Instance.RealtimeData.GameStateMachine.ChangeState<LoseCoreState>();
                return false;
            }

            MakeShadow();

            CutCube(intersection);

            return true;
        }

        private static void CutCube(Intersection intersection)
        {
            var t = LvlGen.Cubes[^1];
            t.position = intersection.C;
            t.localScale = new Vector3(intersection.X, t.localScale.y, intersection.Z);
        }

        private static void MakeShadow()
        {
            var cube = Instantiate(CoreSceneData.Instance.ShadowCubePrefab).transform;
            cube.localScale = LvlGen.Cubes[^1].localScale;
            cube.position = LvlGen.Cubes[^1].position;
            cube.GetComponent<CubeShadow>().Shadow();
        }
    }
}