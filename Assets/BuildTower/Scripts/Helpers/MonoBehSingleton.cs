namespace BuildTower.Scripts.Helpers
{
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.SceneManagement;

    [DefaultExecutionOrder(-5)]
    public class MonoBehSingleton<TSelf> : MonoBehaviour where TSelf : MonoBehSingleton<TSelf>
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

            Init();
        }

        protected virtual void Init()
        {
        }

        protected void MakeGameSingleton(UnityAction<Scene, LoadSceneMode> onSceneLoaded)
        {
            if (transform.parent != null)
                Thrower.Throw("Game singleton must have no parents");

            DontDestroyOnLoad(gameObject);

            SceneManager.sceneLoaded += onSceneLoaded;
        }
    }
}