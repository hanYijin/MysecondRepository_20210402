using ClassTest2.Controll;
using ClassTest2.Model;
using ClassTest2.Util;
using ClassTest2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            RandData rand = new RandData(); //싱글톤 패턴:생성된 하나의 객체를 사용하는 것
            Menu open = new Menu();
            CarControll carcon = new CarControll(rand);
            CustControll custcon = new CustControll(rand);
            SellControll sellcon = new SellControll(rand);
            while (true)
            {
                switch (open.mainManu())
                {
                    case Menu.MENU_MAIN_RAND:
                        Console.WriteLine("랜덤 차량 데이터 생성합니다. ");                    
                        carcon.insrtRandData(open.getRandSize());
                        Console.WriteLine("랜덤 고객 데이터 생성합니다.");
                        custcon.insrtRandCust(open.getRandSize());
                        Console.WriteLine("랜덤 직원 데이터 생성합니다.");
                        sellcon.insertRandSeller(open.getRandSize());
                        break;

                    case Menu.MENU_MAIN_DEL_ALL:
                        Console.WriteLine("모든 데이터 삭제합니다.");
                        carcon.removeAll();
                        custcon.removeAll();
                        sellcon.removeAll();
                        break;

                    case Menu.MENU_MAIN_VIEW:
                        Console.WriteLine("차량 데이터 출력합니다.");                       
                        carcon.carView();
                        Console.WriteLine("고객 데이터 출력합니다.");
                        custcon.custView();
                        Console.WriteLine("직원 데이터 출력합니다.");
                        sellcon.selView();
                        break;

                    case Menu.MENU_MAIN_ADD:
                        Console.WriteLine("데이터 추가합니다.");
                        carcon.addCarItem(open.addCarMenu2());
                        custcon.addCustItem(open.addCustMenu());
                        sellcon.addSellerItem(open.addSellerMenu());
                       
                        break;

                    case Menu.MENU_MAIN_DEL:
                        Console.WriteLine("데이터 삭제합니다.");
                        
                        break;

                    case Menu.MENU_MAIN_UPDATE:
                        Console.WriteLine("데이터 수정합니다.");
                        break;

                    case Menu.MENU_MAIN_EXIT:
                        Console.WriteLine("앱 종료됩니다.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
            
    }
 }

