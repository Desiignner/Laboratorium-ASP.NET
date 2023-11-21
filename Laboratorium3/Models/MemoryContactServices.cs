namespace Laboratorium3.Models
{
    public class MemoryContactServices : IContactService
    {
        private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
            {1,new Contact() {Id=1,Name="Ewa",Email="test@test.pl",Phone="16543215" } },
            {2,new Contact() {Id=2,Name="Mariusz",Email="test2@test.pl",Phone="564546218" } },
        };
        private int _id=3;
        public void Add(Contact contact)
        {
            contact.Id= _id++;
            _contacts[contact.Id] = contact;
        }

        public void DeleteById(Contact contact)
        {
            _contacts.Remove(contact.Id);
        }

        public List<Contact> FindAll()
        {
            return _contacts.Values.ToList();
        }

        public Contact? FindById(int id)
        {
            return _contacts[id];
        }

        public void Update(Contact contact)
        {
            _contacts[contact.Id] = contact;
        }
    }
}
