using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Hotel.Infrastructure.Persistence.Specifications;

public abstract class Specification<TEntity>
	where TEntity : class
{
	protected Specification(Expression<Func<TEntity, bool>>? criteria)
	{
		Criteria = criteria;
	}

	protected Specification()
	{
	}

	public Expression<Func<TEntity, bool>>? Criteria { get; }

	public List<Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>> IncludesExpressions { get; } = new();

	protected virtual void AddInclude(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includeExpression)
	{
		IncludesExpressions.Add(includeExpression);
	}

}
