namespace BuildTower.Scripts.StateMachine.States.Implementations
{
    using BuildTower.Scripts.Game;
    using BuildTower.Scripts.Scenes.Core.Gameplay;
    using BuildTower.Scripts.Scenes.Core.Main;
    using UnityEngine;

    public class CoreState : StateBase
    {
        private static LevelGenerator LvlGen => CoreSceneData.Instance.LevelGenerator;

        public override void StateEnter()
        {
            SpawnFirstCube();

            CoreSceneData.Instance.InputManager.OnTouch.AddListener(HandleNextCube);
            HandleNextCube();
        }

        private static void SpawnFirstCube()
        {
            var cube = LvlGen.SpawnFirstCube();
            Destroy(cube.GetComponent<CubeMovement>());
        }

        private static void HandleNextCube()
        {
            if (IntersectPrevCubeSuccessfully())
                LvlGen.SpawnCube();
        }

        private static bool IntersectPrevCubeSuccessfully()
        {
            if (LvlGen.Cubes.Count < 2)
                return true;

            var success = CubeIntersection.Intersect(
                LvlGen.Cubes[^1].transform,
                LvlGen.Cubes[^2].transform,
                out var x, out var z, out var pos
            );

            Destroy(LvlGen.Cubes[^1].GetComponent<CubeMovement>());

            if (!success)
            {
                GameManager.Instance.RealtimeData.GameStateMachine.ChangeState<LoseCoreState>();
                return false;
            }


            var t = LvlGen.Cubes[^1].transform;
            t.position = pos;
            t.localScale = new Vector3(x, t.localScale.y, z);

            return true;
        }
    }
}