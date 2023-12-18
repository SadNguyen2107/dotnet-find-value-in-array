namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };

            Console.Write("Enter a name’s student:");
            string? input_name = Console.ReadLine();

            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                // Look For The Student
                if (students[i] == input_name)
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                Console.WriteLine("Not found " + input_name + " in the list.");
            }
        }
    }
}