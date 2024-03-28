﻿using AutoMapper;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Repos
{
    [AutoBind]
    public class VaccinesRepository : BaseRepository<Vaccine, VaccineDto>, IVaccineRepository
    {
        public VaccinesRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
