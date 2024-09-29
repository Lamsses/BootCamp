using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public interface IDatabase
    {
        void SaveData(string data);
    }

    public class RealDatabase : IDatabase
    {
        public void SaveData(string data)
        {
            // Real database save logic
        }
    }

    public class MockDatabase : IDatabase
    {
        public void SaveData(string data)
        {
            throw new NotImplementedException();
        }
    }

    public class DataService
    {
        private readonly IDatabase _database;

        public DataService(IDatabase database)
        {
            _database = database;
        }


        public void Save(string data)
        {
            _database.SaveData(data);
        }
    }

}
