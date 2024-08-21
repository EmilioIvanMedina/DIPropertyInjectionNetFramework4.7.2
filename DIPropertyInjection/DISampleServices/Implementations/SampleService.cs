using DISampleServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISampleServices.Implementations
{
    public class SampleService : ISampleService
    {
        public int GetNumber()
        {
            return 190;
        }
    }
}
