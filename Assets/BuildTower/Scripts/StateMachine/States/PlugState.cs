namespace BuildTower.Scripts.StateMachine.States
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