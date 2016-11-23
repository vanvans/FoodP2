using Microsoft.WindowsAzure.MobileServices;
using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Moodify
{
    class AzureManager
    {
        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<Fakedata> fakedataTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://giraffes.azurewebsites.net");
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
