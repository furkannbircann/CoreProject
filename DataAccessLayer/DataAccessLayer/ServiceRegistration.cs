﻿using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddDbContext<CoreDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
