using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Models.Entities.ACB;

namespace WebApplication3.Controllers
{
    public class AcbDashboardMemController : Controller
    {
        private readonly AcbDbContext dbContext;
        public AcbDashboardMemController(AcbDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Read()
        {
            //get the list of IDs in ascending order
            var query = "SELECT distinct benchID FROM [DEHA_ACB].[dbo].[BENCH_CONSUMPTION] order by benchID Asc";
            var listIDasc = await dbContext.BenchId.FromSqlRaw(query).ToListAsync();

            var viewModel = new AcbDashboardMemViewModel
            {
                benchsCast = new List<castProcess>(),
                benchNumber = new List<BenchId>()
            };
            viewModel.benchNumber = listIDasc;

            return View(viewModel);
        }

    
        public async Task<IActionResult> Readfilter(int benchID, String date)
        {
            //get the list of IDs in ascending order
            var query = "SELECT distinct benchID FROM [DEHA_ACB].[dbo].[BENCH_CONSUMPTION] order by benchID Asc";
            var listIDasc = await dbContext.BenchId.FromSqlRaw(query).ToListAsync();

            var viewModel = new AcbDashboardMemViewModel
            {
                benchsCast = new List<castProcess>(),
                benchNumber = new List<BenchId>(),
                
            };
            viewModel.benchNumber = listIDasc;

            //get Cast Process from selection
            var queryCast = "SELECT* FROM [DEHA_ACB].[dbo].[CAST_PROCESS] where BenchID=" + benchID + " and CONVERT(date, Timestampcol)='"+date+"'";
            var listCast = await dbContext.castProcess.FromSqlRaw(queryCast).ToListAsync();

            viewModel.benchsCast = listCast;
            viewModel.SelectedBench = benchID;
            viewModel.SelectedDate = Convert.ToDateTime(date);




            return View(viewModel);
        }

    }
}
