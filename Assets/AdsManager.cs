using System;
using System.Collections.Generic;
using GamePush;
using UnityEngine;

public class AdsManager : MonoBehaviour
{
    private readonly Dictionary<string, Action> _actions = new();


    private void OnEnable() => GP_Ads.OnRewardedReward += OnRewarded;
    private void OnDisable() => GP_Ads.OnRewardedReward -= OnRewarded;


    public void ShowRewarded(Action onRewarded)
    {
        var id = Guid.NewGuid().ToString();
        _actions[id] = onRewarded;
        GP_Ads.ShowRewarded(id);
    }


    private void OnRewarded(string id)
    {
        _actions[id].Invoke();
        _actions.Remove(id);
    }
}