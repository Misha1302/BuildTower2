namespace BuildTower.Scripts.Helpers
{
    using UnityEngine;

    public abstract class SceneSingleton<TSelf> : MonoBehaviour, IInitable where TSelf : SceneSingleton<TSelf>
    {
        public static TSelf Instance { get; private set; }

        public void Init()
        {
            if (Instance != null)
            {
                Destroy(this);
                return;
            }

            Instance = (TSelf)this;

            OnInit();
        }

        protected virtual void OnInit()
        {
        }
    }
}