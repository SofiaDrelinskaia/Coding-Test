namespace CodingTest
{
    internal class Methods
    {
        //Problem 1
        public static List<B> Map<A, B>(List<A> list, Func<A, B> f) {
            List<B> result = new List<B>();
            foreach (A x in list)
            {
                result.Add(f(x));
            }
            return result;
        }

        //Problem 2
        public static B Fold<A, B>(List<A> list, B initial, Func<B, A, B> folder) {
            B result = initial;
            foreach (A x in list) 
            {
                result = folder(result, x);
            }
            return result;
        }

        //Problem 3
        public static List<B> Map2<A, B>(List<A> list, Func<A, B> f) {
            List<B> result = new List<B>();
            foreach (A x in list)
            {
                result.Add(Fold<A, B>(new List<A>(new A[] {x}), default, (def, x) => f(x)));
            }
            return result;
        }
    }
}
