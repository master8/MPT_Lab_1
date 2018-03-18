using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Database : IDatabase
    {
        private ILogger logger;

        public Database(ILogger logger)
        {
            this.logger = logger;
        }

        public void Execute(string query)
        {
            logger.Log(query);
        }
    }
}
