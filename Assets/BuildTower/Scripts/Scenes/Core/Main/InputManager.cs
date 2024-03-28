namespace BuildTower.Scripts.Scenes.Core.Main
{
    using UnityEngine;
    using UnityEngine.Events;

    public class InputManager : MonoBehaviour
    {
        public readonly UnityEvent OnTouch = new();

        private void Update()
        {
            if (PcInput() || MbInput())
                OnTouch?.Invoke();
        }

        private static bool MbInput() => Input.touchCount != 0 && Input.touches[0].phase == TouchPhase.Began;

        private static bool PcInput() => Input.GetKeyDown(KeyCode.X) || Input.GetMouseButtonDown(0);
    }
}