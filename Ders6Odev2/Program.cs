using System;

namespace Ders6Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select Products.ProductName ÜrünAdi, Sum([Order Details].UnitPrice * [Order Details].Quantity) KazanilanToplamMiktar from (Products left join [Order Details] on Products.ProductID=[Order Details].ProductID) left join Orders on [Order Details].OrderID=Orders.OrderID group by Products.ProductName order by Products.ProductName asc

            
            /* Select p.ProductName as 'Ürün Adı', SUM(od.UnitPrice*od.Quantity) as  'Kazanılan Toplam Miktar'
            From Products p
            inner join[Order Details] od
            on p.ProductID = od.ProductID
            inner join Orders o
            on od.OrderID = o.OrderID
            group by p.ProductName */
        }
    }
}
