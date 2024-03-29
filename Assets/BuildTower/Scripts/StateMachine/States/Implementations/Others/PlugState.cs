namespace BuildTower.Scripts.StateMachine.States.Implementations.Others
{
    using BuildTower.Scripts.Game;

    public class PlugState : StateBase, ISceneStart
    {
        public void OnSceneStarted()
        {
            transform.SetParent(null);
            DontDestroyOnLoad(gameObject);
        }
    }
}