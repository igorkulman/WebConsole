using System;
using System.Collections.Generic;
using System.Linq;

namespace WebConsole.Scripting.Repositories
{
    public class DataRepository
    {
        public List<string> GetAll()
        {
            return Enumerable.Range(0, 10).Select(l => String.Format("Fake data {0}", l)).ToList();
        } 
    }
}
