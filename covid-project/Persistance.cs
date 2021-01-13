﻿using System;
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
    public static class Persistance
    {
        static private MongoClient client;
        static IMongoCollection<Person> personCollection;

        static Persistance()
        {
            //https://stackoverflow.com/questions/11557912/element-id-does-not-match-any-field-or-property-of-class
            var conventionPack = new ConventionPack { new IgnoreExtraElementsConvention(true) };
            ConventionRegistry.Register("IgnoreExtraElements", conventionPack, type => true);

            client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("covidProject");
            personCollection = database.GetCollection<Person>("person");
        }

        public static List<Person> FindAll()
        {
            var persons = personCollection.AsQueryable<Person>().ToList();
            return persons;
        }

        public static List<Person> FindNonAffected()
        {
            var persons = personCollection.AsQueryable<Person>().ToList();
            List<Person> newList = new List<Person>();

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].colorCode == "green")
                {
                    newList.Add(persons[i]);
                }
            }
            return newList;
        }
        public static List<Person> FindSuspected()
        {
            var persons = personCollection.AsQueryable<Person>().ToList();
            List<Person> newList = new List<Person>();

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].colorCode == "orange")
                {
                    newList.Add(persons[i]);
                }
            }
            return newList;
        }
        public static List<Person> FindAffected()
        {
            var persons = personCollection.AsQueryable<Person>().ToList();
            List<Person> newList = new List<Person>();

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].colorCode == "red")
                {
                    newList.Add(persons[i]);
                }
            }
            return newList;
        }

        public static void InsertPerson(Person newperson)
        {
            personCollection.InsertOne(newperson);
        }

        //public static void TestAPerson(Person person)
        //{
        //    person.personTestResult
        //}
    }
}
