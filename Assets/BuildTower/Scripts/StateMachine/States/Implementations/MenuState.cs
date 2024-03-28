namespace BuildTower.Scripts.StateMachine.States.Implementations
{
    public class MenuState : StateBase
    {
        public override void StateEnter()
        {
            RSceneManager.ChangeScene("Core");
        }
    }
}