using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NoteCode.Model.Entities;

namespace NoteCode.Model.Context
{
    class NoteCodeDbContext : DbContext
    {
        public virtual DbSet<Ders> Dersler { get; set; }
        public virtual DbSet<Konu> Konular { get; set; }
        public virtual DbSet<AltKonu> AltKonular { get; set; }

    }
}
