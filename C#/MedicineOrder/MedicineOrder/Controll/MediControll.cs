using MedicineOrder.Model;
using MedicineOrder.Util;
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
       
        MedicineData mediData;
        public MediControll()
        {
            list.Add(new Medicine("199303108", "타이레놀정 500mg", "두통", "1회 1~2정씩 1일 3-4회 필요시 복용한다.", "3100원"));
            list.Add(new Medicine("198601920", "어린이부루펜시럽", "두통", "성인 1회 200-400mg 1일 3-4회 경구투여한다. 어린이는 다음 1회 용량을 1일 3-4회 경구투여한다.", "7500원"));
            list.Add(new Medicine("196800036", "판콜에이내복액", "감기", "성인 1회 30ml 1일 3회 식후 30분에 복용한다.", "2600원"));
            list.Add(new Medicine("198700405", "베아제정", "소화불량", "성인 1회 1정 1일 3회 식후에 복용한다.", "1800원"));
            list.Add(new Medicine("200501321", "신신파스아렉스", "근육통", "1일 1~2회 환부(질환 부위)에 부착한다.", "3500원"));
            list.Add(new Medicine("200300546", "후시딘히드로연고", "피부질환", "1일 3회 적당량을 환부에 부드럽게 바른다.", "4500원"));
        }
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
