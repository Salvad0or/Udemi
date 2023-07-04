using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Active Active { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _dataContext;
            public Handler(DataContext context)
            {
                _dataContext = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
               var active = await _dataContext.Activity.FindAsync(request.Active.Id);

               active.Title = request.Active.Title;

               await _dataContext.SaveChangesAsync();

               return Unit.Value;

            }
        }
    }
}