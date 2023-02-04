using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StackAndQueues
{
    //Here the stack will never be full
    public class DynamicCustomStackImplementation : CustomStackImplemention
    {
        public DynamicCustomStackImplementation(): base()
        {
            
        }
        public DynamicCustomStackImplementation(int size) : base(size)
        {

        }

        public override Boolean push(int item)
        {
            if (base.IsFull())
            {
                int[] temp = new int[data.Length * 2];
                Array.Copy(data, 0, temp, 0, data.Length);

                data = temp;
            }

            base.push(item);
            return true;
        }
    }
}
