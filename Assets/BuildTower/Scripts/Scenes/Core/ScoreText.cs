namespace BuildTower.Scripts.Scenes.Core
{
    using System;
    using BuildTower.Scripts.Game;
    using BuildTower.Scripts.Scenes.Core.Main;
    using UnityEngine;

    [RequireComponent(typeof(GameText))]
    public class ScoreText : MonoBehaviour, ISceneStart
    {
        private readonly Lazy<GameText> _text;

        public ScoreText()
        {
            _text = new Lazy<GameText>(GetComponent<GameText>);
        }

        public void OnSceneStarted()
        {
            DataManager.GameData.OnScoreChanged.AddListener(UpdateText);
            UpdateText();
        }

        private void UpdateText()
        {
            _text.Value.SetText(DataManager.GameData.CurGameScore.ToString("0.##"));
        }
    }
}