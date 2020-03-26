using System.Threading.Tasks;
using System.Threading;
using System;
using TinyId.IdService;
namespace TinyId.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyService=new KeyService();
            Parallel.For(1,100,i=>{
               var result=  keyService.GetKeyResult(1);
               System.Console.WriteLine($"p1:index:{i} result[ startid:{result.maxid} step:{result.setp} delta:{result.delta}  ]");
            });
             Parallel.For(1,200,i=>{
               var result=  keyService.GetKeyResult(2);
               System.Console.WriteLine($"p2:index:{i} result[ startid:{result.maxid} step:{result.setp} delta:{result.delta}  ]");
            });

        }
    }
}
