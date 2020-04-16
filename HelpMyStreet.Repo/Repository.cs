using AutoMapper;
using HelpMyStreet.Core.Dto;
using HelpMyStreet.Core.Interfaces.Repositories;
using HelpMyStreet.Repo.EntityFramework.Entities;
using System;
using System.Threading.Tasks;

namespace HelpMyStreet.Repo
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        private Mapper _mapper;

        public Repository(ApplicationDbContext context, Mapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddAddress(AddressDetailsDTO addressDetailsDTO)
        {
            var param = _mapper.Map<AddressDetails>(addressDetailsDTO);
            _context.Add(param);
            await _context.SaveChangesAsync();
        }

        public async Task AddPostCode(PostCodeDTO postCodeDTO)
        {
            var param = _mapper.Map<PostCode>(postCodeDTO);
            _context.Add(param);
            await _context.SaveChangesAsync();
        }
    }
}
