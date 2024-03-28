namespace BuildTower.Scripts.StateMachine.States.Implementations.Others
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