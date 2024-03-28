namespace BuildTower.Scripts.Scenes.Core.Start
{
    using UnityEngine;

    public class StartPanel : MonoBehaviour
    {
        [SerializeField] private GameObject panel;

        public void Enable()
        {
            panel.SetActive(true);
        }

        public void Disable()
        {
            panel.SetActive(false);
        }
    }
}