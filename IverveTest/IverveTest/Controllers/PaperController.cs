using IverveTest.Model;
using IverveTest.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace IverveTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaperController : ControllerBase
    {
        private static List<Paper> paper = new List<Paper> {
                new Paper{
                    Id = 1,
                    Title = "Test",
                    Author = "Yash",
                    PublishedDate = DateTime.Now,
                    ReferenceCount = 1,
                    NumberOfCitation = 1,
                },
                new Paper{
                  Id= 2,
                  Title= "Recruiting Manager",
                  Author= "Database Administrator III",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 111,
                  NumberOfCitation= 350
                }, new Paper{
                  Id= 3,
                  Title= "Quality Control Specialist",
                  Author= "Recruiter",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 231,
                  NumberOfCitation= 265
                }, new Paper{
                  Id= 4,
                  Title= "Social Worker",
                  Author= "Safety Technician II",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 352,
                  NumberOfCitation= 244
                }, new Paper{
                  Id= 5,
                  Title= "Help Desk Operator",
                  Author= "Budget/Accounting Analyst I",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 454,
                  NumberOfCitation= 31
                }, new Paper{
                  Id= 6,
                  Title= "Civil Engineer",
                  Author= "Environmental Tech",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 177,
                  NumberOfCitation= 114
                }, new Paper{
                  Id= 7,
                  Title= "Staff Scientist",
                  Author= "Developer III",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 350,
                  NumberOfCitation= 224
                }, new Paper{
                  Id= 8,
                  Title= "Geological Engineer",
                  Author= "Biostatistician IV",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 66,
                  NumberOfCitation= 106
                }, new Paper{
                  Id= 9,
                  Title= "Administrative Assistant IV",
                  Author= "Accountant I",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 420,
                  NumberOfCitation= 4
                }, new Paper{
                  Id= 10,
                  Title= "VP Sales",
                  Author= "Administrative Assistant I",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 416,
                  NumberOfCitation= 163
                }, new Paper{
                  Id= 11,
                  Title= "Computer Systems Analyst IV",
                  Author= "Account Executive",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 333,
                  NumberOfCitation= 214
                }, new Paper{
                  Id= 12,
                  Title= "Director of Sales",
                  Author= "Payment Adjustment Coordinator",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 432,
                  NumberOfCitation= 412
                }, new Paper{
                  Id= 13,
                  Title= "Paralegal",
                  Author= "Assistant Media Planner",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 133,
                  NumberOfCitation= 347
                }, new Paper{
                  Id= 14,
                  Title= "Internal Auditor",
                  Author= "Biostatistician III",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 374,
                  NumberOfCitation= 259
                }, new Paper{
                  Id= 15,
                  Title= "Editor",
                  Author= "Research Associate",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 44,
                  NumberOfCitation= 181
                }, new Paper{
                  Id= 16,
                  Title= "Staff Accountant II",
                  Author= "Community Outreach Specialist",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 429,
                  NumberOfCitation= 355
                }, new Paper{
                  Id= 17,
                  Title= "Project Manager",
                  Author= "VP Product Management",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 379,
                  NumberOfCitation= 324
                }, new Paper{
                  Id= 18,
                  Title= "Project Manager",
                  Author= "Nurse Practicioner",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 37,
                  NumberOfCitation= 189
                }, new Paper{
                  Id= 19,
                  Title= "Civil Engineer",
                  Author= "Technical Writer",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 451,
                  NumberOfCitation= 456
                }, new Paper{
                  Id= 20,
                  Title= "Electrical Engineer",
                  Author= "Environmental Tech",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 131,
                  NumberOfCitation= 35
                }, new Paper{
                  Id= 21,
                  Title= "Staff Accountant I",
                  Author= "Assistant Manager",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 66,
                  NumberOfCitation= 233
                }, new Paper{
                  Id= 22,
                  Title= "Recruiter",
                  Author= "Food Chemist",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 470,
                  NumberOfCitation= 351
                }, new Paper{
                  Id= 23,
                  Title= "Technical Writer",
                  Author= "Help Desk Technician",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 302,
                  NumberOfCitation= 406
                }, new Paper{
                  Id= 24,
                  Title= "Dental Hygienist",
                  Author= "Automation Specialist IV",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 201,
                  NumberOfCitation= 127
                }, new Paper{
                  Id= 25,
                  Title= "Recruiter",
                  Author= "Executive Secretary",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 340,
                  NumberOfCitation= 372
                }, new Paper{
                  Id= 26,
                  Title= "Programmer Analyst I",
                  Author= "Teacher",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 439,
                  NumberOfCitation= 249
                }, new Paper{
                  Id= 27,
                  Title= "Quality Control Specialist",
                  Author= "Senior Editor",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 470,
                  NumberOfCitation= 298
                }, new Paper{
                  Id= 28,
                  Title= "Cost Accountant",
                  Author= "Analyst Programmer",
                  PublishedDate=DateTime.Now,
                  ReferenceCount= 127,
                  NumberOfCitation= 101
                }, new Paper{
                  Id= 29,
                  Title= "Teacher",
                  Author= "Marketing Assistant",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 350,
                  NumberOfCitation= 62
                }, new Paper{
                  Id= 30,
                  Title= "Account Representative II",
                  Author= "Marketing Assistant",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 49,
                  NumberOfCitation= 116
                }, new Paper{
                  Id= 31,
                  Title= "Cost Accountant",
                  Author= "Sales Representative",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 227,
                  NumberOfCitation= 497
                }, new Paper{
                  Id= 32,
                  Title= "Assistant Manager",
                  Author= "Physical Therapy Assistant",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 153,
                  NumberOfCitation= 237
                }, new Paper{
                  Id= 33,
                  Title= "Senior Cost Accountant",
                  Author= "Software Test Engineer I",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 443,
                  NumberOfCitation= 199
                }, new Paper{
                  Id= 34,
                  Title= "Systems Administrator III",
                  Author= "Cost Accountant",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 426,
                  NumberOfCitation= 141
                }, new Paper{
                  Id= 35,
                  Title= "VP Sales",
                  Author= "Biostatistician III",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 154,
                  NumberOfCitation= 43
                }, new Paper{
                  Id= 36,
                  Title= "Health Coach II",
                  Author= "Graphic Designer",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 92,
                  NumberOfCitation= 348
                }, new Paper{
                  Id= 37,
                  Title= "Account Executive",
                  Author= "Engineer II",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 38,
                  NumberOfCitation= 304
                }, new Paper{
                  Id= 38,
                  Title= "Speech Pathologist",
                  Author= "Help Desk Operator",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 139,
                  NumberOfCitation= 479
                }, new Paper{
                  Id= 39,
                  Title= "Account Representative II",
                  Author= "VP Quality Control",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 74,
                  NumberOfCitation= 235
                }, new Paper{
                  Id= 40,
                  Title= "Cost Accountant",
                  Author= "Research Assistant I",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 372,
                  NumberOfCitation= 77
                }, new Paper{
                  Id= 41,
                  Title= "Accounting Assistant III",
                  Author= "Automation Specialist II",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 371,
                  NumberOfCitation= 117
                }, new Paper{
                  Id= 42,
                  Title= "Design Engineer",
                  Author= "Systems Administrator I",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 389,
                  NumberOfCitation= 52
                }, new Paper{
                  Id= 43,
                  Title= "Community Outreach Specialist",
                  Author= "Operator",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 60,
                  NumberOfCitation= 404
                }, new Paper{
                  Id= 44,
                  Title= "Software Engineer III",
                  Author= "Senior Cost Accountant",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 433,
                  NumberOfCitation= 461
                }, new Paper{
                  Id= 45,
                  Title= "Nuclear Power Engineer",
                  Author= "Senior Editor",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 477,
                  NumberOfCitation= 206
                }, new Paper{
                  Id= 46,
                  Title= "Clinical Specialist",
                  Author= "Software Test Engineer III",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 303,
                  NumberOfCitation= 294
                }, new Paper{
                  Id= 47,
                  Title= "Director of Sales",
                  Author= "Occupational Therapist",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 410,
                  NumberOfCitation= 470
                }, new Paper{
                  Id= 48,
                  Title= "Compensation Analyst",
                  Author= "Senior Developer",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 18,
                  NumberOfCitation= 10
                }, new Paper{
                  Id= 49,
                  Title= "Chemical Engineer",
                  Author= "Research Associate",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 361,
                  NumberOfCitation= 194
                }, new Paper{
                  Id= 50,
                  Title= "Civil Engineer",
                  Author= "Paralegal",
                  PublishedDate= DateTime.Now,
                  ReferenceCount= 327,
                  NumberOfCitation= 23
                }

            };

        [HttpGet]
        public async Task<ActionResult<List<Paper>>> GetAllPapers(int pageNumber, int pageLimit, string columnName = "NumberOfCitation", string sortType = "asc")
        {
            pageNumber = pageNumber < 1 ? 1 : pageNumber;
            pageLimit = pageLimit > 10 ? 10 : pageLimit;

            var response = new List<Paper>();
            if (sortType == "asc")
            {
                if (columnName == "NumberOfCitation")
                {
                    response = paper.OrderBy(x => x.NumberOfCitation).Skip((pageNumber - 1) * pageLimit).Take(pageLimit).ToList();
                } else
                {
                    response = paper.OrderBy(x => x.Title).Skip((pageNumber - 1) * pageLimit).Take(pageLimit).ToList();
                }
            } else 
            {
                if (columnName == "NumberOfCitation")
                {
                    response = paper.OrderByDescending(x => x.NumberOfCitation).Skip((pageNumber - 1) * pageLimit).Take(pageLimit).ToList();
                } else
                {
                    response = paper.OrderByDescending(x => x.Title).Skip((pageNumber - 1) * pageLimit).Take(pageLimit).ToList();
                }
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Paper>> SavePaper(Paper request)
        {
            paper.Add(request);
            return Ok(paper);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Paper>> GetPaperById(int id)
        {
            var paperDetail = paper.Where(x => x.Id == id).FirstOrDefault();
            if (paperDetail != null)
            {
                paperDetail.CountClick += 1;
                return Ok(paper.Where(x => x.Id == id).FirstOrDefault());
            }
            else
            {
                return BadRequest("Paper Not Found");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Paper>> UpdatePaper(PaperDto request)
        {
            var updatePaper = paper.Where(x => x.Id == request.Id).FirstOrDefault();
            if (updatePaper != null)
            {
                updatePaper.Title = request.Title;
                updatePaper.Author = request.Author;
                updatePaper.PublishedDate = request.PublishedDate;
                updatePaper.ReferenceCount = request.ReferenceCount;
                updatePaper.NumberOfCitation = request.NumberOfCitation;

                return Ok(paper.Where(x=>x.Id == request.Id).FirstOrDefault());
            }
            else
            {
                return NotFound("Paper Not Found");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Paper>> DeletePaper(int id) 
        {
            var paperDetail = paper.Where(x => x.Id == id).FirstOrDefault();
            if (paperDetail == null)
                return BadRequest("Paper Not Found");

            paper.Remove(paperDetail);
            return Ok();
        }
    }
}
