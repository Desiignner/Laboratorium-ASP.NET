namespace Laboratorium3.Models
{
    public class MemoryComputerServices : IComputerService
    {
        private readonly Dictionary<int, Computer> _computers= new Dictionary<int, Computer>()
        {

            {1, new Computer() {Id=1,Nazwa="Domowy",Procesor="Intel Core i5-12400F",Memory=8,Karta_Graficzna="Brak",Producent="MSI",Data_Produkcji = new DateTime(2021,10,20)}},
            {2, new Computer() {Id=1,Nazwa="Gamingowy",Procesor="INTEL Core i9-13900KF",Memory=32,Karta_Graficzna="MSI GeForce RTX 4060 Gaming X 8GB ",Producent="Asus",Data_Produkcji = new DateTime(2023,11,23)}},




        };
        private int _id = 3;
        public void Add(Computer computer)
        {
            computer.Id = _id++;
            _computers[computer.Id] = computer;
        }

        public void DeleteById(Computer computer)
        {
            _computers.Remove(computer.Id);
        }

        public List<Computer> FindAll()
        {
            return _computers.Values.OrderBy(computer => computer.Procesor).ToList();
        }

        public Computer? FindById(int id)
        {
            return _computers[id];
        }

        public void Update(Computer computer)
        {
            _computers[computer.Id] = computer;
        }
    }
}

