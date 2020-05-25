using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Reflection;
using System.Diagnostics;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter(@"C:\Users\TosikiTatebe\Desktop\sales.csv");   //1へ
            var amountperstore = sales.GetPerStoreSales();                              //4へ
            foreach(var obj in amountperstore)
            {
                Console.WriteLine
                    ($"{obj.Key}    {obj.Value}");
            }
            Console.ReadKey();
        }
    }
    public class Sale
    {
        //店舗名
        public string ShopName { get; set; }
        //商品名
        public string ProductName { get; set; }
        //売上
        public int Amount { get; set; }

    }
   
}
    
 