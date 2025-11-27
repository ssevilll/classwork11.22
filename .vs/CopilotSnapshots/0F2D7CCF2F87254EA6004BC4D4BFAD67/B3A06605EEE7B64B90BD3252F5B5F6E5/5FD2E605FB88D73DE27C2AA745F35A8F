namespace Classwork11._22.Task1.Model
{
    internal class GroupMate
    {
        public Student[] Students { get; set; }
        public static void Sort(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - i - 1; j++)
                {
                    if (students[j] > students[j + 1])
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

    }
}
