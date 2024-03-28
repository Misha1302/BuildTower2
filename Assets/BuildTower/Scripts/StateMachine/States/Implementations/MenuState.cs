namespace BuildTower.Scripts.StateMachine.States.Implementations
{
    using UnityEngine.SceneManagement;

    public class MenuState : StateBase
    {
        public override void StateEnter()
        {
            SceneManager.LoadScene("Core");
        }
    }
}