namespace Operators
{
    public class Operator
    {

        public void Incremetor()
        {
            var a = 5;
            var b = a++;
            var c = ++a;
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
        }

        public void Ternar(int a )
        {
            float coef = a > 18 ? 1.6f : 0.9f;
            bool isEven2 = a % 2 == 0;
        }

        public void NullColeascing(Nullable<int> b)
        {
            int a;
            int? c = 7;
            var d = b ?? c;
        }

        public void NullConditional(string number)
        {
            var x = number?.Length;
            int y = x.GetValueOrDefault();
        }
    }
}