namespace BuildTower.Scripts.StateMachine.States.Implementations.Menu
{
    using BuildTower.Scripts.Helpers;

    public class MenuState : StateBase
    {
        public override void StateEnter()
        {
            MenuSceneData.Instance.UIManager.PlayButton.onClick.AddListener(() => RSceneManager.ChangeScene("Core"));
        }

        public override void StateLeave()
        {
            DataManager.GameData.platformSpeedAdd = MenuSceneData.Instance.UIManager.PlatformSpeedSlider.value;
        }
    }
}