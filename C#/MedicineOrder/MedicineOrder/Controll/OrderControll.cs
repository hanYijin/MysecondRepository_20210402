using MedicineOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Controll
{
    class OrderControll
    {
        CustControll custcon;
        MediControll medicon;
        StoreControll storecon;
        List<Buying<Customer, Medicine, Store>> orderlist = new List<Buying<Customer, Medicine, Store>>();

        public OrderControll(CustControll custcon, MediControll medicon, StoreControll storecon)
        {
            this.custcon = custcon;
            this.medicon = medicon;
            this.storecon = storecon;
        }

        internal CustControll Custcon { get => custcon; set => custcon = value; }
        internal MediControll Medicon { get => medicon; set => medicon = value; }
        internal StoreControll Storecon { get => storecon; set => storecon = value; }

        public void orderAdd(Buying<Customer,Medicine,Store>order)
        {
            orderlist.Add(order);
            Console.WriteLine("거래 내역 데이터가 추가되었습니다.");
        }
        public void orderView()
        {
            if(orderlist.Count==0)
            {
                Console.WriteLine("거래 내역 데이터가 존재하지 않습니다.");
            }
            for(int i=0;i<orderlist.Count;i++)
            {
                Console.WriteLine((i + 1) + "번째");
                Console.WriteLine(orderlist[i].ToString());
                Console.WriteLine("----------------------------------------------------");
            }
        }
        public void orderSimpleView()
        {
            if (orderlist.Count == 0)
            {
                Console.WriteLine("거래 내역 데이터가 존재하지 않습니다.");
            }
            for (int i = 0; i < orderlist.Count; i++)
            {
                Console.WriteLine((i + 1) + "번째");
                orderlist[i].buyingInfo();
                Console.WriteLine("----------------------------------------------------");
            }
        }
        public void orderDellAll()
        {
            if (orderlist.Count == 0)
            {
                Console.WriteLine("거래 데이터가 존재하지 않습니다.");
                return;
            }
            orderlist.Clear();
            Console.WriteLine("모든 거래 내역이 삭제되었습니다.");
        }
    }
}
