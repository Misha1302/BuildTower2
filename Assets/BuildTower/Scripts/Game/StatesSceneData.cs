namespace BuildTower.Scripts.Game
{
    using System.Linq;
    using BuildTower.Scripts.StateMachine.States;
    using UnityEngine;

    public class StatesSceneData : MonoBehaviour
    {
        [SerializeField] private StateBase defaultState;
        [SerializeField] private StateBase[] states;

        public StateBase DefaultState => defaultState;

        public StateBase[] States => states;

        private void Start()
        {
            foreach (var item in FindObjectsOfType<Transform>(true).SelectMany(x => x.GetComponents<ISceneStart>()))
                item.OnSceneStarted();
        }
    }
}