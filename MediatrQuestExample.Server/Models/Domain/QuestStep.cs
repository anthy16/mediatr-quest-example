using MediatrQuestExample.Server.Constants;

namespace MediatrQuestExample.Server.Models.Domain
{
    public class QuestStep
    {
        public QuestStep(string id, string questId, string name, QuestGoalTypes goalType, QuestGoalFieldTypes goalFieldType, string goalValue, int stepNumber)
        {
            Id = Guid.Parse(id);
            QuestId = Guid.Parse(questId);
            Name = name;
            GoalType = goalType;
            GoalFieldType = goalFieldType;
            GoalValue = goalValue;
            StepNumber = stepNumber;
        }

        public Guid Id { get; set; }
        public Guid QuestId { get; set; }
        public string Name { get; set; }
        public QuestGoalTypes GoalType { get; set; }
        public QuestGoalFieldTypes GoalFieldType { get; set; }
        public string GoalValue { get; set; }
        public int StepNumber { get; set; }
    }
}
