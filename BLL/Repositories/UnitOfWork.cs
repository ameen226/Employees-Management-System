﻿using BLL.Interfaces;
using DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly MvcAppDbContext _dbContext;
        public IEmployeeRepository EmployeeRepository { get; set; }

        public IDepartmentRepository DepartmentRepository { get; set; }

        public UnitOfWork(MvcAppDbContext dbContext)
        {
            _dbContext = dbContext;
            EmployeeRepository = new EmployeeRepository(dbContext);
            DepartmentRepository = new DepartmentRepository(dbContext);
        }


        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
