using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Temp : MonoBehaviour
{
    [SerializeField] private AdsManager adsManager;
    [SerializeField] private Button rnd;
    [SerializeField] private Button add;

    private void Start()
    {
        add.onClick.AddListener(() => adsManager.ShowRewarded(OnFullscreenClose));
        rnd.onClick.AddListener(() => FindObjectOfType<TMP_Text>().text = Random.Range(0, 123).ToString());
    }

    private void OnFullscreenClose()
    {
        Debug.LogWarning("Shown");
    }
}