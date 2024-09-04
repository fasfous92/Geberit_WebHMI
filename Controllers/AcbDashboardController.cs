using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Models.Entities.ACB;

namespace WebApplication3.Controllers
{
    public class AcbDahsboardController : Controller
    {
        private readonly AcbDbContext dbContext;
        public AcbDahsboardController(AcbDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Read()
        {
            var query = "SELECT distinct benchID FROM [DEHA_ACB].[dbo].[BENCH_CONSUMPTION] order by benchID Asc";
            var listIDasc = await dbContext.BenchId.FromSqlRaw(query).ToListAsync();

            var viewModel = new AcbDashboardViewModel
            {
                benchsTotal = new List<BenchTotal>(),
            };
            //            viewModel.test = listIDasc;

            var benchConsumptionsInter = new List<benchConsumption>();
            var castProcessInter = new List<castProcess>();
            var benchsTotalInter = new List<BenchTotal>();

            foreach (var bench in listIDasc)
            {
                var queryBench = "SELECT Top (1) * FROM [DEHA_ACB].[dbo].[BENCH_CONSUMPTION] where benchID=" + bench.BenchNumber + " order by Timestampcol Desc";
                var queryCast = "SELECT Top (1) * FROM [DEHA_ACB].[dbo].[CAST_PROCESS] where benchID=" + bench.BenchNumber + " order by Timestampcol Desc";
                var benchConsumption = await dbContext.benchConsumption.FromSqlRaw(queryBench).ToListAsync();
                var castProcess = await dbContext.castProcess.FromSqlRaw(queryCast).ToListAsync();
                var benchTotal = new BenchTotal(benchConsumption[0], castProcess[0]);
                benchsTotalInter.Add(benchTotal);
            }

            viewModel.benchsTotal = benchsTotalInter;



            return View(viewModel);
        }

    }
}
