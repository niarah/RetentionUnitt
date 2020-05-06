using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace RetentionUnit.Models.DataBase
{
    /// <summary>
    /// Table-valued параметр для произвольного количества колонок
    /// (для одноколоночных параметров <see cref="QueryArrayParameter"/>)
    /// </summary>
    class QueryTableParameter : QueryParameter
    {
        public QueryTableParameter(string key, DataTable value)
            : base(key, value)
        {
        }

        public override OracleParameter AsSql
        {
            get
            {
                var p = new OracleParameter(Name, Value);
                p.OracleDbType = OracleDbType.Raw;
                return p;
            }
        }
    }
}
