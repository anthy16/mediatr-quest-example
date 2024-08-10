namespace MediatrQuestExample.Server.Models.Domain
{
    public class QuestProgress
    {
        public Guid QuestId { get; set; }
        public Guid StepId { get; set; }
        public int? Counter { get; set; }
        public bool IsCompleted { get; set; }
    }
}
