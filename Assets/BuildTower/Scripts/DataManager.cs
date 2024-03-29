namespace BuildTower.Scripts
{
    using System;
    using Packages.Plugins.GamePush.Runtime.Modules;
    using Packages.Plugins.GamePush.Runtime.Utilities;
    using UnityEngine;
    using UnityEngine.Events;

    public static class DataManager
    {
        private const string SaveKey = "savedata";

        public static readonly GameData GameData;

        static DataManager()
        {
            GameData = Load();
            GameData.OnScoreChanged.AddListener(SaveData);
        }

        private static GameData Load()
        {
            var json = PlayerPrefs.GetString(SaveKey);
            if (string.IsNullOrWhiteSpace(json))
                return new GameData();
            return JsonUtility.FromJson<GameData>(json) ?? new GameData();
        }

        private static void SaveData()
        {
            PlayerPrefs.SetString(SaveKey, JsonUtility.ToJson(GameData));
        }
    }

    [Serializable]
    public class GameData
    {
        [HideInInspector] [SerializeField] private float score;

        public readonly UnityEvent OnScoreChanged = new();

        public float Score
        {
            get => score;
            set
            {
                score = value;
                OnScoreChanged.Invoke();
            }
        }
    }
}