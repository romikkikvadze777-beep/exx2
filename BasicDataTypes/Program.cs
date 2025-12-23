class Program{
static void Main()
        {
            string[] words = { "apple", "cat", "banana", "dog", "elephant" };
            var result = words.Where(w => w.Length > 3).ToArray();
            Console.WriteLine($"Task 7: {string.Join(", ", result)}");
        }
}
