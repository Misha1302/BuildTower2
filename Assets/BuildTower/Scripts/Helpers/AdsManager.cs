namespace BuildTower.Scripts.Helpers
{
    using System;
    using JetBrains.Annotations;
    using Packages.Plugins.GamePush.Runtime.Modules;

    public static class AdsManager
    {
        public const float FullScreenChance = 1f;

        public static void ShowFullScreen(
            [CanBeNull] Action onStart = null,
            [CanBeNull] Action onEnd = null
        )
        {
            GP_Ads.ShowFullscreen(
                () => onStart?.Invoke(),
                _ => onEnd?.Invoke()
            );
        }

        public static void ShowRewarded(
            [CanBeNull] Action onRewarded = null,
            [CanBeNull] Action onStart = null,
            [CanBeNull] Action onEnd = null)
        {
            GP_Ads.ShowRewarded(
                Guid.NewGuid().ToString(),
                _ => onRewarded?.Invoke(),
                () => onStart?.Invoke(),
                _ => onEnd?.Invoke()
            );
        }
    }
}