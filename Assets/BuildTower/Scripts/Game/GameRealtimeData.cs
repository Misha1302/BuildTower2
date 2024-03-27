namespace BuildTower.Scripts.Game
{
    using System;
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.States;
    using UnityEngine.SceneManagement;
    using Object = UnityEngine.Object;

    [Serializable]
    public class GameRealtimeData
    {
        public GameStateMachine GameStateMachine { get; private set; }

        public void Init()
        {
            GameStateMachine = GameObjectCreator.Create<GameStateMachine>();
            Object.DontDestroyOnLoad(GameStateMachine.gameObject);
            OnSceneChanged();
        }

        public void OnSceneChanged(Scene scene = default, LoadSceneMode mode = default)
        {
            var sceneData = Object.FindObjectOfType<SceneData>();
            GameStateMachine.AddOrSetStates(sceneData.States);
            GameStateMachine.ChangeState(sceneData.DefaultState.GetType());
        }
    }
}