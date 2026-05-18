namespace NoteReminder.Models
{
    public class SimpleNote : Note
    {
        public override string GetNoteType() => "Звичайна";
        public override string GetSummary() => Content.Length > 30 ? Content.Substring(0, 30) + "..." : Content;
    }
}