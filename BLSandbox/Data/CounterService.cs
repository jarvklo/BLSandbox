using System;
using System.Linq;
using System.Threading.Tasks;

namespace BLSandbox.Data
{
public class CounterService
    {
        public CounterService()
        {
            this.Id = System.Guid.NewGuid().ToString();
            CounterValue = 0;
        }
        public string Id { get; set; }
        public int CounterValue { get; set; }
    }
}
