namespace BuildTower.Scripts.Scenes.Core.Main
{
    using System;
    using TMPro;
    using UnityEngine;

    [RequireComponent(typeof(TMP_Text))]
    public class GameText : MonoBehaviour
    {
        [SerializeField] private string format = "{}";

        private readonly Lazy<TMP_Text> _text;

        public GameText()
        {
            _text = new Lazy<TMP_Text>(GetComponent<TMP_Text>);
        }

        public void SetText(string t)
        {
            _text.Value.text = string.Format(format.Replace("{}", "{0}"), t);
        }
    }
}