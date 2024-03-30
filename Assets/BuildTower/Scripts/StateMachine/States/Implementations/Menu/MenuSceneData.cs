namespace BuildTower.Scripts.StateMachine.States.Implementations.Menu
{
    using BuildTower.Scripts.Helpers.Singletons;
    using UnityEngine;

    public class MenuSceneData : SceneSingleton<MenuSceneData>
    {
        [SerializeField] private UiManager uiManager;

        public UiManager UIManager => uiManager;
    }
}