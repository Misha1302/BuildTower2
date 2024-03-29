namespace BuildTower.Scripts.StateMachine.States.Implementations.Core
{
    using System.Collections;
    using UnityEngine;

    [RequireComponent(typeof(MeshRenderer))]
    public class CubeShadow : MonoBehaviour
    {
        [SerializeField] private float colorSpeed;
        [SerializeField] private float movementSpeed;

        public void Shadow()
        {
            StartCoroutine(ShadowCoroutine());
        }

        private IEnumerator ShadowCoroutine()
        {
            var fixedUpdate = new WaitForFixedUpdate();
            var meshRenderer = GetComponent<MeshRenderer>();

            // ReSharper disable Unity.InefficientPropertyAccess

            while (meshRenderer.material.color.a > 0)
            {
                var color = meshRenderer.material.color;
                color.a -= colorSpeed;
                meshRenderer.material.color = color;

                transform.Translate(Vector3.down * movementSpeed);

                yield return fixedUpdate;
            }

            Destroy(gameObject);
        }
    }
}