// Задача необязательная FIZZ BUZZ
Enumerable.Range(1, 100).ToList().ForEach(_ =>
            {
                Console.WriteLine(_ % 3 != 0 && _ % 5 != 0
                    ? _.ToString()
                    : (_ % 3 == 0 ? "Fizz" : String.Empty)
                    + (_ % 5 == 0 ? "Buzz" : String.Empty));
            });
