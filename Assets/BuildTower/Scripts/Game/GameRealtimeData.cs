﻿namespace BuildTower.Scripts.Game
{
    using System;
    using System.Linq;
    using BuildTower.Scripts.Helpers;
    using BuildTower.Scripts.Interfaces;
    using BuildTower.Scripts.StateMachine;
    using UnityEngine;
    using Object = UnityEngine.Object;

    [Serializable]
    public class GameRealtimeData
    {
        public GameStateMachine GameStateMachine { get; private set; }

        public void OnAwake()
        {
            GameStateMachine = GameObjectCreator.Create<GameStateMachine>();
            Object.DontDestroyOnLoad(GameStateMachine.gameObject);
            OnSceneChanged();
        }

        public void OnSceneChanged()
        {
            foreach (var item in Object.FindObjectsOfType<Transform>().SelectMany(x => x.GetComponents<IInitable>()))
                item.Init();

            var sceneData = Object.FindObjectOfType<StatesSceneData>();
            GameStateMachine.AddOrSetStates(sceneData.States);
            GameStateMachine.ChangeState(sceneData.DefaultState.GetType());
        }
    }
}