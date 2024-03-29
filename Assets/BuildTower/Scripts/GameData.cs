namespace BuildTower.Scripts
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;

    [Serializable]
    public class GameData
    {
        [HideInInspector] [SerializeField] private float totalScore;
        [HideInInspector] [SerializeField] private float curGameScore;

        public readonly UnityEvent OnScoreChanged = new();

        public float TotalScore => totalScore;
        public float CurGameScore => curGameScore;

        public void NewGame()
        {
            curGameScore = 0;
        }

        public void IncScore(float value = 1)
        {
            totalScore += value;
            curGameScore += value;
            OnScoreChanged.Invoke();
        }
    }
}