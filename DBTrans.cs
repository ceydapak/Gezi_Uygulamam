using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Gezi_Uygulamam
{
    public class DBTrans
    {
        public string path;
        private SQLiteConnection con;

        public DBTrans(string _dbpath)
        {
            path = _dbpath;
        }
        public void Init()
        {
            con = new SQLiteConnection(path);
            con.CreateTable<Trip>();


        }

        public List<Trip> GetTrips()
        {
            Init();
            return con.Table<Trip>().ToList();

        }

        public void InsertTrip(Trip trip)
        {
            Init();
            con = new SQLiteConnection(path);
            con.Insert(trip);

        }

        public  List<Trip> GetResults(string filterText)
        {;
            var search = con.Table<Trip>().Where(x=> x.Title.StartsWith(filterText)).ToList();
            return search;
        }
   


    }
}
