namespace BuildTower.Scripts.StateMachine.States.Implementations
{
    public class LoseCoreState : StateBase
    {
        public override void StateEnter()
        {
            RSceneManager.ChangeScene("Menu");
        }
    }
}