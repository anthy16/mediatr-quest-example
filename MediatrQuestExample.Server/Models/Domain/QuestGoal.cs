using MediatrQuestExample.Server.Constants;

namespace MediatrQuestExample.Server.Models.Domain
{
    public class QuestGoal
    {
        public QuestGoal(Guid id, QuestGoalTypes type, QuestGoalFieldTypes fieldType, string value)
        {
            Id = id;
            Type = type;
            FieldType = fieldType;
            Value = value;
        }

        public Guid Id { get; set; }
        public QuestGoalTypes Type { get; set; }
        public QuestGoalFieldTypes FieldType { get; set; }
        public string Value { get; set; }
    }
}
