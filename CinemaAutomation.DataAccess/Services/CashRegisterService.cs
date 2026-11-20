using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.DataAccess.Services
{
    public class CashRegisterService
    {
            private readonly CinemaEFContext _context;

            public CashRegisterService(CinemaEFContext context)
            {
                _context = context;
            }

        public void AddCashRegister(CashRegister cashRegister)
        {
           _context.CashRegisters.Add(cashRegister);
            _context.SaveChanges();
        }
        public void UpdateCashRegister(CashRegister cashRegister)
            {
                var existingCashRegister = _context.CashRegisters.FirstOrDefault(cr => cr.Id == cashRegister.Id);
                if (existingCashRegister != null)
                {
                    existingCashRegister.Amount = cashRegister.Amount;
                    existingCashRegister.TransactionDate = cashRegister.TransactionDate;
                    existingCashRegister.Description = cashRegister.Description;
                    _context.SaveChanges();
                }
            }
        }
    }

