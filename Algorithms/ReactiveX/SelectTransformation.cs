using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace Algorithms.ReactiveX
{
    public class SelectTransformation
    {
        public void Run()
        {
            var numberPerSecond = Observable.Interval(TimeSpan.FromSeconds(1)).TakeWhile(e => e < 10).Select(e => (int) e);
            
           var abc= Observable.Start(() =>
            {
                Task.Delay(1000);
                return 10;
            });

           Observable.CombineLatest(numberPerSecond, abc).Subscribe(e =>
           {
               foreach (var i in e)
               {
                   Console.WriteLine(i);
               }
           });

        }
    }
}
