namespace BuildTower.Scripts.StateMachine.States
{
    using UnityEngine;

    public abstract class StateBase : MonoBehaviour
    {
        public virtual void StateUpdate()
        {
        }

        public virtual void StateFixedUpdate()
        {
        }

        public virtual void StateEnter()
        {
        }

        public virtual void StateLeave()
        {
        }
    }
}