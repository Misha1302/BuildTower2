namespace BuildTower.Scripts.StateMachine.States.Implementations.Core
{
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Scenes.Core.Main;
    using UnityEngine;

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

            if (Random.Range(0f, 1f) < AdsManager.FullScreenChance)
                AdsManager.ShowFullScreen();
            else AdsManager.ShowRewarded();
        }

        private static void SetMenu() => RSceneManager.ChangeScene("Menu");
        private static void Restart() => RSceneManager.Restart();

        public override void StateLeave()
        {
            // Ui.GameOverPanel.SetActive(false);

            Ui.RestartButton.onClick.RemoveListener(Restart);
            Ui.MenuButton.onClick.RemoveListener(SetMenu);
        }
    }
}