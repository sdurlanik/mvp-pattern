namespace SDurlanik.Mvp
{
    public interface ICommand
    {
        void Execute();
    }

    public class AbilityCommand : ICommand
    {
        private readonly AbilityData data;
        public float duration => data.duration;

        public AbilityCommand(AbilityData data)
        {
            this.data = data;
        }

        public void Execute()
        {
            EventBus<PlayerAbilityUsedEvent>.Raise(new PlayerAbilityUsedEvent
            {
                AbilityName = data.name
            });
        }
    }
}