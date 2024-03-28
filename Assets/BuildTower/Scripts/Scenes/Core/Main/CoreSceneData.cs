namespace BuildTower.Scripts.Scenes.Core.Main
{
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Scenes.Core.Gameplay;
    using UnityEngine;

    public class CoreSceneData : SceneSingleton<CoreSceneData>
    {
        [SerializeField] private LevelGenerator levelGenerator;

        public InputManager InputManager { get; private set; }
        public LevelGenerator LevelGenerator => levelGenerator;

        protected override void OnInit()
        {
            InputManager = GameObjectCreator.Create<InputManager>();
        }
    }
}