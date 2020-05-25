using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SalesCounter
    {
        //2.フィールド
        private IEnumerable<Sale> _sales;

        //1.saleオブジェクトを受け取り、フィールド_salesに代入する。
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);   //3へ
        }

        //3.csvファイルを読み込み、List型のsalesオブジェクトを返す
        public static IEnumerable<Sale>　ReadSales(string filePath)
        {            
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductName = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        //4.店舗別売り上げを求める 戻り値の型はdictionary　引数なし
        public IDictionary<string,int> GetPerStoreSales()
        {
            //インスタンス生成
            var dict = new Dictionary<string, int>();
            //_salesディクショナリからSaleオブジェクトを一つづつ取り出し処理
            foreach(var sale in _sales)
            {
                //指定したshopnameがdict内に格納されているか
                if (dict.ContainsKey(sale.ShopName))
                {
                    dict[sale.ShopName] += sale.Amount;
                }
                //格納されていない場合
                else
                {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }
    }


}
