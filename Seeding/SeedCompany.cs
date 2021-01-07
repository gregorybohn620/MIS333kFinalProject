
using Final_Project_Group20_1.Models;
using Final_Project_Group20_1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Seeding
{
    public class SeedCompany
    {
        public static async Task AddCompany(AppDbContext _db)
        {

            if (_db.Companys.Count() == 13)
            {
                throw new Exception("The database already contains all 13 companys!");
            }


            Int32 intCompanyAdded = 0;
            String strCompanyName = "Begin";
            List<Company> Companys = new List<Company>();

            try
            {
                Company b1 = new Company()
                {
                    CompanyName = "Accenture",
                    CompanyEmail = "accenture@example.com",
                    CompanyDescription = "Accenture is a global management consulting, technology services and outsourcing company.",
                    CompanyIndustry = "Consulting,Technology"

                };
                Companys.Add(b1);

                Company b2 = new Company()
                {
                    CompanyName = "Shell",
                    CompanyEmail = "shell@example.com",
                    CompanyDescription = "Shell Oil Company, including its consolidated companies and its share in equity companies, is one of America's leading oild and natural gas producers, natural gas marketers, gasoline marketers and petrochemical manufacturers.",
                    CompanyIndustry = "Energy,Chemicals"

                };
                Companys.Add(b2);

                Company b3 = new Company()
                {
                    CompanyName = "Deloitte",
                    CompanyEmail = "deloitte@example.com",
                    CompanyDescription = "Deloitte is one of the leading professional services organizations in the United States specializing in audit, tax, consulting, and financial advisory services with clients in more than 20 industries.",
                    CompanyIndustry = "Accounting,Consulting,Technology"

                };
                Companys.Add(b3);

                Company b4 = new Company()
                {
                    CompanyName = "Capital One",
                    CompanyEmail = "capitalone@example.com",
                    CompanyDescription = "Capital One offers a broad spectrum of financial products and services to consumers, small businesses and commercial clients.",
                    CompanyIndustry = "Financial Services"

                };
                Companys.Add(b4);

                Company b5 = new Company()
                {
                    CompanyName = "Texas Instruments",
                    CompanyEmail = "texasinstruments@example.com",
                    CompanyDescription = "TI is one of the world’s largest global leaders in analog and digital semiconductor design and manufacturing",
                    CompanyIndustry = "Manufacturing"

                };
                Companys.Add(b5);

                Company b6 = new Company()
                {
                    CompanyName = "Hilton Worldwide",
                    CompanyEmail = "hiltonworldwide@example.com",
                    CompanyDescription = "Hilton Worldwide offers business and leisure travelers the finest in accommodations, service, amenities and value.",
                    CompanyIndustry = "Hospitality"

                };
                Companys.Add(b6);

                Company b7 = new Company()
                {
                    CompanyName = "Aon",
                    CompanyEmail = "aon@example.com",
                    CompanyDescription = "Aon is the leading global provider of risk management, insurance and reinsurance brokerage, and human resources solutions and outsourcing services.",
                    CompanyIndustry = "Insurance, Construlting"

                };
                Companys.Add(b7);

                Company b8 = new Company()
                {
                    CompanyName = "Adlucent",
                    CompanyEmail = "adlucent@example.com",
                    CompanyDescription = "Adlucent is a technology and analytics company specializing in selling products through the Internet for online retail clients.",
                    CompanyIndustry = "Marketing, Technology"

                };
                Companys.Add(b8);

                Company b9 = new Company()
                {
                    CompanyName = "Stream Realty Partners",
                    CompanyEmail = "streamrealtypartners@example.com",
                    CompanyDescription = "Stream Realty Partners, L.P. (Stream) is a national, commercial real estate firm with locations across the country.",
                    CompanyIndustry = "Real-Estate"

                };
                Companys.Add(b9);

                Company b10 = new Company()
                {
                    CompanyName = "Microsoft",
                    CompanyEmail = "microsoft@example.com",
                    CompanyDescription = "Microsoft is the worldwide leader in software, services and solutions that help people and businesses realize their full potential.",
                    CompanyIndustry = "Technology"

                };
                Companys.Add(b10);

                Company b11 = new Company()
                {
                    CompanyName = "Academy Sports & Outdoors",
                    CompanyEmail = "academysports@example.com",
                    CompanyDescription = "Academy Sports is intensely focused on being a leader in the sporting goods, outdoor and lifestyle retail arena",
                    CompanyIndustry = "Retail"

                };
                Companys.Add(b11);

                Company b12 = new Company()
                {
                    CompanyName = "United Airlines",
                    CompanyEmail = "unitedairlines@example.com",
                    CompanyDescription = "United Airlines has the most modern and fuel-efficient fleet (when adjusted for cabin size), and the best new aircraft order book, among U.S. network carriers",
                    CompanyIndustry = "Transportation"

                };
                Companys.Add(b12);

                Company b13 = new Company()
                {
                    CompanyName = "Target",
                    CompanyEmail = "target@example.com",
                    CompanyDescription = "Target is a leading retailer",
                    CompanyIndustry = "Retail"

                };
                Companys.Add(b13);


                //Do we need a for each?
                //Do we need to add a catch to each company?
                //Do I need to add more fields in the for each?
                //DO we need multiple comoanyindustry variables if the company is in multiple industries?

         
                foreach (Company companyToAdd in Companys)
                {
                    Company dbCompany = _db.Companys.FirstOrDefault(g => g.CompanyName == companyToAdd.CompanyName);
                    if (dbCompany == null)
                    {
                        _db.Companys.Add(companyToAdd);
                        _db.SaveChanges();
                        intCompanyAdded += 1;
                    }
                }
            }
            catch
            {
                String msg = "Companys Added: " + intCompanyAdded.ToString();
                throw new InvalidOperationException(msg);
            }


        }

        //internal static void AddPosition(AppDbContext db)
        //{
        //    throw new NotImplementedException();
        //}
    }
}