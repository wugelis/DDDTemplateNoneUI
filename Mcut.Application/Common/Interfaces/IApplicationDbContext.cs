using Mcut.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mcut.Application.Common.Interfaces
{
    /// <summary>
    /// 提供 DI Container 在 CQRS Command 端注入 DbContext 物件
    /// </summary>
    public interface IApplicationDbContext
    {
        DbSet<AccountEnt> Account { get; set; }
        DbSet<CustomerDetailEnt> CustomerDetail { get; set; }

        DbSet<HosingLoansDataEnt> HosingLoansData { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}