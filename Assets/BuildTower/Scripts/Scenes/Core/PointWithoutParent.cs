namespace BuildTower.Scripts.Scenes.Core
{
    using UnityEngine;

    public class PointWithoutParent : MonoBehaviour
    {
        private void Awake()
        {
            transform.SetParent(null);
        }
    }
}