using MediatrQuestExample.Server.Models.DTOs;

namespace MediatrQuestExample.Server.Services
{
    public interface IQuestService
    {
        List<QuestDTO> GetAllQuests();
    }
}