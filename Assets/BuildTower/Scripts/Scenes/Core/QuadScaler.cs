namespace BuildTower.Scripts.Scenes.Core
{
    using BuildTower.Scripts.Game;
    using UnityEngine;

    public class QuadScaler : MonoBehaviour, ISceneStart
    {
        public void OnSceneStarted()
        {
            var quadHeight = Camera.main!.orthographicSize * 2.0f;
            var quadWidth = quadHeight * Screen.width / Screen.height;
            transform.localScale = new Vector3(quadWidth, quadHeight, 1);
        }
    }
}