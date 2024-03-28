namespace BuildTower.Scripts.StateMachine.States.Implementations
{
    using BuildTower.Scripts.Game;
    using BuildTower.Scripts.Scenes.Core.Main;

    public class StartCoreState : StateBase
    {
        public override void StateEnter()
        {
            // TODO: UI with text "press X or click to continue"

            CoreSceneData.Instance.InputManager.OnTouch.AddListener(StartGame);
        }

        public override void StateLeave()
        {
            CoreSceneData.Instance.InputManager.OnTouch.RemoveListener(StartGame);
        }

        private static void StartGame()
        {
            GameManager.Instance.RealtimeData.GameStateMachine.ChangeState<CoreState>();
        }
    }
}