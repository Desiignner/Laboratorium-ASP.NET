using Data;
using Data.Entities;
using Laboratorium3.Mappers;
using Laboratorium3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorium3.Models
{
    public class EFComputerService : IComputerService
    {
        private AppDbContext _context;

        public EFComputerService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Computer computer)
        {
            var entity = ComputerMapper.ToEntity(computer);
            _context.Computer.Add(entity);
            _context.SaveChanges();
            //return entity.ComputerId;
        }

        public void DeleteById(Computer computer)
        {
            ComputerEntity? find = _context.Computer.Find(computer.Id);
            if (find != null)
            {
                _context.Computer.Remove(find);
                _context.SaveChanges();
            }
        }


        public List<Computer> FindAll()
        {
            return _context.Computer.Select(e => ComputerMapper.FromEntity(e)).ToList(); ;
        }

        public Computer? FindById(int id)
        {
            return ComputerMapper.FromEntity(_context.Computer.Find(id));
        }

        public void Update(Computer computer)
        {
            _context.Computer.Update(ComputerMapper.ToEntity(computer));
        }
    }
}