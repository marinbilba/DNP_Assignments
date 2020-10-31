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
        private string uri = " https://localhost:5003/";
        private readonly HttpClient client;

        public FamilyMembersServiceTRMO_API()
        {
            client = new HttpClient();
        }
        /**
         * Use this to add an Adult. Provide the Child as json in the request body. The created Adult is returned.
         * May return 400 Bad Request, if the Child is not valid.
         * May return 500 Internal Server Error, if the request failed.
         */
        public async Task AddAdultAsync(Adult adult)
        {
            string adultSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(adultSerialized, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await client.PutAsync(uri + "/adults", content);
            Console.WriteLine(responseMessage.ToString());
        }
        /**
        * Use this to get a collection of Adults.
        * This request takes an option number of the following request parameters(check API doc)
        */
        public async Task<IList<Adult>> GetListOfAdultsAsync()
        {
            string message = await client.GetStringAsync(uri + "/Adults");
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }
        
        /**
         * Use this to add a Child. Provide the Child as json in the request body. The created Child is returned.
         * May return 400 Bad Request, if the Child is not valid.
         * May return 500 Internal Server Error, if the request failed.
         */
        public async Task AddChild(Child child)
        {
            string childSerialized = JsonSerializer.Serialize(child);
            StringContent content = new StringContent(childSerialized, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await client.PutAsync(uri + "/Children", content);
            Console.WriteLine(responseMessage.ToString());
        }

       /**
        * Use this to get a collection of Children.
        * This request takes an option number of the following request parameters(check API doc)
        */
        public async Task<IList<Child>> GetListOfChildren()
        {
            string message = await client.GetStringAsync(uri + "/Children");
            List<Child> result = JsonSerializer.Deserialize<List<Child>>(message);
            return result;
        }

       /**
         * Use this to add a Pet. Provide the Child as json in the request body. The created Pet is returned.
         * May return 400 Bad Request, if the Child is not valid.
         * May return 500 Internal Server Error, if the request failed.
         */
        public async Task AddPet(Pet addPet)
        {
            string petSerialized = JsonSerializer.Serialize(addPet);
            StringContent content = new StringContent(petSerialized, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await client.PutAsync(uri + "/Pets", content);
            Console.WriteLine(responseMessage.ToString());
        }
       /**
        * Use this to get a collection of Pets.
        * This request takes an option number of the following request parameters(check API doc)
        */
        public async Task<IList<Pet>> GetListOfPets()
        {
            string message = await client.GetStringAsync(uri + "/Pets");
            List<Pet> result = JsonSerializer.Deserialize<List<Pet>>(message);
            return result;
        }
       /**
         * Use this to add a Family. Provide the Family as json in the request body. The created Family is returned.
         * May return 400 Bad Request, if the Child is not valid.
         * May return 500 Internal Server Error, if the request failed.
         */
        public async Task AddFamily(Family family)
        {
            string petSerialized = JsonSerializer.Serialize(family);
            StringContent content = new StringContent(petSerialized, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage =
                await client.PutAsync(uri + "/Families", content);
            Console.WriteLine(responseMessage.ToString());
        }
       /**
        * Use this to get a collection of Families.
        * This request takes an option number of the following request parameters(check API doc)
        */
        public async Task<IList<Family>> GetListOfFamilies()
        {
            string message = await client.GetStringAsync(uri + "/Families");
            List<Family> result = JsonSerializer.Deserialize<List<Family>>(message);
            return result;
        }
    }
}