using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Threading.Tasks;

namespace DAB2._2.UnitOfWork
{
    public class DocumentDBUnitOfWork
    {
        private DocumentClient client;
        private const string EndpointUrl = "https://localhost:8081";
        private const string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        public DocumentDBUnitOfWork()
        {
            try
            {
                LoadDB().Wait();
            }
            catch (DocumentClientException de)
            {
                Exception baseException = de.GetBaseException();
                Console.WriteLine("{0} error occurred: {1}, Message: {2}", de.StatusCode, de.Message, baseException.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Husk at starte emulator op!");
                Exception baseException = e.GetBaseException();
                Console.WriteLine("Error: {0}, Message: {1}", e.Message, baseException.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
                Console.ReadKey();
            }
        }

        private async Task LoadDB()
        {
            //point client to Database service
            this.client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
            //Create Database FamilyDB
            await this.client.CreateDatabaseIfNotExistsAsync(new Database { Id = "DAB2.2DocumentDB" });
            //create collection FamilyCollection on FamilyDB
            await this.client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri("DAB2.2DocumentDB"), new DocumentCollection { Id = "PersonCollection" });

        }

    }
}

