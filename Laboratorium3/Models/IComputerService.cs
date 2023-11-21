namespace Laboratorium3.Models
{
    public interface IComputerService
    {
        void Add(Computer computer);
        void Update(Computer computer);
        void DeleteById(Computer computer);
        Computer? FindById(int id);
        List<Computer> FindAll();
    }
}
