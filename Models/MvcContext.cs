using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Models.MvcContext
{
    public class MvcContext: DbContext{
        public MvcContext(DbContextOptions<MvcContext> options) : base(options){

        }

        public DbSet<pangu.Models.Cita> Cita{get; set;}

         

    }


}
