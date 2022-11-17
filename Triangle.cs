using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enum_Main {
    public class Triangle {
        private int width;
        private int height;
        private string spacing = "==================";
        public string ans;

        public void CircumferenceOrArea() {
            InputData();
            ans = Console.ReadLine();

            switch (ans) {
                case  "one":
                
            }

            int circumference = width * 2 + height * 2;
            Console.WriteLine("the circumference of this triangle is: " + circumference);
            Console.WriteLine(spacing);

            int area = width * height / 2;
            Console.WriteLine("The area of this triangle is: " + area);
            Console.WriteLine(spacing);
        }
        private void InputData() {
            Console.WriteLine(spacing);
            Console.Write("Input width: ");
            width = int.Parse(Console.ReadLine());

            Console.Write("Input height: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine(spacing);
        }
    }
}