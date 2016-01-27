using Raven.Client;
using Raven.Client.Embedded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectDB
    {
        public static IDocumentStore createstore()
        {
            // Raven.Database.Server.NonAdminHttp.EnsureCanListenToWhenInNonAdminContext(8080);
            IDocumentStore docStore = new EmbeddableDocumentStore
            {
               // ConnectionStringName = "RavenDB",
                DefaultDatabase = "GridView",
                Url = "http://localhost:8080/",
               // UseEmbeddedHttpServer = true,
            }.Initialize();
            //docStore.Initialize();
            return docStore;
            
        }
    }
}
