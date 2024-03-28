namespace BuildTower.Scripts.Game
{
    using BuildTower.Scripts.Helpers;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class GameManager : GameSingleton<GameManager>
    {
        [SerializeField] private GameRealtimeData realtimeData;

        public GameRealtimeData RealtimeData => realtimeData;

        protected override void Init()
        {
            realtimeData.Init();
        }

        protected override void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            RealtimeData.OnSceneChanged();
        }
    }
}