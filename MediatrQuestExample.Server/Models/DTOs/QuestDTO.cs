namespace MediatrQuestExample.Server.Models.DTOs
{
    public record QuestDTO(
        Guid Id,
        string Title,
        string Description,
        List<QuestStepDTO> Steps,
        Guid? PrerequisiteQuestId);
}
