namespace BuildTower.Scripts.StateMachine.States.Implementations
{
    public class PlugState : StateBase
    {
        private void Awake()
        {
            transform.SetParent(null);
            DontDestroyOnLoad(gameObject);
        }
    }
}