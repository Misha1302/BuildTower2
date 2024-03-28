namespace BuildTower.Scripts.StateMachine
{
    using System;
    using System.Collections.Generic;
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.StateMachine.States;
    using BuildTower.Scripts.StateMachine.States.Implementations;
    using UnityEngine;

    public class GameStateMachine : MonoBehaviour
    {
        private readonly Dictionary<Type, StateBase> _states = new();
        private StateBase _curState;

        private void Awake()
        {
            _curState = GameObjectCreator.Create<PlugState>();
            AddOrSetStates(new[] { _curState });
        }

        private void Update() => _curState.StateUpdate();

        private void FixedUpdate() => _curState.StateFixedUpdate();

        public void ChangeState<T>() where T : StateBase => ChangeState(typeof(T));

        public void ChangeState(Type type)
        {
            _curState.StateLeave();
            _curState = _states[type];
            _curState.StateEnter();
        }

        public void AddOrSetStates(IEnumerable<StateBase> states)
        {
            foreach (var state in states)
                _states[state.GetType()] = state;
        }
    }
}