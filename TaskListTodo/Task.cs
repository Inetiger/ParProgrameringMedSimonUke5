namespace ParProgrameringMedSimonUke5.TaskListTodo
{
    internal class Task
    {
        public string Name { get; set; }
        public string Beskrivelse { get; set; }

        public Task(string name, string beskrivelse)
        {
            Name = name;
            Beskrivelse = beskrivelse;
        }

        public void PrintTaskInfo()
        {
            Console.WriteLine($"Denne oppgaven handler om:\n{Beskrivelse}");
        }
    }
}
