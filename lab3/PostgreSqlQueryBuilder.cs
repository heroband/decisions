using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public class PostgreSqlQueryBuilder : ISqlQueryBuilder
    {
        private string _query;
        public PostgreSqlQueryBuilder()
        {
            _query = string.Empty;
        }

        public string GetSQL()
        {
            return _query.Trim() + ";";
        }

        public ISqlQueryBuilder Select(string columns)
        {
            _query += $"SELECT {columns} ";
            return this;
        }

        public ISqlQueryBuilder Where(string condition)
        {
            _query += $"WHERE {condition} ";
            return this;
        }

        public ISqlQueryBuilder Limit(int limit)
        {
            _query += $"LIMIT {limit} ";
            return this;
        }
    }
}