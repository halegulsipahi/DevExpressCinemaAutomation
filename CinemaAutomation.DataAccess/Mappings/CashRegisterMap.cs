using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.DataAccess.Mappings
{
    public class CashRegisterMap : EntityTypeConfiguration<CashRegister>
    {
        public CashRegisterMap()
        {
            ToTable("CashRegisters");
            HasKey(cr  => cr.Id);
            Property(cr => cr.Amount).HasColumnType("money").IsRequired();
            Property(cr => cr.Description).HasMaxLength(200);
            Property(cr => cr.TransactionDate).HasColumnType("datetime").IsRequired();
           
        }
    
    }
}
