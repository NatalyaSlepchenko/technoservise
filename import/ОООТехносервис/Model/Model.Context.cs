﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ОООТехносервис.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Db_Slepchenko_connection : DbContext
    {
        public Db_Slepchenko_connection()
            : base("name=Db_Slepchenko_connection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Defect> Defect { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Priory> Priory { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Role_Slepchenko> Role_Slepchenko { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<View_1> View_1 { get; set; }
        public virtual DbSet<View_2> View_2 { get; set; }
        public virtual DbSet<View_3> View_3 { get; set; }
    
        public virtual ObjectResult<Get_Request_Master_ID_Result> Get_Request_Master_ID(Nullable<int> master_ID)
        {
            var master_IDParameter = master_ID.HasValue ?
                new ObjectParameter("Master_ID", master_ID) :
                new ObjectParameter("Master_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Request_Master_ID_Result>("Get_Request_Master_ID", master_IDParameter);
        }
    }
}
