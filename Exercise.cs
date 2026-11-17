namespace workout_logger
{
    public class Exercise
    {
        public string Name { get; set; } = "";
        public List<Set> Sets { get; set; } = new List<Set>();
    }
}