using Final_Project_Group20_1.Models;
using Final_Project_Group20_1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group20_1.Seeding
{
    public static class SeedInterview
    {
        public static async Task AddInterview(AppDbContext _db)
        {
            if (_db.Interviews.Count() == 14)
            {
                throw new Exception("The database already contains all 14 interviews!");
            }

            int intInterviewAdded = 0;
            //Int32 intInterviewNumber = 0;
            List<Interview> Interviews = new List<Interview>();

            try
            {



                Interview i1 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 13, 13, 0, 0),
                    RoomNumber = RoomNumber.Two,
                    HourlySlot = HourlySlot.Thirteen,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Lou Ann Feeley",
                    InterviewerName = "Allison Taylor"
                };

                i1.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Marketing Intern");
                i1.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Adlucent");
                i1.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "feeley@penguin.org");
                i1.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "taylordjay@aool.com");
                Interviews.Add(i1);




                Interview i2 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 14, 13, 0, 0),
                    RoomNumber = RoomNumber.Two,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Eryn Rice",
                    InterviewerName = "Allison Taylor"
                };

                i2.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Marketing Intern");
                i2.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Adlucent");
                i2.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "erynrice@aoll.com");
                i2.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "taylordjay@aool.com");
                Interviews.Add(i2);


                Interview i3 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 15, 13, 0, 0),
                    RoomNumber = RoomNumber.Two,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Charles Miller",
                    InterviewerName = "Louis Winthorpe"
                };

                i3.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Corporate Recruiting Intern");
                i3.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Microsoft");
                i3.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "cmiller@bob.com");
                i3.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "louielouie@aool.com");
                Interviews.Add(i3);


                Interview i4 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 13, 10, 0, 0),
                    RoomNumber = RoomNumber.One,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Eric Stuart",
                    InterviewerName = "Clarence Martin"
                };

                i4.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Account Manager");
                i4.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Deloitte");
                i4.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "estuart@anchor.net");
                i4.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "mclarence@aool.com");
                Interviews.Add(i4);


                Interview i5 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 16, 14, 0, 0),
                    RoomNumber = RoomNumber.Two,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Christopher Baker",
                    InterviewerName = "Gregory Martinez"
                };

                i5.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Web Development");
                i5.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Capital One");
                i5.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "cbaker@example.com");
                i5.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "smartinmartin.Martin@aool.com");
                Interviews.Add(i5);


                Interview i6 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 4, 1, 9, 0, 0),
                    RoomNumber = RoomNumber.One,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Eryn Rice",
                    InterviewerName = "Rachel Taylor"
                };

                i6.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Amenities Analytics Intern");
                i6.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Hilton Worldwide");
                i6.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "erynrice@aoll.com");
                i6.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "yhuik9.Taylor@aool.com");
                Interviews.Add(i6);


                Interview i7 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 4, 1, 10, 0, 0),
                    RoomNumber = RoomNumber.One,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Tesa Freeley",
                    InterviewerName = "Rachel Taylor"
                };

                i7.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Amenities Analytics Intern");
                i7.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Hilton Worldwide");
                i7.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "feeley@penguin.org");
                i7.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "yhuik9.Taylor@aool.com");
                Interviews.Add(i7);


                Interview i8 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 4, 2, 15, 0, 0),
                    RoomNumber = RoomNumber.Four,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Lim Chou",
                    InterviewerName = "Rachel Taylor"
                };

                i8.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Amenities Analytics Intern");
                i8.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Hilton Worldwide");
                i8.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "limchou@gogle.com");
                i8.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "yhuik9.Taylor@aool.com");
                Interviews.Add(i8);


                Interview i9 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 10, 9, 0, 0),
                    RoomNumber = RoomNumber.One,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Brad Ingram",
                    InterviewerName = "Ernest Lowe"
                };

                i9.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Supply Chain Internship");
                i9.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Shell");
                i9.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "ingram@jack.com");
                i9.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "elowe@netscare.net");
                Interviews.Add(i9);


                Interview i10 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 10, 11, 0, 0),
                    RoomNumber = RoomNumber.One,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Sarah Saunders",
                    InterviewerName = "Ernest Lowe"
                };

                i10.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Supply Chain Internship");
                i10.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Shell");
                i10.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "saunders@pen.com");
                i10.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "elowe@netscare.net");
                Interviews.Add(i10);


                Interview i11 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 16, 15, 0, 0),
                    RoomNumber = RoomNumber.Three,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "John Smith",
                    InterviewerName = "Anka Radkovich"
                };

                i11.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Financial Analyst");
                i11.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Capital One");
                i11.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "johnsmith187@aoll.com");
                i11.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "or@aool.com");
                Interviews.Add(i11);


                Interview i12 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 5, 16, 11, 0, 0),
                    RoomNumber = RoomNumber.Four,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Chuck Luce",
                    InterviewerName = "Kelly Nelson"
                };

                i12.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Accounting Intern");
                i12.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Deloitte");
                i12.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "cluce@gogle.com");
                i12.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "nelson.Kelly@aool.com");
                Interviews.Add(i12);


                Interview i13 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 6, 5, 14, 0, 0),
                    RoomNumber = RoomNumber.Three,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "Eric Stuart",
                    InterviewerName = "Michelle Banks"
                };

                i13.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Consultant");
                i13.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Accenture");
                i13.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "estuart@anchor.net");
                i13.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "Michelle@example.com");
                Interviews.Add(i13);


                Interview i14 = new Interview()
                {
                    InterviewTime = new DateTime(2019, 6, 5, 16, 0, 0),
                    RoomNumber = RoomNumber.Three,
                    SlotStatus = SlotStatus.Filled,
                    IntervieweeName = "John Hearn",
                    InterviewerName = "Todd Jacobs"
                };

                i14.Positions = _db.Positions.FirstOrDefault(g => g.PositionTitle == "Consultant");
                i14.Company = _db.Companys.FirstOrDefault(g => g.CompanyName == "Accenture");
                i14.Interviewee = _db.Users.FirstOrDefault(g => g.Email == "wjhearniii@umich.org");
                i14.Interviewer = _db.Users.FirstOrDefault(g => g.Email == "toddy@aool.com");
                Interviews.Add(i14);





                try
                {
                    foreach (Interview interviewToAdd in Interviews)
                    {
                        intInterviewAdded = interviewToAdd.InterviewID;
                        Interview dbCompany = _db.Interviews.FirstOrDefault(g => g.InterviewID == interviewToAdd.InterviewID);
                        if (dbCompany == null)
                        {
                            _db.Interviews.Add(interviewToAdd);
                            _db.SaveChanges();
                            intInterviewAdded += 1;
                        }
                        else
                        {
                            _db.SaveChanges();
                        }
                    }
                }


                catch (Exception ex)
                {
                    String msg = "Interviews Added: " + intInterviewAdded.ToString();
                    throw new InvalidOperationException(ex.Message + msg);
                }
                }


            catch (Exception d)
            {
                throw new InvalidOperationException(d.Message);
            }

        }
    }
}
