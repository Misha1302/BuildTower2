namespace BuildTower.Scripts.StateMachine.States
{
    using UnityEngine.SceneManagement;

    public class StartState : StateBase
    {
        private int _count;

        public override void StateFixedUpdate()
        {
            print(GetType());
            if (_count++ == 150)
                SceneManager.LoadScene("Menu");
        }
    }
}