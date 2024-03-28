namespace BuildTower.Scripts.StateMachine.States.Implementations.Others
{
    using BuildTower.Scripts.Helpers;

    public class MenuState : StateBase
    {
        public override void StateEnter()
        {
            RSceneManager.ChangeScene("Core");
        }
    }
}