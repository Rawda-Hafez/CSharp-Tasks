namespace T_1
{
    public static class Extensions
    {
        // 6. String extension method: IsPalindrome (two-pointer loop, no LINQ)
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str)) return true;
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (char.ToLower(str[left]) != char.ToLower(str[right]))
                    return false;
                left++;
                right--;
            }
            return true;
        }

        // 7. Int extension method: IsPrime (loop up to sqrt(number), no LINQ)
        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // 8. Array extension method: Sum (using loop, no built-in LINQ Sum)
        public static int Sum(this int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
    }
}
