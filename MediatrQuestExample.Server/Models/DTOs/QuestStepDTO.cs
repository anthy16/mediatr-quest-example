using MediatrQuestExample.Server.Constants;

namespace MediatrQuestExample.Server.Models.DTOs
{
    public record QuestStepDTO(
        Guid Id,
        string Name,
        QuestGoalTypes GoalType,
        QuestGoalFieldTypes GoalFieldType,
        string GoalValue,
        int StepNumber);
}
