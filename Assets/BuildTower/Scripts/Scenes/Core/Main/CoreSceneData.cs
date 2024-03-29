namespace BuildTower.Scripts.Scenes.Core.Main
{
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Helpers.Singletons;
    using BuildTower.Scripts.Scenes.Core.Gameplay;
    using UnityEngine;

    public class CoreSceneData : SceneSingleton<CoreSceneData>
    {
        [SerializeField] private LevelGenerator levelGenerator;
        [SerializeField] private UiManager uiManager;
        [SerializeField] private GameObject shadowCubePrefab;

        public InputManager InputManager { get; private set; }

        public LevelGenerator LevelGenerator => levelGenerator;
        public UiManager UIManager => uiManager;
        public GameObject ShadowCubePrefab => shadowCubePrefab;


        protected override void OnInit()
        {
            InputManager = GameObjectCreator.Create<InputManager>();
        }
    }
}