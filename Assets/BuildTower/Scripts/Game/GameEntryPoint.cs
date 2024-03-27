namespace BuildTower.Scripts.Game
{
    using UnityEngine;

    public static class GameEntryPoint
    {
        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {
            var gameManager = Resources.Load("Game/[GameManager]");
            Object.Instantiate(gameManager);
        }
    }
}