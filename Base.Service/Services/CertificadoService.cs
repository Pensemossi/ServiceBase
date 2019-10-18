﻿using Base.Data.Infrastructure;
using Base.Data.Repositories;
using Base.Model.Dtos;
using Base.Model.Models;
using Base.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Service.Services
{
   
    public class CertificadoService : EntityService<Certificado>, ICertificadoService
    {
        public CertificadoService(IUnitOfWork unitOfWork, ICertificadoRepository repository) : base(unitOfWork, repository)
        {

        }

      

    }

    public interface ICertificadoService : IEntityService<Certificado>
    {

       
    }
}
