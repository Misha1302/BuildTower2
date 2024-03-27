namespace BuildTower.Scripts
{
    using System;
    using System.Collections.Generic;
    using GamePush;

    public static class AdsManager
    {
        private static readonly Dictionary<string, Action> _actions = new();

        public static void ShowRewarded(Action onRewarded)
        {
            var id = Guid.NewGuid().ToString();
            _actions[id] = onRewarded;
            GP_Ads.ShowRewarded(id);
        }


        private static void OnRewarded(string id)
        {
            _actions[id].Invoke();
            _actions.Remove(id);
        }
    }
}