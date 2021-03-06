﻿using System;

namespace MvvmLight.Model
{
    public class DataService : IDataService
    {
        public void GetItems(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service
            for (int i = 0; i < 10; i++)
            {
                var item = new DataItem() { ID = i, Name = String.Format("Item_{0}", i) };
                callback(item, null);
            };
        }
        public void GetClients(Action<Client, Exception> callback)
        {
            // Use this to connect to the actual data service
            for (int i = 0; i < 10; i++)
            {
                var item = new Client() { ID = i, FirstName = String.Format("Man_{0}", i) };
                callback(item, null);
            };
        }
    }
}