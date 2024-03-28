namespace BuildTower.Scripts.Game
{
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Helpers.Singletons;
    using UnityEngine;

    public class GameManager : GameSingleton<GameManager>
    {
        [SerializeField] private GameRealtimeData realtimeData;

        public GameRealtimeData RealtimeData => realtimeData;

        protected override void OnAwake()
        {
            realtimeData.OnAwake();
            RSceneManager.OnSceneChanged.AddListener(RealtimeData.OnSceneChanged);
        }
    }
}