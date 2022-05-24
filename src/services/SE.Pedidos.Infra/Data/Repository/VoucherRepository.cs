﻿using Microsoft.EntityFrameworkCore;
using SE.Core.Data;
using SE.Pedidos.Domain.Vouchers;

namespace SE.Pedidos.Infra.Data.Repository
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly PedidosContext _context;

        public VoucherRepository(PedidosContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<Voucher> ObterVoucherPorCodigo(string codigo)
        {
            return await _context.Vouchers.FirstOrDefaultAsync(v => v.Codigo == codigo);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
