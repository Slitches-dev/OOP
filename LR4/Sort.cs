using System;

namespace LR4
{
    class Sort
    {
        public void InsertionSort()
        {
            string[] Student = new string[] { "Бугаев", "Андрей", "Бухалов", "Денис", "Грачев", "Данила", "Досаева", "Сабина", "Парамонов", "Владимир", "Кияткин", "Кирилл", "Лукин", "Максим", "Петин", "Григорий", "Пронникова", "Татьяна" };
            string[] firstName = new string[Student.Length/2];
            for(int i = 1; i<Student.Length;i+=2)
            {
                firstName[i / 2] = Student[i];
            }
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < firstName.Length - 1; ++i)
                    if (firstName[i].CompareTo(firstName[i + 1]) > 0)
                    {
                        string buf = firstName[i];
                        firstName[i] = firstName[i + 1];
                        firstName[i + 1] = buf;
                        flag = true;
                    }
            }
            for (int i = 0; i < firstName.Length; i++) Console.WriteLine(firstName[i]);
            Console.ReadKey();
        }
    }
}
