using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class InitializationLogic
    {
        public static void Initialize()
        {
            Seed.SeedData();
        }
    }
}
