namespace BuildTower.Scripts.Game
{
    using BuildTower.Scripts.Helpers;
    using UnityEngine;

    public class GameManager : MonoBehSingleton<GameManager>
    {
        [SerializeField] private GameRealtimeData realtimeData;

        public GameRealtimeData RealtimeData => realtimeData;

        protected override void Init()
        {
            realtimeData.Init();
            MakeGameSingleton(RealtimeData.OnSceneChanged);
        }
    }
}