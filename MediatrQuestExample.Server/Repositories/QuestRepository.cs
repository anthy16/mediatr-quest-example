using MediatrQuestExample.Server.Constants;
using MediatrQuestExample.Server.Models.Domain;
using Microsoft.Extensions.Caching.Memory;

namespace MediatrQuestExample.Server.Repositories
{
    public class QuestRepository : IQuestRepository
    {
        private readonly IMemoryCache _memoryCache;
        private const string QuestsCacheKey = "Quests";

        public QuestRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;

            InitializeCache();
        }

        public List<Quest> GetAllQuests()
        {
            return _memoryCache.Get<List<Quest>>(QuestsCacheKey) ?? [];
        }

        public List<QuestStep> GetQuestSteps(Guid questId)
        {
            var allSteps = _memoryCache.Get<List<QuestStep>>($"{QuestsCacheKey}:Steps");

            return allSteps?.Where(step => step.QuestId.Equals(questId)).ToList() ?? [];
        }

        /// <summary>
        /// Initializes all quests, including goals and steps, in a local memory cache. 
        /// It's not pretty, but I can't be bothered to set up EF <3
        /// </summary>
        private void InitializeCache()
        {
            // Steps
            var stepsKey = $"{QuestsCacheKey}:Steps";

            var steps = new List<QuestStep>
            {
                new("c1b2a404-cb85-4557-b108-1a245bffba74", "e28f05a3-68db-40f7-9751-ea56c3ec2bba", "Kill 5 Goblins", QuestGoalTypes.GoblinKills, QuestGoalFieldTypes.Amount, "5", 1)
            };

            _memoryCache.Set(stepsKey, steps);

            // Quests
            var questsKey = QuestsCacheKey;

            var quests = new List<Quest>
            {
                new("e28f05a3-68db-40f7-9751-ea56c3ec2bba", "Goblin Slayer", "You want to be a hero, so you need to do a little bit of genocide", "c1b2a404-cb85-4557-b108-1a245bffba74")
            };

            _memoryCache.Set(questsKey, quests);
        }
    }
}
