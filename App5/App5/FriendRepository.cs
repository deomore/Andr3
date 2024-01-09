using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace App5
{
    public class FriendRepository
    {
        SQLiteConnection database;
        public FriendRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Friend>();
            database.CreateTable<Bros>();
        }
        public IEnumerable<Friend> GetItems()
        {
            return database.Table<Friend>().ToList();
        }
        public Friend GetItem(int id)
        {
            return database.Get<Friend>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Friend>(id);
        }

        public IEnumerable<Bros> GetBros()
        {
            return database.Table<Bros>().ToList();
        }
        public Bros GetBro(int id)
        {
            return database.Get<Bros>(id);
        }
        public int DelBro (int id)
        {
            return database.Delete<Bros>(id);
        }
        public int SaveItem(Friend item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }

        public int SaveBro(Bros item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}