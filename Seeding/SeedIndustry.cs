using Final_Project_Group20_1.DAL;
using Final_Project_Group20_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Seeding
{
    public static class SeedIndustry
    {
        public static void SeedAllIndustry(AppDbContext db)
        {
            // check to see if all the Industrys have already been added
            if (db.Companys.Count() == 13)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Industry record count is already 9!");
                throw ex;
            }
            Int32 intIndustrysAdded = 0;
            try
            {
                //Create a list of languages
                List<Company> Companys = new List<Company>();

                Company m1 = new Company() { CompanyIndustry = "Accounting" };
                Companys.Add(m1);

                Company m2 = new Company() { CompanyIndustry = "Consulting" };
                Companys.Add(m2);

                Company m3 = new Company() { CompanyIndustry = "Engineering" };
                Companys.Add(m3);

                Company m4 = new Company() { CompanyIndustry = "Financial Services" };
                Companys.Add(m4);

                Company m5 = new Company() { CompanyIndustry = "Manufacturing" };
                Companys.Add(m5);

                Company m6 = new Company() { CompanyIndustry = "Hospitality" };
                Companys.Add(m6);

                Company m7 = new Company() { CompanyIndustry = "Insurance" };
                Companys.Add(m7);

                Company m8 = new Company() { CompanyIndustry = "Marketing" };
                Companys.Add(m8);

                Company m9 = new Company() { CompanyIndustry = "Real-Estate" };
                Companys.Add(m9);

                Company m10 = new Company() { CompanyIndustry = "Technology" };
                Companys.Add(m10);

                Company m11 = new Company() { CompanyIndustry = "Retail" };
                Companys.Add(m11);

                Company m12 = new Company() { CompanyIndustry = "Energy" };
                Companys.Add(m12);

                Company m13 = new Company() { CompanyIndustry = "Transportation" };
                Companys.Add(m13);


                foreach (Company IndustryToAdd in Companys)
                {
                    Company dbIndustry = db.Companys.FirstOrDefault(m => m.CompanyIndustry == IndustryToAdd.CompanyIndustry);
                    if (dbIndustry == null)
                    {
                        db.Companys.Add(IndustryToAdd);
                        db.SaveChanges();
                        intIndustrysAdded += 1;
                    }
                }
            }
            catch
            {
                String msg = "Industrys Added: " + intIndustrysAdded.ToString();
                throw new InvalidOperationException(msg);
            }
        }
    }
}