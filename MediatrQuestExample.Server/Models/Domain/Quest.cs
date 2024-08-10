namespace MediatrQuestExample.Server.Models.Domain
{
    public class Quest
    {
        public Quest(Guid id, string title, string description, Guid firstStepId, Guid? prerequisiteQuestId = null)
        {
            Id = id;
            Title = title;
            Description = description;
            FirstStepId = firstStepId;
            PrerequisiteQuestId = prerequisiteQuestId;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid FirstStepId { get; set; }
        public Guid? PrerequisiteQuestId { get; set; }
    }
}
