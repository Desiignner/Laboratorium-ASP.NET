using Laboratorium3.Models;
using Data.Entities;


namespace Laboratorium3.Mappers
{
    public class ComputerMapper
    {
        public static Computer FromEntity(ComputerEntity entity)
        {
            return new Computer()
            {
<<<<<<< HEAD
=======
                Id = entity.ComputerId,
                Nazwa = entity.Nazwa,
                Procesor = entity.Procesor,
                Memory = entity.Memory,
                Karta_Graficzna = entity.Karta_Graficzna,
                Producent = entity.Producent,
                Data_Produkcji = entity.Data_Produkcji,
                Priority = (Priority)entity.Priority,
>>>>>>> DB working

            };
        }

<<<<<<< HEAD
        public static ComputerEntity ToEntity(Contact model)
        {
            return new ComputerEntity()
            {
=======
        public static ComputerEntity ToEntity(Computer model)
        {
            return new ComputerEntity()
            {
                ComputerId = model.Id,
                Nazwa = model.Nazwa,
                Procesor = model.Procesor,
                Memory = model.Memory,
                Karta_Graficzna = model.Karta_Graficzna,
                Producent = model.Producent,
                Data_Produkcji = model.Data_Produkcji,
                Priority = Convert.ToInt32(model.Priority),

>>>>>>> DB working

            };
        }
    }
}
