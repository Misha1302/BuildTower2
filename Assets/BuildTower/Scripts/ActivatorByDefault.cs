namespace BuildTower.Scripts
{
    using BuildTower.Scripts.Game;
    using UnityEngine;

    public class ActivatorByDefault : MonoBehaviour, ISceneStart
    {
        [SerializeField] private ActiveOrNot active;


        public void OnSceneStarted()
        {
            gameObject.SetActive(active == ActiveOrNot.Enabled);
        }


        private enum ActiveOrNot
        {
            Enabled,
            Disabled
        }
    }
}