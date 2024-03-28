namespace BuildTower.Scripts.Helpers
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    [DefaultExecutionOrder(-5)]
    public abstract class GameSingleton<TSelf> : MonoBehaviour where TSelf : GameSingleton<TSelf>
    {
        public static TSelf Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
                return;
            }

            Instance = (TSelf)this;

            MakeGameSingleton();
            Init();
        }

        protected virtual void Init()
        {
        }

        private void MakeGameSingleton()
        {
            if (transform.parent != null)
                Thrower.Throw("Game singleton must have no parents");

            DontDestroyOnLoad(gameObject);

            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        protected virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
        }
    }
}