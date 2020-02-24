using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Linq;
using  System.Reactive;
using System.Threading.Tasks;

namespace Grapoh.ReactiveX
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
