using System;
using System.Collections.Generic;
using System.Text;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;



namespace covid_project
{
    static class Persistance
    {
        static private MongoClient client;
        static public IMongoCollection<Person> personCollection;

        static Persistance()
        {
            //https://stackoverflow.com/questions/11557912/element-id-does-not-match-any-field-or-property-of-class
            var conventionPack = new ConventionPack { new IgnoreExtraElementsConvention(true) };
            ConventionRegistry.Register("IgnoreExtraElements", conventionPack, type => true);

            client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("covidProject");
            personCollection = database.GetCollection<Person>("person");
        }


        static public string FindAll()
        {
            var persons = personCollection.AsQueryable<Person>().ToList();
            return persons[0].personName;
        }
    }
}
