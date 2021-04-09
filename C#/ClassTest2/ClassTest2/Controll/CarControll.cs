using ClassTest2.Model;
using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Controll
{
    class CarControll
    {
        List<Car> list = new List<Car>();//using ClassTest2.Model;
        RandData rand;
        public CarControll(RandData rand)
        {
            this.rand = rand;
        }

        public void insrtRandData(int count)
        {
            for(int i=0; i<count;i++)
            {
                list.Add(new Car(rand.getModel(),rand.getColor(),rand.getCompany(),rand.getPrice()));
            }
        }
        public void carView()
        {
            if(list.Count==0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for(int i =0; i<list.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(list[i].ToString());
            }
        }
        public void carView2()
        {
            if(list.Count==0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                list[i].printInfoCar();
            }
        }
        public void removeAll()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            list.Clear();//리스트를 비운다
        }
        public void addCarItem(Car car)
        {
            list.Add(car);
        }
       

    }
}
