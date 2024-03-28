using UnityEngine;

namespace BuildTower.Scripts
{
    public class PointWithoutParent : MonoBehaviour
    {
        private void Awake()
        {
            transform.SetParent(null);
        }
    }
}