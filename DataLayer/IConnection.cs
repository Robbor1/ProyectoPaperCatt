using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IConnection
    {
        public abstract DataTable getAll();
        public abstract DataTable filter(string name);

        public abstract void processRow(Dictionary<string, object> rowData);
    }
}
