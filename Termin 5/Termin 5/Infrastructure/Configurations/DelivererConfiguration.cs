using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_5.Models;

namespace Termin_5.Infrastructure.Configurations
{
    public class DelivererConfiguration : IEntityTypeConfiguration<Deliverer>
    {
        public void Configure(EntityTypeBuilder<Deliverer> builder)
        {
            builder.HasKey(x => x.Id); //Podesavam primarni kljuc tabele

            builder.Property(x => x.Id).ValueGeneratedOnAdd(); //Kazem da ce se primarni kljuc
                                                               //automatski generisati prilikom dodavanja,
                                                               //redom 1 2 3...

            builder.HasIndex(x => x.Username).IsUnique();//Kazem da je username korisnika
                                                         //jedinstven podatak (ne smeju biti 2 ista)

            builder.HasIndex(x => x.Email).IsUnique();//Kazem da je email korisnika
                                                      //jedinstven podatak (ne smeju biti 2 ista)
        }
    }
}
