namespace BuildTower.Scripts.Game
{
    using System.Linq;
    using BuildTower.Scripts.StateMachine.States;
    using Packages.Plugins.GamePush.Runtime.Modules;
    using UnityEngine;

    public class StatesSceneData : MonoBehaviour
    {
        [SerializeField] private StateBase defaultState;
        [SerializeField] private StateBase[] states;

        public StateBase DefaultState => defaultState;

        public StateBase[] States => states;

        private void Start()
        {
            foreach (var item in FindObjectsOfType<Transform>().SelectMany(x => x.GetComponents<ISceneStart>()))
                item.OnSceneStarted();
        }
    }
}