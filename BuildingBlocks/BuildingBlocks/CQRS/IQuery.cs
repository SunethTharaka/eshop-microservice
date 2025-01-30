using MediatR;

namespace BuildingBlocks.CQRS
{



    public interface IQuery<out TRsponse>: IRequest<TRsponse>
        where TRsponse : notnull
    {
    }
}
