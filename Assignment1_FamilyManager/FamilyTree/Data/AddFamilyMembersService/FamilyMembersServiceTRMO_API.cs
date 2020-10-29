using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace LoginExample.Data.AddFamilyMembersService
{
    public class FamilyMembersServiceTRMO_API : IAddFamilyMembersService
    {
        private string uri = "http://localhost:5003/";
        private readonly HttpClient client;

        public FamilyMembersServiceTRMO_API()
        {
            client = new HttpClient();
        }

        public async Task AddAdultAsync(Adult adult)
        {
            string todoSerialized = JsonSerializer.Serialize(adult);
            StringContent content=new StringContent(todoSerialized,Encoding.UTF8,"application/json");

            HttpResponseMessage responseMessage =
                await client.PutAsync(uri, content);
            Console.WriteLine(responseMessage.ToString());
        }

        public async Task<IList<Adult>> GetListOfAdultsAsync()
        {
            string message = await client.GetStringAsync(uri+"/adults");
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public Task AddChild(Child child)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Child>> GetListOfChildren()
        {
            throw new NotImplementedException();
        }

        public Task AddPet(Pet addPet)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Pet>> GetListOfPets()
        {
            throw new NotImplementedException();
        }

        public Task AddFamily(Family family)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Family>> GetListOfFamilies()
        {
            throw new NotImplementedException();
        }
    }
}