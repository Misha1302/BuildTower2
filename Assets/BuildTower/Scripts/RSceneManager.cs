namespace BuildTower.Scripts
{
    using System;
    using System.Collections;
    using BuildTower.Scripts.Helpers;
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.SceneManagement;
    using Object = UnityEngine.Object;

    public static class RSceneManager
    {
        private static readonly SceneChangePanel _panel;

        public static readonly UnityEvent OnSceneChanged = new();

        static RSceneManager()
        {
            var sceneChangeCanvas = Resources.Load<GameObject>("Game/[SceneChangeCanvas]");
            var instance = Object.Instantiate(sceneChangeCanvas);
            _panel = instance.GetComponentInChildren<SceneChangePanel>();

            Object.DontDestroyOnLoad(instance);
            SceneManager.sceneLoaded += OnSceneChangedHandler;
        }

        private static void OnSceneChangedHandler(Scene scene, LoadSceneMode mode)
        {
            _panel.Whiting();
            InvokeAfter(OnSceneChanged.Invoke, _panel.WhitingLengthInSec);
        }

        public static void ChangeScene(string name)
        {
            _panel.Blacking();
            InvokeAfter(() => SceneManager.LoadScene(name), _panel.BlackingLengthInSec);
        }

        private static void InvokeAfter(this Action act, float time)
        {
            GameObjectCreator.Create<GameObjectCreator.EmptyMonoBeh>().StartCoroutine(InvokeAfterInternal());
            return;

            IEnumerator InvokeAfterInternal()
            {
                yield return new WaitForSeconds(time);
                act();
            }
        }
    }
}