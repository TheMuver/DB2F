using System.Collections.Generic;

namespace DB2FLib
{
    public class DocxTransmitter : IWritable
    {
        public string Path { get { return path; } }
        public Dictionary<string,string> Tags {get;set;}

        private string path;

        public DocxTransmitter(string samplePath)
        {
            this.path = samplePath;
        }

        public void BuildRequest()
        {
            
        }

        public void CreateDocument()
        {

        }
    }
}