namespace BuildTower.Scripts.StateMachine.States.Implementations.Core
{
    using BuildTower.Scripts.Helpers;

    public class LoseCoreState : StateBase
    {
        public override void StateEnter()
        {
            RSceneManager.ChangeScene("Menu");
        }
    }
}