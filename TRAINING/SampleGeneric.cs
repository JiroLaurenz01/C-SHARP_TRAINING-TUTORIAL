using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
    public  class SampleGeneric<T>
        where T: TagaCompute, new() //CLASS, NEW()
    {
        public void Process(int num1, int num2)
        {
            T t = new T();
            t.Compute(num1, num2);
            Console.WriteLine($"COMPUTE: {t.Result}");
        }
    }

    public class SampleMultipleType<Una, Pangalawa>
        where Una: TagaCompute, new()
        where Pangalawa: SampleGeneric<TagaMinus>, new()
    {
        public void Executed(int num1, int num2)
        {
            Una una = new Una();
            Pangalawa pangalawa = new Pangalawa();

            una.Compute(num1, num2);
            Console.WriteLine($"UNA: {una.Result}");

            pangalawa.Process(num1, num2);
        }
    }
}
