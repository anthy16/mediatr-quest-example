using MediatrQuestExample.Server.Models.DTOs;
using MediatrQuestExample.Server.Repositories;

namespace MediatrQuestExample.Server.Services
{
    public class QuestService : IQuestService
    {
        private readonly IQuestRepository _questRepository;

        public QuestService(IQuestRepository questRepository)
        {
            _questRepository = questRepository;
        }

        public List<QuestDTO> GetAllQuests()
        {
            var quests = _questRepository.GetAllQuests();
            
            return quests.Select(quest => {
                var questSteps = _questRepository.GetQuestSteps(quest.Id);

                return new QuestDTO(
                    quest.Id,
                    quest.Title,
                    quest.Description,
                    questSteps.Select(step => new QuestStepDTO(step.Id, step.Name, step.GoalType, step.GoalFieldType, step.GoalValue, step.StepNumber)).ToList(),
                    null);
                }).ToList();
        }
    }
}
