using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Persistence.Specifications;

public static class SpecificationEvaluator
{
	public static IQueryable<TEntity> GetQuery<TEntity>(
		IQueryable<TEntity> inputQueryable,
		Specification<TEntity> specification)
		where TEntity : class
	{
		IQueryable<TEntity> queryable = inputQueryable;

		if(specification.Criteria is not null)
		{
			queryable = queryable.Where(specification.Criteria);
		}

		specification.IncludeExpressions.Aggregate(
			queryable,
			(current, IncludeExpression) =>
				current.Include(IncludeExpression));

		return queryable;
	}
}
