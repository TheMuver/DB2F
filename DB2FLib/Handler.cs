using System.Xml.Serialization;
using System;
using Xceed.Words.NET;
using Xceed.Document.NET;
using AirtableApiClient;

namespace DB2FLib
{
    public class DB2FHandler
    {
            
    }

    public interface IReadable //Интерфейс для классов, работающих с базами данных
    {
        void ReadData();
    }

    public interface IWritable
    {
        void BuildRequest();
        void CreateDocument();
    }
}
