using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Models.Entities.ACB;

namespace WebApplication3.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly AcbDbContext dbContext;
        public ReceiptController(AcbDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Read(int benchID)
        {
            var query = "SELECT distinct benchID FROM [DEHA_ACB].[dbo].[BENCH_CONSUMPTION] order by benchID Asc";
            var listIDasc = await dbContext.BenchId.FromSqlRaw(query).ToListAsync();

            var viewModel = new ReceiptViewModel
            {
                benchIds = new List<BenchId>(),
            };

            var queryBench = "SELECT Top (1) * FROM [DEHA_ACB].[dbo].[BENCH_CONSUMPTION] where benchID=" + benchID + " order by Timestampcol Desc";
            var queryCast = "SELECT Top (1) * FROM [DEHA_ACB].[dbo].[CAST_PROCESS] where benchID=" + benchID + " order by Timestampcol Desc";
            var benchConsumption = await dbContext.benchConsumption.FromSqlRaw(queryBench).ToListAsync();
            var castProcess = await dbContext.castProcess.FromSqlRaw(queryCast).ToListAsync();
            var benchTotal = new BenchTotal(benchConsumption[0], castProcess[0]);


            viewModel.benchsTotal = benchTotal;
            viewModel.benchIds = listIDasc;


            return View(viewModel);
        }
    }
}
