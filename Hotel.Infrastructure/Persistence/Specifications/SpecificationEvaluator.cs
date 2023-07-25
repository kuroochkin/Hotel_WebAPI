using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

		var query = specification.IncludesExpressions.Aggregate(
			queryable,
			(current, IncludeExpression) =>
				IncludeExpression(current));

		return query;
	}
}
