namespace CodeFlow
{
    public class Flow
    {
        public void For()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void ForEach()
        {
            var collection = new List<string>();
            collection.Add("Andrei");
            collection.Add("Ana");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public void Continue()
        {
            // generam 10 nr ramdom
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                randomNumbers.Add(new Random().Next(0,100));
            }

            // suma numerelor pare
            var sum = 0;
            foreach (var number in randomNumbers)
            {
                if (number % 2 != 0)
                {
                    continue;
                }
                sum += number;
            }

        }
    }
}