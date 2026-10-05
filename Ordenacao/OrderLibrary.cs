namespace OrderLibrary {

    class OrderLibrary() {

        private readonly int[] v = [5, 6, 4, 1, 3, 8, 7]; // O(1)
        
        public void BubbleSort() {
            for (int i = 0; i<v.Length; i++) // O(n)
            {
                for (int j = 0; j<v.Length - 1; j++) // O(n-1)
                {
                    if (v[j] > v[j + 1]) // O(1)
                    {
                        (v[j + 1], v[j]) = (v[j], v[j + 1]);
                    }
                }
            }
    
            Console.WriteLine(string.Join(", ", v)); // O(n)
    
            // O(1) + O(n) + O(n²) + O(n) = O(n²)
        }
    }
}