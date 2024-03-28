namespace BuildTower.Scripts.StateMachine.States.Implementations.Core
{
    using BuildTower.Scripts.Helpers;

    public class LoseCoreState : StateBase
    {
        public override void StateEnter()
        {
            AdsManager.ShowRewarded();
            RSceneManager.ChangeScene("Menu");
        }
    }
}