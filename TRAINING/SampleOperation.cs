using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
    public class SampleOperation
    {
        public void Process()
        {
            TagaCompute add = new TagaAdd();
            add.Compute(1, 2);
            Console.WriteLine($"ADD: {add.Result}");

            var addWithTen = new TagaAddWithTen();
            TagaCompute tagaCompute = addWithTen;
            tagaCompute.Compute(1, 2);
            Console.WriteLine($"ADD: {tagaCompute.Result}");
        }
    }

    public class TagaAdd: TagaCompute {}
    public class TagaMinus: TagaCompute 
    {
        public override void Compute(int num1, int num2)
        {
            _result = num1 - num2;
        }
    }
    public class TagaMultiply : TagaCompute
    {
        public override void Compute(int num1, int num2)
        {
            _result = num1 * num2;
        }
    }
    public class TagaDivide : TagaCompute
    {
        public override void Compute(int num1, int num2)
        {
            _result = num1 / num2;
        }
    }
    public class TagaAddWithTen : TagaCompute
    {
        public override void Compute(int num1, int num2)
        {
            num1 += 10;
            num2 += 10;
            base.Compute(num1, num2);
        }
    }
}
