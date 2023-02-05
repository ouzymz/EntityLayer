using EntityLayer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    internal class ArtistMapping : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artists"); // Table name will be Users in the database

            builder.HasKey(x => x.Id); // Set as Primary Key

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1); // Identity property was gained to the primary key. Column order was set.

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("nvarchar")
                .HasColumnOrder(2); // AlbumName Name is Required, max length can be 40 characters and data type will be nvarchar in the database

            builder.Property(x => x.CreatedDate).HasColumnType("datetime2").HasDefaultValueSql("GetDate()").HasColumnOrder(3);
        }

    }

}
