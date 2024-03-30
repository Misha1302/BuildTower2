namespace BuildTower.Scripts.StateMachine.States.Implementations.Init
{
    using BuildTower.Scripts.Game;
    using BuildTower.Scripts.Helpers;

    public class InitState : StateBase, ISceneStart
    {
        public void OnSceneStarted()
        {
            RSceneManager.ChangeScene("Menu", false);
        }
    }
}