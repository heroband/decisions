using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public interface ISqlQueryBuilder
    {
        ISqlQueryBuilder Select(string columns); 
        ISqlQueryBuilder Where(string condition); 
        ISqlQueryBuilder Limit(int limit); 
        string GetSQL();
    }
}