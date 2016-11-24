using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fab.DataModels;
using Microsoft.WindowsAzure.MobileServices;

namespace fab
{
    public class AzureManager
    {
        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<Fakedata> fakedataTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://www.giraffes.azurewebsites.net");
            this.fakedataTable = this.client.GetTable<Fakedata>();
        }


        public MobileServiceClient AzureClient
        {
            get { return client; }
        }


        public static AzureManager AzureManagerInstance
        {

            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }
                return instance;
            }
        }

        public async Task AddFakedata(Fakedata fakedata)
        {
            await this.fakedataTable.InsertAsync(fakedata);
        }


        public async Task<List<Fakedata>> GetFakedatas()
        {
            return await this.fakedataTable.ToListAsync();
        }


    }
}
