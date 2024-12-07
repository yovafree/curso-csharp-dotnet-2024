class Program {
    static void Main() {
        // Specify the data source.
        int[] scores = { 97, 92, 81, 60, 32, 77, 83, 20, 68, 88 };

        // Define the query expression.

        // List, Dictionary, Enurmerable, Querable

        IEnumerable<int> scoreQuery =
            from a in scores
            where a > 80
            orderby a descending
            select a;

        // Execute the query.
        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine($"Cantidad de registros mayores a 80: {scoreQuery.Count()}");

        // Output: 97 92 81


        int[] numbers = [ 0, 1, 2, 3, 4, 5, 6 ];

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }

    }
}