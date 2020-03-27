﻿using AutoMapper;
using HelpMyStreet.Core.Dto;
using HelpMyStreet.Core.Interfaces.Repositories;
using HelpMyStreet.Repo.EntityFramework.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMyStreet.Repo
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public Repository(ApplicationDbContext context, IMapper mapper)
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
            try
            {
                var param = _mapper.Map<PostCode>(postCodeDTO);
                _context.Add(param);
                await _context.SaveChangesAsync(); 
            }
            catch(Exception exc)
            {
                string a = exc.ToString();
            }
            
        }
    }
}
