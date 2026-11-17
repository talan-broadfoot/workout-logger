namespace workout_logger
{
    public class Workout
    {
        public DateTime Date { get; set; }
        public WorkoutType Type { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
