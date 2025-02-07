using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string messge) : base(messge)
        {
                
        }

        public NotFoundException(string name, object key) : base($"Entity \"{name}\" ({key}) was not found.")
        {
                
        }

    }
}
