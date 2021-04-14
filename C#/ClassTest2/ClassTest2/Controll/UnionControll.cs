using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Controll
{
    class UnionControll
    {
        CarControll carHandle;
        CustControll custHandle;
        SellControll sellHandle;

        public UnionControll(RandData rand)
        {
            carHandle = new CarControll(rand);
            custHandle = new CustControll(rand);
            sellHandle = new SellControll(rand);
        }

        public UnionControll(CarControll carHandle, CustControll custHandle, SellControll sellHandle)
        {
            this.carHandle = carHandle;
            this.custHandle = custHandle;
            this.sellHandle = sellHandle;
        }

        internal CarControll CarHandle { get => carHandle; set => carHandle = value; }
        internal CustControll CustHandle { get => custHandle; set => custHandle = value; }
        internal SellControll SellHandle { get => sellHandle; set => sellHandle = value; }
    }
}
