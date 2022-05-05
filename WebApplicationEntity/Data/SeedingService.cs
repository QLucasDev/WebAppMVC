using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEntity.Models;
using WebApplicationEntity.Models.Enums;

namespace WebApplicationEntity.Data
{
    public class SeedingService
    {
        private WebApplicationEntityContext _context;

        public SeedingService(WebApplicationEntityContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB já foi populado!!
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion"); 
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@Boolmail.com", new DateTime(1998, 04, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "Maria@Boolmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@Boolmail.com", new DateTime(1988, 01, 15), 1000.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@Boolmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@Boolmail.com", new DateTime(2000, 01, 09), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "alexP@boomail.com", new DateTime(1997, 03, 04), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 05, 03), 14000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 05, 03), 17000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 05, 03), 13500.0, SaleStatus.Billed, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 05, 03), 14250.0, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 05, 03), 10000.0, SaleStatus.Billed, s6);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 05, 03), 11220.0, SaleStatus.Billed, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 05, 03), 14430.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 05, 03), 10000.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 05, 03), 14650.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 05, 03), 14075.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 05, 03), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 05, 03), 16700.0, SaleStatus.Billed, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 05, 03), 13500.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13);

            _context.SaveChanges();
        }
    }
}
