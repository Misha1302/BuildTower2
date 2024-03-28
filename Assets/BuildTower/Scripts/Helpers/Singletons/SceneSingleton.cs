namespace BuildTower.Scripts.Helpers.Singletons
{
    using BuildTower.Scripts.Interfaces;
    using UnityEngine;

    public abstract class SceneSingleton<TSelf> : MonoBehaviour, IFirstOrderInitable where TSelf : SceneSingleton<TSelf>
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