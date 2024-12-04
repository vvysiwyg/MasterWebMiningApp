namespace MasterWebMiningApp.Features.EEC.Test
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
        public bool IsActive { get; set; }

        public string GetCssClass() => IsActive ? "d-block" : "d-none";
    }
}
