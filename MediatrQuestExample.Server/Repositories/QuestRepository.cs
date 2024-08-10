using MediatrQuestExample.Server.Constants;
using MediatrQuestExample.Server.Models.Domain;
using Microsoft.Extensions.Caching.Memory;

namespace MediatrQuestExample.Server.Repositories
{
    public class QuestRepository
    {
        private readonly IMemoryCache _memoryCache;
        private const string QuestsCacheKey = "Quests";

        public QuestRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;

            InitializeCache();
        }

        /// <summary>
        /// Initializes all quests, including goals and steps, in a local memory cache. 
        /// It's not pretty, but I can't be bothered to set up EF <3
        /// </summary>
        private void InitializeCache()
        {
            // Goals
            var goalsKey = $"{QuestsCacheKey}:Goals";

            var goals = new List<QuestGoal> {
                new(Guid.Parse("3d347138-40a1-41ba-8ae5-398d47c9f399"), QuestGoalTypes.GoblinKills, QuestGoalFieldTypes.Amount, "5")
            };

            _memoryCache.Set(goalsKey, goals);

            // Steps
            var stepsKey = $"{QuestsCacheKey}:Steps";

            var steps = new List<QuestStep>
            {
                new(Guid.Parse("c1b2a404-cb85-4557-b108-1a245bffba74"), "Kill 5 Goblins", Guid.Parse("3d347138-40a1-41ba-8ae5-398d47c9f399"))
            };

            _memoryCache.Set(stepsKey, steps);

            // Quests
            var questsKey = QuestsCacheKey;

            var quests = new List<Quest>
            {
                new(Guid.Parse("e28f05a3-68db-40f7-9751-ea56c3ec2bba"), "Goblin Slayer", "You want to be a hero, so you need to do a little bit of genocide", Guid.Parse("c1b2a404-cb85-4557-b108-1a245bffba74"))
            };

            _memoryCache.Set(questsKey, quests);
        }
    }
}
