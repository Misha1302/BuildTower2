namespace BuildTower.Scripts.Scenes.Core.Main
{
    using BuildTower.Scripts.Scenes.Core.Start;
    using UnityEngine;
    using UnityEngine.UI;

    public class UiManager : MonoBehaviour
    {
        [SerializeField] private StartPanel startPanel;
        [SerializeField] private Button restartButton;
        [SerializeField] private Button menuButton;
        [SerializeField] private GameText gameScore;
        [SerializeField] private GameText totalScore;
        [SerializeField] private GameObject gameOverPanel;

        public StartPanel StartPanel => startPanel;
        public Button RestartButton => restartButton;
        public Button MenuButton => menuButton;
        public GameText GameScore => gameScore;
        public GameText TotalScore => totalScore;
        public GameObject GameOverPanel => gameOverPanel;
    }
}