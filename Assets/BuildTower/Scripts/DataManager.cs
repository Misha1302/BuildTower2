namespace BuildTower.Scripts
{
    using UnityEngine;

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
}