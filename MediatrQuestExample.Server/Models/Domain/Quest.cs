namespace MediatrQuestExample.Server.Models.Domain
{
    public class Quest
    {
        public Quest(string id, string title, string description, string firstStepId, string? prerequisiteQuestId = null)
        {
            Id = Guid.Parse(id);
            Title = title;
            Description = description;
            FirstStepId = Guid.Parse(firstStepId);
            PrerequisiteQuestId = prerequisiteQuestId != null ? Guid.Parse(prerequisiteQuestId) : null;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid FirstStepId { get; set; }
        public Guid? PrerequisiteQuestId { get; set; }
    }
}
