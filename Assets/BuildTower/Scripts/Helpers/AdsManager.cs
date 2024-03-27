namespace BuildTower.Scripts.Helpers
{
    using System;
    using GamePush;

    public static class AdsManager
    {
        public static void ShowRewarded(Action onRewarded, Action onStart = null, Action onEnd = null)
        {
            GP_Ads.ShowRewarded(
                Guid.NewGuid().ToString(),
                _ => onRewarded(),
                () => onStart?.Invoke(),
                _ => onEnd?.Invoke()
            );
        }
    }
}