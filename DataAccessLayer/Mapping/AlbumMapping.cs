using EntityLayer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace DataAccessLayer.Mapping
{
    internal class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Albums"); // Table name will be Users in the database

            builder.HasKey(x => x.Id); // Set as Primary Key

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .HasColumnOrder(1); // Identity property was gained to the primary key. Column order was set.

            builder.Property(x => x.AlbumName)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("nvarchar")
                .HasColumnOrder(2); // AlbumName Name is Required, max length can be 40 characters and data type will be nvarchar in the database


            builder.Property(x => x.ReleaseDate)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnOrder(3); // Data type will be date, which means 'dd/mm/yyyy' in the database

            builder.Property(x => x.Price)
                .HasColumnType("decimal")
                .HasColumnOrder(4); // Data type will be decimal


            builder.Property(x => x.IsDiscounted)
                .HasColumnType("boolean")
                .HasColumnOrder(5);

            builder.Property(x => x.DiscountAmount)
                .HasColumnType("smallint")
                .HasColumnOrder(6);

            builder.Property(x => x.IsOnSale)
                .HasColumnType("boolean")
                .HasColumnOrder(7);
            builder.Property(x=>x.CreatedDate).HasColumnType("datetime2").HasDefaultValueSql("GetDate()").HasColumnOrder(8);
        }
    }
}
