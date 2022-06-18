using System.Net.Http.Json;
using Lab3_sol.Models;

namespace Lab3_sol.ServiceWebApi
{
    public class CategoryService : Iservice<Category>
    {
        HttpClient client;
        public CategoryService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task  Add(Category item)
        {
            await client.PostAsJsonAsync<Category>("/api/Categories", item);
        }

        public async  Task Delete(int id)
        {
            await client.DeleteAsync($"/api/Categories/{id}");
        }

        public async Task<List<Category>> GetAll()
        {
            return await client.GetFromJsonAsync<List<Category>>("/api/Categories");
        }

        public async Task<Category> Getbyid(int id)
        {
            return await client.GetFromJsonAsync<Category>($"/api/Categories/{id}");
        }

        public async Task Update(int id, Category item)
        {
            await client.PutAsJsonAsync<Category>($"/api/Employees/{id}", item); 
        }
    }
}
