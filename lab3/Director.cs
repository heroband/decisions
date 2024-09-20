using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public class Director
    {
        private ISqlQueryBuilder _builder;
        public Director(ISqlQueryBuilder builder)
        {
            _builder = builder;
        }
        public void SetBuilder(ISqlQueryBuilder builder)
        {
            _builder = builder;
        }

        public string BuildQuery(string columns, string condition, int limit)
        {
            return _builder.Select(columns).Where(condition).Limit(limit).GetSQL();
        }
    }
}