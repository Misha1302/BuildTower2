namespace BuildTower.Scripts.Scenes.Core.Gameplay
{
    using UnityEngine;

    public class CubeMovement : MonoBehaviour
    {
        private bool _inited;

        private Vector3 _point1;
        private Vector3 _point2;
        private float _speed;

        private void Update()
        {
            if (!_inited)
                return;

            transform.position = Vector3.Lerp(_point1, _point2, Mathf.PingPong(Time.time * _speed, 1));
        }

        public void Init(Vector3 point1, Vector3 point2, float speed)
        {
            _point1 = point1;
            _point2 = point2;
            _speed = speed;
            _inited = true;
        }
    }
}