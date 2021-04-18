using MedicineOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Controll
{
    class CustControll
    {
        List<Customer> list = new List<Customer>();
        public void custAdd(Customer cust)
        {
            list.Add(cust);
            Console.WriteLine("고객 정보 추가 완료!");
        } 
        public void custView()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("고객 데이터가 존재하지 않습니다.");
                return;
            }
            for(int i=0; i<list.Count;i++)
            {
                Console.WriteLine((i + 1) + "번 고객");
                Console.WriteLine(list[i].ToString());
            }
        }
        public void custDel(string id)
        {
            for (int i =0; i<list.Count;i++)
            {
                if(list[i].CustId.Equals(id))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
        public void custUpdate(string[] data)// 고객 증상 수정
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].CustId.Equals(data[0]))
                {
                    list[i].CustSymptom = data[1];
                }
            }
        }
        public void custDellAll()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            list.Clear();
            Console.WriteLine("모든 고객 정보를 삭제했습니다.");
        }
    }
}
