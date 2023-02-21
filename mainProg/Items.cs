using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainProg
{
    public class Items
    {
        public Dictionary<string, Item> list { get; set; }
        public Items()
        {
            list= new Dictionary<string, Item>();   
        }
        public void run()
        {
            list.Add("a", new Item(){ Id = 1 ,Name="banana"}) ;
            list.Add("b", new Item() { Id = 2, Name = "apple" });
            list.Add("c", new Item() { Id = 3, Name = "orange" });
        }
        public int Calc(string itemName,int count)
        {
            Item item =list[itemName];
            return item.Price*count;
        }
        public int Plus(int a,int b)
        {
            return a+b; 
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
