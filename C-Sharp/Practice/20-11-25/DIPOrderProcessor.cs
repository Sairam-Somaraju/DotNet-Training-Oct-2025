using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_25
{
    internal class DIPOrderProcessor
    {
        private readonly DIPInterface _database;

        public DIPOrderProcessor(DIPInterface database)
        {
            _database = database;
        }

        public void Process()
        {
            _database.Save();
        }

    }
}
