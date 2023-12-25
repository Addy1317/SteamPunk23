using Insemble;
namespace StatePattern.StateMachine
{
    public interface IState
    {
        public PlayerController Owner { get; set; }

        public void OnStateEnter();
        public void Update();
        public void OnStateExit();
    }
}