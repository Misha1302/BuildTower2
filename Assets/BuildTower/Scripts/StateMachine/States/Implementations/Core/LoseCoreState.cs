namespace BuildTower.Scripts.StateMachine.States.Implementations.Core
{
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Scenes.Core.Main;

    public class LoseCoreState : StateBase
    {
        private static UiManager Ui => CoreSceneData.Instance.UIManager;

        public override void StateEnter()
        {
            Ui.GameOverPanel.SetActive(true);

            Ui.RestartButton.onClick.AddListener(Restart);
            Ui.MenuButton.onClick.AddListener(SetMenu);

            Ui.GameScore.SetText(DataManager.GameData.CurGameScore.ToString("0.##"));
            Ui.TotalScore.SetText(DataManager.GameData.TotalScore.ToString("0.##"));

            AdsManager.ShowRewarded();
        }

        private static void SetMenu() => RSceneManager.ChangeScene("Menu");
        private static void Restart() => RSceneManager.Restart();

        public override void StateLeave()
        {
            Ui.GameOverPanel.SetActive(false);

            CoreSceneData.Instance.UIManager.RestartButton.onClick.RemoveListener(Restart);
            CoreSceneData.Instance.UIManager.MenuButton.onClick.RemoveListener(SetMenu);
        }
    }
}