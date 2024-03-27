namespace BuildTower.Scripts.Game
{
    using BuildTower.Scripts.StateMachine.States;
    using UnityEngine;

    public class SceneData : MonoBehaviour
    {
        [SerializeField] private StateBase defaultState;
        [SerializeField] private StateBase[] states;

        public StateBase DefaultState => defaultState;

        public StateBase[] States => states;
    }
}