using MediatrQuestExample.Server.Models.Domain;

namespace MediatrQuestExample.Server.Repositories
{
    public interface IQuestRepository
    {
        List<Quest> GetAllQuests();
        List<QuestStep> GetQuestSteps(Guid questId);
    }
}