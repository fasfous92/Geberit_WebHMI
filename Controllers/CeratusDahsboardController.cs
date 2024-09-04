using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Models.Entities.Ceratus;


namespace WebApplication3.Controllers
{
    public class CeratusDahsboardController : Controller

    {
        private readonly CeratusDbContext dbContext;
        public CeratusDahsboardController(CeratusDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Read()
        {


            var query = "SELECT distinct [shiftId]\r\n  FROM [Ceratus_Line].[dbo].[Shift_Perfromance] order by ShiftId asc"; //get all the shift Id available in database
            var listIDasc = await dbContext.ShiftId.FromSqlRaw(query).ToListAsync();

            var ShiftPerformancesTotalInter = new List<ShiftPerformanceTotal>();

            //read from database and store in intermediate varaiables 
            TimeShift TimeShift = new TimeShift();

            foreach (var Shift in listIDasc)
            {
                var queryShift = "SELECT Top (1) * FROM [Ceratus_Line].[dbo].[Shift_Perfromance] where ShiftID=" + Shift.Shiftnumber + " and CAST(Day_Shift AS DATE) = CAST(GETDATE() AS DATE) order by Day_Shift Desc";
                var perfromance = await this.dbContext.ShiftPerfromance.FromSqlRaw(queryShift).ToListAsync();
                if (perfromance.Count > 0) // if there is a perfromance today for the shift selected
                {
                    var ShiftPerfromancesTotal = new ShiftPerformanceTotal
                    {
                        ShiftPerformance = perfromance[0],
                        TimeShift = TimeShift.time.GetValueOrDefault(perfromance[0].shiftId)
                    };
                    ShiftPerformancesTotalInter.Add(ShiftPerfromancesTotal);
                }
            }

            var queryDailyConsumption = "SELECT top (1) * FROM [Ceratus_Line].[dbo].[Daily_consumption] order by Timestampcol desc";
            var DailyConsumption = await this.dbContext.DailyConsumption.FromSqlRaw(queryDailyConsumption).ToListAsync();


            // assign new variables to the view model in order to transfer to the html page

            var viewModel = new CeratusDashboardViewModel
            {
                DailyConsumption = DailyConsumption[0],
                ShiftPerformancesTotal = ShiftPerformancesTotalInter



            };


            return View(viewModel);
        }
    }
}
