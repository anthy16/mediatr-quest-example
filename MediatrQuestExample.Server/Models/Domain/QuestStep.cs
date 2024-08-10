namespace MediatrQuestExample.Server.Models.Domain
{
    public class QuestStep
    {
        public QuestStep(Guid id, string name, Guid goalId, Guid? nextStepId = null)
        {
            Id = id;
            Name = name;
            GoalId = goalId;
            NextStepId = nextStepId;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid GoalId { get; set; }
        public Guid? NextStepId { get; set; }
    }
}
