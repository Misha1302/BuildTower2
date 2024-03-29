namespace BuildTower.Scripts.Scenes.Core
{
    using TMPro;
    using UnityEngine;

    [RequireComponent(typeof(TMP_Text))]
    public class ScoreText : MonoBehaviour
    {
        [SerializeField] private string format = "{0}";
        private TMP_Text _text;


        private void Start()
        {
            _text = GetComponent<TMP_Text>();

            DataManager.GameData.OnScoreChanged.AddListener(UpdateText);
            //UpdateText();
        }

        private void UpdateText()
        {
            _text.text = string.Format(format, DataManager.GameData.Score.ToString("0.##"));
        }
    }
}