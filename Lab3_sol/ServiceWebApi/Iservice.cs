namespace Lab3_sol.ServiceWebApi
{
    public interface Iservice<T>
    {
       Task <T> Getbyid(int id);
       Task< List<T>> GetAll();

        Task Add(T item);
        Task Update(int id,T item);
        Task Delete(int id);    


    }
}
