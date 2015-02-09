﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


namespace ServerClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServerClientService : IServerClientService
    {
        public string GetHostName()
        {
            return Environment.MachineName;
        }

        public HorusShared.ComputerObjects.Computer GetComputer()
        {
            HorusShared.ComputerObjects.Computer ThisComputer = new HorusShared.ComputerObjects.Computer();
            return ThisComputer;
        }

        public void HandShake(string hostName)
        {
            try
            {
                var connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("horus");
                var collection = database.GetCollection<Client>("Clients");

                //See if client already exists
                var query = Query.EQ("name", hostName);
                var fields = Fields.Include("_id");
                var res = collection.Find(query).SetFields(fields).SetLimit(1).FirstOrDefault();
                if (res == null)
                {
                    //New Client
                    var thisClient = new Client { name = hostName };
                    collection.Insert(thisClient);
                    Console.WriteLine("New Client: " + hostName + " Connected");
                }
                else
                {
                    Console.WriteLine(hostName + " Connected");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public class Client
        {
            public ObjectId Id { get; set; }
            public string name { get; set; }
        }
    }
}
