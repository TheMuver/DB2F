using System;

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
