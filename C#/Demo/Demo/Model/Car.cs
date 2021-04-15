using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    class Car
    {
        public const string JIJUM = "동대구영업소";

        private string model;
        private string color;
        private string company;

        public Car(string model, string color, string company)
        {
            this.model = model;
            this.color = color;
            this.company = company;
        }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }

        public void printInfoCar()
        {
            Console.WriteLine("모델: " + model + "\n" + "색상: " + color + "\n" + "제조사: " + company + "\n");
            Console.WriteLine("-------------------------------");
        }

        public override string ToString()
        {
            string str = "모델: " + model + "\n" + "제조사: " + company + "\n" + "색상: " + color + "\n" + "가격: " + price + "\n";
            str += "------------------------";
            return str;
        }
    }
}
