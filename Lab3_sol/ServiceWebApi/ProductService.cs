using Lab3_sol.Models;
using System.Net.Http.Json;

namespace Lab3_sol.ServiceWebApi
{
    public class ProductService : Iservice<Product>
    {
        HttpClient client;
       public ProductService(HttpClient httpClient )
        {
            client = httpClient;    
        }
        
        public async Task Add(Product item)
        {
            await client.PostAsJsonAsync<Product>("/api/Products", item);
        }

        public async Task Delete(int id)
        {
            await client.DeleteAsync($"/api/Products/{id}");
        }

        public async Task<List<Product>> GetAll()
        {
            return await client.GetFromJsonAsync<List<Product>>("/api/Products");
        }

        public async Task<Product> Getbyid(int id)
        {
            return await client.GetFromJsonAsync<Product>($"/api/Products/{id}");
        }

        public async Task Update(int id, Product item)
        {
            await client.PutAsJsonAsync<Product>($"/api/Products/{id}", item);
        }
    }
}
