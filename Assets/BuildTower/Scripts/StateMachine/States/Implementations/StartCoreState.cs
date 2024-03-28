namespace BuildTower.Scripts.StateMachine.States.Implementations
{
    using BuildTower.Scripts.Game;
    using BuildTower.Scripts.Scenes.Core.Main;

    public class StartCoreState : StateBase
    {
        public override void StateEnter()
        {
            CoreSceneData.Instance.UIManager.StartPanel.Enable();
            CoreSceneData.Instance.InputManager.OnTouch.AddListener(StartGame);
        }

        public override void StateLeave()
        {
            CoreSceneData.Instance.UIManager.StartPanel.Disable();
            CoreSceneData.Instance.InputManager.OnTouch.RemoveListener(StartGame);
        }

        private static void StartGame()
        {
            GameManager.Instance.RealtimeData.GameStateMachine.ChangeState<CoreState>();
        }
    }
}