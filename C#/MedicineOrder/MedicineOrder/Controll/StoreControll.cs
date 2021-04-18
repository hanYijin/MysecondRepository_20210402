using MedicineOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Controll
{
    class StoreControll
    {
        List<Store> list = new List<Store>();
        public void storeAdd(Store sto)
        {
            list.Add(sto);
            Console.WriteLine("약국 데이터를 추가하였습니다.");
        }
        public void storeView()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine((i + 1) + "번");
                Console.WriteLine(list[i].ToString());
            }

        }
        public void storeDel(string sto)
        {
            for(int i=0;i<list.Count;i++)
            {
                if (list[i].StoName.Equals(sto))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
        public void storeUpdate(string[] sto)
        {
            for(int i=0; i < list.Count; i++)
            {
                if (list[i].StoName.Equals(sto[0]))
                {
                    list[i].StoName = sto[1];
                    list[i].Manager = sto[2];
                    list[i].Address = sto[3];
                    list[i].Phone = sto[4];
                }
            }
        }
        public void stoDellAll()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            list.Clear();
            Console.WriteLine("모든 약국 정보를 삭제했습니다.");
        }
    }
}
