﻿using System.Linq.Expressions;

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

	public List<Expression<Func<TEntity, object>>> IncludeExpressions { get; } = new();

	protected void AddInclude(Expression<Func<TEntity, object>> includeExpression) =>
		IncludeExpressions.Add(includeExpression);
}
