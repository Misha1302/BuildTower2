namespace BuildTower.Scripts.Scenes.Core.Main
{
    using BuildTower.Scripts.Scenes.Core.Start;
    using UnityEngine;

    public class UiManager : MonoBehaviour
    {
        [SerializeField] private StartPanel startPanel;

        public StartPanel StartPanel => startPanel;
    }
}