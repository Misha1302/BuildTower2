namespace BuildTower.Scripts.Scenes.Core
{
    using BuildTower.Scripts.Game;
    using UnityEngine;

    public class PointWithoutParent : MonoBehaviour, ISceneStart
    {
        public void OnSceneStarted()
        {
            transform.SetParent(null);
        }
    }
}