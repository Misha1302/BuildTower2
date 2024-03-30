namespace BuildTower.Scripts.StateMachine.States.Implementations.Menu
{
    using UnityEngine;
    using UnityEngine.UI;

    public class UiManager : MonoBehaviour
    {
        [SerializeField] private Slider platformSpeedSlider;
        [SerializeField] private Button playButton;

        public Slider PlatformSpeedSlider => platformSpeedSlider;
        public Button PlayButton => playButton;
    }
}