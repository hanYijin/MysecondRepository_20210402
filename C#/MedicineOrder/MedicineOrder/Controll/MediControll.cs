using MedicineOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Controll
{
    class MediControll
    {
        List<Medicine> list = new List<Medicine>();
        public void mediAdd(Medicine medi)
        {
            list.Add(medi);
            Console.WriteLine("약품 정보 추가 완료!");
        }

        public void mediView()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for(int i=0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
        public void mediDel(string medi)
        {
            for(int i =0; i<list.Count; i++)
            {
                if (list[i].PId.Equals(medi[0]))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
        public void mediUpdate(string[] medi)
        {
            for(int i=0; i<list.Count; i++)
            {
                if(list[i].PId.Equals(medi[0]))
                {
                    list[i].MediName = medi[1];
                    list[i].Effect = medi[2];
                    list[i].Takeing = medi[3];
                    list[i].Price = medi[4];
                }
            }
        }
        public void mediDellAll()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            list.Clear();
            Console.WriteLine("모든 약품 정보를 삭제하였습니다.");
        }

    }
}
