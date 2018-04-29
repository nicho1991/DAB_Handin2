using System;
using System.Threading.Tasks;
using DAB2._2.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentDb.Repository.Infrastructure;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace DAB2._2
{
    public class DBContext
    {

        public DocumentCollection PersonCollection { get; set; }

        #region Private essentials

        private const string EndpointUrl = "https://lol.documents.azure.com:443/";
        private const string PrimaryKey = "M7QX96diMd8SpUebjuc3241WYeYALz6eDonOQslpDFznhhQDxMSpfIMf2L8EC4VEAYAlnWM8Fc8FVxQ4S4mvzw==";
        private const string DatabaseName = "DAB2.2DocumentDB";
        private const string CollectionName = "PersonCollection";

        private PersonRepository _personRepository;

        public DocumentCollection Persons { get; set; }
        public DocumentClient client { get; set; }

        #endregion

        #region SetupOfDB
        public DBContext()
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

        }
        private async Task LoadDB()
        {
            client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);

            await this.client.CreateDatabaseIfNotExistsAsync(new Database { Id = DatabaseName });
            PersonCollection = await client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri(DatabaseName),
            new DocumentCollection { Id = CollectionName });
        }
        #endregion
    }
}