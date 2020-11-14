using System;
using System.Collections;
using System.Text;

namespace LR4
{
    class Think : IThink
    {
        static public string[] foodThink = new string[] { "Не пойти ли мне поесть", "Хочу есть", "Хочу в KFC" };
        static public string[] studyThink = new string[] { "Пора учиться", "Нужно взяться за учебу", "Время отдыха" };
        static public string[] gameThink = new string[] { "Не пойти ли поиграть", "Хочу играть", "На сегодня хватит игр" };
        static Random random = new Random();
        static Stack stack = new Stack();
        enum TypeThink
        {
            study,
            food,
            game
        }

        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(random.Next(v.Length));
        }

        static public void GenerateThink()
        {
            var value = RandomEnumValue<TypeThink>();
            if (value.ToString() == "study")
                stack.Push(studyThink[random.Next(0, 3)]);
            else if (value.ToString() == "food")
                stack.Push(foodThink[random.Next(0, 3)]);
            else stack.Push(gameThink[random.Next(0, 3)]);
            Console.WriteLine(stack.Pop());
        }

        public string GetThinkInfo()
        {
            return stack.Pop().ToString();
        }

        public bool GetDecision()
        {
            return random.Next(20) <= 10;
        }
    }

    interface IThink
    {
        public string GetThinkInfo();
        public bool GetDecision();
    }
}
