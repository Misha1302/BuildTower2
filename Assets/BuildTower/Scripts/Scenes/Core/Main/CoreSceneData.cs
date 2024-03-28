namespace BuildTower.Scripts.Scenes.Core.Main
{
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Scenes.Core.Gameplay;
    using UnityEngine;

    public class CoreSceneData : SceneSingleton<CoreSceneData>
    {
        [SerializeField] private LevelGenerator levelGenerator;
        [SerializeField] private UiManager uiManager;

        public InputManager InputManager { get; private set; }

        public LevelGenerator LevelGenerator => levelGenerator;
        public UiManager UIManager => uiManager;


        protected override void OnInit()
        {
            InputManager = GameObjectCreator.Create<InputManager>();
        }
    }
}