namespace BuildTower.Scripts.Helpers
{
    using UnityEngine;

    public static class GameObjectCreator
    {
        public static GameObject Create() =>
            new();

        public static T Create<T>() where T : Component =>
            Create().AddComponent<T>();

        public static T2 Create<T, T2>() where T : Component where T2 : Component =>
            Create<T>().gameObject.AddComponent<T2>();

        public static T3 Create<T, T2, T3>() where T : Component where T2 : Component where T3 : Component =>
            Create<T, T2>().gameObject.AddComponent<T3>();
    }
}