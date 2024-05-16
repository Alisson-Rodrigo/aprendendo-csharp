using System;
using System.Runtime.InteropServices;

//tipos genéricos

namespace MeuApp
{
 
    class Program {
        static void Main() {
            var person = new Person { Name = "João", Age = 20 };
            var payment = new Payment<Person> { Value = person };
            Console.WriteLine(payment.Value.Name);
            Console.WriteLine(payment.Value.Age);

            var data = new Data<Person>();
            data.Save(person);
            Console.WriteLine(data.Value.Name);
            Console.WriteLine(data.Value.Age);


        }

        public class Person {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Payment<T> {
            public T Value { get; set; }
        }

        public class Data<T> {
            public T Value { get; set; }

            public void Save(T value) {
                Value = value;
            }
        }


    }
}