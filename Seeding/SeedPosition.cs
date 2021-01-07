using Final_Project_Group20_1.Models;
using Final_Project_Group20_1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Seeding
{
    public class SeedPosition
    {
        public static async Task AddPosition(AppDbContext _db)
        {
            String strPosition = "begin";
            if (_db.Positions.Count() == 16)
            {
                throw new Exception("The database already contains all 16 positions!");
            }

            Int32 intPositionAdded = 0;
            List<Position> Positions = new List<Position>();
            List<MajorPosition> majorPositions = new List<MajorPosition>();

            try
            {
                Position p1 = new Position()
                {
                    PositionTitle = "Supply Chain Internship",
                    PositionType = PositionType.I,
                    Location = "Houston, Texas",
                    Deadline = new DateTime(2019, 5, 5),
                    PositionDescription = ""
                };

                p1.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Shell");
                Positions.Add(p1);

                MajorPosition mp1 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Supply Chain Management"),
                    Position = p1
                };
                majorPositions.Add(mp1);

                Position p2 = new Position()
                {
                    PositionTitle = "Accounting Intern",
                    PositionType = PositionType.I,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 5, 1),
                    PositionDescription = "Work in our audit group"
                };

                p2.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Deloitte");
                Positions.Add(p2);

                MajorPosition mp2 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p2
                };
                majorPositions.Add(mp2);

                Position p3 = new Position()
                {
                    PositionTitle = "Web Development",
                    PositionType = PositionType.FT,
                    Location = "Richmond, Virginia",
                    Deadline = new DateTime(2019, 3, 14),
                    PositionDescription = "Developing a great new website for customer portfolio management"

                };

                p3.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Capital One");
                Positions.Add(p3);

                MajorPosition mp3 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p3
                };
                majorPositions.Add(mp3);

                Position p4 = new Position()
                {
                    PositionTitle = "Sales Associate",
                    PositionType = PositionType.FT,
                    Location = "Los Angeles, California",
                    Deadline = new DateTime(2019, 4, 1),
                    PositionDescription = ""

                };

                p4.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Aon");
                Positions.Add(p4);

                MajorPosition mp4a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p4
                };
                MajorPosition mp4b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p4
                };
                MajorPosition mp4c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p4
                };
                majorPositions.Add(mp4a);
                majorPositions.Add(mp4b);
                majorPositions.Add(mp4c);

                Position p5 = new Position()
                {
                    PositionTitle = "Amenities Analytics Intern",
                    PositionType = PositionType.I,
                    Location = "New York, New York",
                    Deadline = new DateTime(2019, 3, 30),
                    PositionDescription = "Help analyze our amenities and customer rewards programs"

                };

                p5.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Hilton Worldwide");
                Positions.Add(p5);

                MajorPosition mp5a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p5
                };
                MajorPosition mp5b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p5
                };
                MajorPosition mp5c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p5
                };
                MajorPosition mp5d = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p5
                };
                majorPositions.Add(mp5a);
                majorPositions.Add(mp5b);
                majorPositions.Add(mp5c);
                majorPositions.Add(mp5d);

                Position p6 = new Position()
                {
                    PositionTitle = "Junior Programmer",
                    PositionType = PositionType.I,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 4, 3),
                    PositionDescription = ""

                };

                p6.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Microsoft");
                Positions.Add(p6);

                MajorPosition mp6 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p6
                };
                majorPositions.Add(mp6);

                Position p7 = new Position()
                {
                    PositionTitle = "Consultant",
                    PositionType = PositionType.FT,
                    Location = "Houston, Texas",
                    Deadline = new DateTime(2019, 4, 15),
                    PositionDescription = "Full-time consultant position"

                };

                p7.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Accenture");
                Positions.Add(p7);

                MajorPosition mp7a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p7
                };
                MajorPosition mp7b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accouting"),
                    Position = p7
                };
                MajorPosition mp7c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p7
                };
                majorPositions.Add(mp7a);
                majorPositions.Add(mp7b);
                majorPositions.Add(mp7c);

                Position p8 = new Position()
                {
                    PositionTitle = "Project Manager",
                    PositionType = PositionType.FT,
                    Location = "Chicago, Illinois",
                    Deadline = new DateTime(2019, 6, 1),
                    PositionDescription = ""

                };

                p8.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Aon");
                Positions.Add(p8);

                MajorPosition mp8a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p8
                };
                MajorPosition mp8b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Supply Chain Management"),
                    Position = p8
                };
                MajorPosition mp8c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p8
                };
                MajorPosition mp8d = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p8
                };
                MajorPosition mp8e = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p8
                };
                MajorPosition mp8f = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "International Business"),
                    Position = p8
                };
                MajorPosition mp8g = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p8
                };
                majorPositions.Add(mp8a);
                majorPositions.Add(mp8b);
                majorPositions.Add(mp8c);
                majorPositions.Add(mp8d);
                majorPositions.Add(mp8e);
                majorPositions.Add(mp8f);
                majorPositions.Add(mp8g);

                Position p9 = new Position()
                {
                    PositionTitle = "Account Manager",
                    PositionType = PositionType.FT,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 2, 28),
                    PositionDescription = ""

                };

                p9.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Deloitte");
                Positions.Add(p9);

                MajorPosition mp9a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p9
                };
                MajorPosition mp9b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p9
                };
                majorPositions.Add(mp9a);
                majorPositions.Add(mp9b);

                Position p10 = new Position()
                {
                    PositionTitle = "Marketing Intern",
                    PositionType = PositionType.I,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 4, 30),
                    PositionDescription = "Help our marketing team develop new advertising strategies for local Austin businesses"

                };

                p10.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Adlucent");
                Positions.Add(p10);

                MajorPosition mp10 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p10
                };
                majorPositions.Add(mp10);

                Position p11 = new Position()
                {
                    PositionTitle = "Financial Analyst",
                    PositionType = PositionType.FT,
                    Location = "Richmond, Virginia",
                    Deadline = new DateTime(2019, 4, 15),
                    PositionDescription = ""

                };

                p11.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Capital One");
                Positions.Add(p11);

                MajorPosition mp11 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p11
                };
                majorPositions.Add(mp11);

                Position p12 = new Position()
                {
                    PositionTitle = "Pilot",
                    PositionType = PositionType.FT,
                    Location = "Ft. Worth, Texas",
                    Deadline = new DateTime(2019, 10, 8),
                    PositionDescription = ""

                };

                p12.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "United Airlines");
                Positions.Add(p12);

                MajorPosition mp12a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p12
                };
                MajorPosition mp12b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Supply Chain Management"),
                    Position = p12
                };
                MajorPosition mp12c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p12
                };
                MajorPosition mp12d = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p12
                };
                MajorPosition mp12e = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p12
                };
                MajorPosition mp12f = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "International Business"),
                    Position = p12
                };
                MajorPosition mp12g = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p12
                };
                majorPositions.Add(mp12a);
                majorPositions.Add(mp12b);
                majorPositions.Add(mp12c);
                majorPositions.Add(mp12d);
                majorPositions.Add(mp12e);
                majorPositions.Add(mp12f);
                majorPositions.Add(mp12g);

                Position p13 = new Position()
                {
                    PositionTitle = "Corporate Recruiting Intern",
                    PositionType = PositionType.I,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 4, 30),
                    PositionDescription = ""

                };

                p13.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Microsoft");
                Positions.Add(p13);

                MajorPosition mp13 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Management"),
                    Position = p13
                };
                majorPositions.Add(mp13);

                Position p14 = new Position()
                {
                    PositionTitle = "Business Analyst",
                    PositionType = PositionType.FT,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 5, 31),
                    PositionDescription = ""

                };

                p14.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Microsoft");
                Positions.Add(p14);

                MajorPosition mp14 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p14
                };
                majorPositions.Add(mp14);

                Position p15 = new Position()
                {
                    PositionTitle = "Programmer Analyst",
                    PositionType = PositionType.FT,
                    Location = "Minneapolis, Minnesota",
                    Deadline = new DateTime(2019, 5, 15),
                    PositionDescription = ""

                };

                p15.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Target");
                Positions.Add(p15);

                MajorPosition mp15 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p15
                };
                majorPositions.Add(mp15);

                Position p16 = new Position()
                {
                    PositionTitle = "Intern",
                    PositionType = PositionType.I,
                    Location = "Minneapolis, Minnesota",
                    Deadline = new DateTime(2019, 5, 15),
                    PositionDescription = ""

                };

                p16.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Target");
                Positions.Add(p16);

                MajorPosition mp16a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Acounting"),
                    Position = p16
                };
                MajorPosition mp16b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p16
                };
                MajorPosition mp16c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p16
                };
                MajorPosition mp16d = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "International Business"),
                    Position = p16
                };
                MajorPosition mp16e = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Management"),
                    Position = p16
                };
                MajorPosition mp16f = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p16
                };
                MajorPosition mp16g = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p16
                };
                MajorPosition mp16h = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Science and Technology Management"),
                    Position = p16
                };
                MajorPosition mp16i = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Supply Chain Management"),
                    Position = p16
                };
                majorPositions.Add(mp16a);
                majorPositions.Add(mp16b);
                majorPositions.Add(mp16c);
                majorPositions.Add(mp16d);
                majorPositions.Add(mp16e);
                majorPositions.Add(mp16f);
                majorPositions.Add(mp16g);
                majorPositions.Add(mp16h);
                majorPositions.Add(mp16i);

                Position p17 = new Position()
                {
                    PositionTitle = "Digital Intern",
                    PositionType = PositionType.I,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 5, 20),
                    PositionDescription = ""

                };

                p17.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Accenture");
                Positions.Add(p17);

                MajorPosition mp17a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p17
                };
                MajorPosition mp17b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p17
                };
                majorPositions.Add(mp17a);
                majorPositions.Add(mp17b);

                Position p18 = new Position()
                {
                    PositionTitle = "Analyst Development Program",
                    PositionType = PositionType.I,
                    Location = "Plano, Texas",
                    Deadline = new DateTime(2019, 5, 20),
                    PositionDescription = ""

                };

                p18.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Capital One");
                Positions.Add(p18);

                MajorPosition mp18a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p18
                };
                MajorPosition mp18b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p18
                };
                MajorPosition mp18c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p18
                };
                majorPositions.Add(mp18a);
                majorPositions.Add(mp18b);
                majorPositions.Add(mp18c);

                Position p19 = new Position()
                {
                    PositionTitle = "Procurements Associate",
                    PositionType = PositionType.FT,
                    Location = "Houston, Texas",
                    Deadline = new DateTime(2019, 5, 30),
                    PositionDescription = "Handle procurement and vendor accounts"

                };

                p19.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Shell");
                Positions.Add(p19);

                MajorPosition mp19 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Supply Chain Management"),
                    Position = p19
                };
                majorPositions.Add(mp19);

                Position p20 = new Position()
                {
                    PositionTitle = "IT Rotational Program",
                    PositionType = PositionType.FT,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 5, 30),
                    PositionDescription = ""

                };

                p20.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Texas Instruments");
                Positions.Add(p20);

                MajorPosition mp20 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p20
                };
                majorPositions.Add(mp20);

                Position p21 = new Position()
                {
                    PositionTitle = "Sales Rotational Program",
                    PositionType = PositionType.FT,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 5, 30),
                    PositionDescription = ""

                };

                p21.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Texas Instruments");
                Positions.Add(p21);

                MajorPosition mp21a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p21
                };
                MajorPosition mp21b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Management"),
                    Position = p21
                };
                MajorPosition mp21c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p21
                };
                MajorPosition mp21d = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p21
                };
                majorPositions.Add(mp21a);
                majorPositions.Add(mp21b);
                majorPositions.Add(mp21c);
                majorPositions.Add(mp21d);

                Position p22 = new Position()
                {
                    PositionTitle = "Accounting Rotational Program",
                    PositionType = PositionType.FT,
                    Location = "Austin, Texas",
                    Deadline = new DateTime(2019, 5, 30),
                    PositionDescription = ""

                };

                p22.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Texas Instruments");
                Positions.Add(p22);

                MajorPosition mp22 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p22
                };
                majorPositions.Add(mp22);


                Position p23 = new Position()
                {
                    PositionTitle = "Financial Planning Intern",
                    PositionType = PositionType.I,
                    Location = "Orlando, Florida",
                    Deadline = new DateTime(2019, 6, 1),
                    PositionDescription = ""

                };

                p23.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Academy Sports & Outdoors");
                Positions.Add(p23);

                MajorPosition mp23a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p23
                };
                MajorPosition mp23b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Accounting"),
                    Position = p23
                };
                MajorPosition mp23c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p23
                };
                majorPositions.Add(mp23a);
                majorPositions.Add(mp23b);
                majorPositions.Add(mp23c);


                Position p24 = new Position()
                {
                    PositionTitle = "Digital Product Manager",
                    PositionType = PositionType.FT,
                    Location = "Houston, Texas",
                    Deadline = new DateTime(2019, 6, 1),
                    PositionDescription = ""

                };

                p24.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Academy Sports & Outdoors");
                Positions.Add(p24);

                MajorPosition mp24a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p24
                };
                MajorPosition mp24b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p24
                };
                MajorPosition mp24c = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Business Honors"),
                    Position = p24
                };
                MajorPosition mp24d = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Management"),
                    Position = p24
                };
                majorPositions.Add(mp24a);
                majorPositions.Add(mp24b);
                majorPositions.Add(mp24c);
                majorPositions.Add(mp24d);


                Position p25 = new Position()
                {
                    PositionTitle = "Product Marketing Intern",
                    PositionType = PositionType.I,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 6, 1),
                    PositionDescription = ""

                };

                p25.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Microsoft");
                Positions.Add(p25);

                MajorPosition mp25a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p25
                };
                MajorPosition mp25b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p25
                };
                majorPositions.Add(mp25a);
                majorPositions.Add(mp25b);

                Position p26 = new Position()
                {
                    PositionTitle = "Program Manager",
                    PositionType = PositionType.FT,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 6, 1),
                    PositionDescription = ""

                };

                p26.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Microsoft");
                Positions.Add(p26);

                MajorPosition mp26a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Marketing"),
                    Position = p26
                };
                MajorPosition mp26b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p26
                };
                majorPositions.Add(mp26a);
                majorPositions.Add(mp26b);

                Position p27 = new Position()
                {
                    PositionTitle = "Security Analyst",
                    PositionType = PositionType.FT,
                    Location = "Redmond, Washington",
                    Deadline = new DateTime(2019, 6, 1),
                    PositionDescription = ""

                };

                p27.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "Microsoft");
                Positions.Add(p27);

                MajorPosition mp27 = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p27
                };
                majorPositions.Add(mp27);


                Position p28 = new Position()
                {
                    PositionTitle = "Big Data Analyst",
                    PositionType = PositionType.FT,
                    Location = "Dallas, Texas",
                    Deadline = new DateTime(2019, 5, 9),
                    PositionDescription = ""

                };

                p28.Company = _db.Companys.FirstOrDefault(c => c.CompanyName == "United Airlines");
                Positions.Add(p28);

                MajorPosition mp28a = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "MIS"),
                    Position = p28
                };
                MajorPosition mp28b = new MajorPosition()
                {
                    Major = _db.Majors.FirstOrDefault(m => m.MajorName == "Finance"),
                    Position = p28
                };
                majorPositions.Add(mp28a);
                majorPositions.Add(mp28b);

                //Do we need a for each?
                //Do we need to add a catch to each company?
                //Do I need to add more fields in the for each?
                //DO we need multiple comoanyindustry variables if the company is in multiple industries?


                foreach (Position positionToAdd in Positions)
                {
                    strPosition = positionToAdd.PositionTitle;
                    Position dbPosition = _db.Positions.FirstOrDefault(g => g.PositionTitle == positionToAdd.PositionTitle);
                    if (dbPosition == null)
                    {
                        _db.Positions.Add(positionToAdd);
                        _db.SaveChanges();
                        intPositionAdded += 1;
                    }
                }

                foreach (MajorPosition mpositionToAdd in majorPositions)
                {
                    MajorPosition majorPosition = _db.MajorPositions.FirstOrDefault(g => g.MajorPositionID == mpositionToAdd.MajorPositionID);
                    if (majorPosition == null)
                    {
                        _db.MajorPositions.Add(mpositionToAdd);
                        _db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                String msg = "Positions Added: " + intPositionAdded.ToString() + "Current position: " + strPosition;
                throw new InvalidOperationException(msg + ex.Message, ex);
            }
        }
    }
}