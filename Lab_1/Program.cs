using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Register<ILogger, Logger>(Reuse.Singleton);
            container.Register<IDatabase, Database>(Reuse.Transient);

            IDatabase database = container.Resolve<IDatabase>();
            database.Execute("Hello, world :)");
        }
    }
}
