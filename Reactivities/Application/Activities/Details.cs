using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application
{
    public class Details
    {
        public class Query : IRequest<Active> 
        {
            public Guid Id;

        }

        public class Handler : IRequestHandler<Query,Active> 

        {   
            private readonly DataContext _dataContext;

              public Handler(DataContext dataContext)
             {
                _dataContext = dataContext;
             }

            
            public async Task<Active> Handle(Query request, CancellationToken cancellationToken)

            {
               return await _dataContext.Activity.FindAsync(request.Id);
            }
        }
         
       
        
    }
}