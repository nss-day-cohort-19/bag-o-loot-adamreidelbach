using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class SantaHelper
    {
        private string _connectionString = $"Data Source={Environment.GetEnvironmentVariable("BAGOLOOT_DB")}";
        private SqliteConnection _connection;
        private List<Toys> _toys = new List<Toys>();
        public SantaHelper()
        {
            _connection = new SqliteConnection(_connectionString);
        }
        public int AddToyToBag(int childId, string toyName)
        {
            int _lastId = 0; // Will store the id of the last inserted record
            using (_connection)
            {
                _connection.Open ();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = ($"insert into ToyBag values (null, '{toyName}', {childId})");
                Console.WriteLine(dbcmd.CommandText);
                dbcmd.ExecuteNonQuery();

                // Get the id of the new row
                dbcmd.CommandText = $"select last_insert_rowid()";
                using (SqliteDataReader dr = dbcmd.ExecuteReader()) 
                {
                    if (dr.Read()) {
                        _lastId = dr.GetInt32(0);
                    } else {
                        throw new Exception("Unable to insert value");
                    }
                }

                // clean up
                dbcmd.Dispose ();
                _connection.Close ();
            }

            return _lastId;
        }

        public void RemoveToyFromBag (int toyId)
        {
            // int _lastId = 0; // Will store the id of the last inserted record
            using (_connection)
            {
                _connection.Open ();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = ($"Delete from ToyBag where toyId={toyId};");
                Console.WriteLine(dbcmd.CommandText);
                dbcmd.ExecuteNonQuery();

                // // Get the id of the new row
                // dbcmd.CommandText = $"select last_insert_rowid()";
                // using (SqliteDataReader dr = dbcmd.ExecuteReader()) 
                // {
                //     if (dr.Read()) {
                //         _lastId = dr.GetInt32(0);
                //     } else {
                //         throw new Exception("Unable to insert value");
                //     }
                // }

                // clean up
                dbcmd.Dispose ();
                _connection.Close ();
            }

            // return _lastId;
        }

        public List<int> GetChildrenWithToys()
        {
            return new List<int>() { 1, 2, 3, 4, 6 };
        }

        public List<Toys> GetChildsToys(int childId)
        {
            using (_connection)
            {
                _connection.Open ();
                SqliteCommand dbcmd = _connection.CreateCommand();

                dbcmd.CommandText = ($"select toyId, name, childId from ToyBag where childId = {childId};");
                // Console.WriteLine(dbcmd.CommandText);
                // dbcmd.ExecuteNonQuery();

                using (SqliteDataReader dr = dbcmd.ExecuteReader())
                {
                    //Read each row in the resultset
                    while (dr.Read())
                    {
                        _toys.Add( new Toys(dr.GetInt32(0), dr[1].ToString(), dr.GetInt32(2)) );
                    }
                }

                // clean up
                dbcmd.Dispose ();
                _connection.Close ();
            }

            return _toys;
        }

        public bool ToyIsDelivered (int childId)
        {
            return true;
        }
    }
}