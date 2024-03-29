namespace BuildTower.Scripts.StateMachine.States.Implementations.Init
{
    using BuildTower.Scripts.Helpers;

    public class InitState : StateBase
    {
        public override void StateEnter()
        {
            // GP_Player.Login();
            // GP_Player.Sync();
            RSceneManager.ChangeScene("Menu");
        }
    }
}