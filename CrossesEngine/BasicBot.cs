using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossesEngine
{
    public abstract class BasicBot
    {
        public TextWriter StandardInput { get; protected set; }
        public TextReader StandardOutput { get; protected set; }
        public TextReader StandardError { get; protected set; }

        public int ID { get; set; }
        public string Name { get; protected set; }

        public abstract void Shutdown();
    }
}
