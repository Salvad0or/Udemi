using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application
{
    public class ReturnList
    {
        public class Query : IRequest<List<Active>>{}

        public class Handler : IRequestHandler<Query, List<Active>>
        
        {   
            private readonly DataContext _context;      

            public Handler(DataContext context)
            {
                _context = context;
            }  


            public async Task<List<Active>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activity.ToListAsync(); 
            }
        }

    }
}