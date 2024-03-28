namespace BuildTower.Scripts.Scenes.Core
{
    using BuildTower.Scripts.Interfaces;
    using BuildTower.Scripts.Scenes.Core.Main;
    using Cinemachine;
    using UnityEngine;

    [RequireComponent(typeof(CinemachineVirtualCamera))]
    public class CoreCamera : MonoBehaviour, IInitable
    {
        public void Init()
        {
            var cam = GetComponent<CinemachineVirtualCamera>();

            var follow = CoreSceneData.Instance.LevelGenerator.MiddlePoint.Value;
            cam.Follow = follow;

            var pos = follow.position + cam.GetCinemachineComponent<CinemachineTransposer>().EffectiveOffset;
            cam.ForceCameraPosition(pos, cam.transform.rotation);
        }
    }
}