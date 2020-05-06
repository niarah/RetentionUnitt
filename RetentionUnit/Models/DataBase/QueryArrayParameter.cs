using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace RetentionUnit.Models.DataBase
{
    /// <summary>
    /// Обертка для Table-valued parameter
    /// </summary>
    internal sealed class QueryArrayParameter : QueryParameter
    {
        public QueryArrayParameter(string key, object[] val, string fieldName)
            : base(key, val)
        {
            FieldName = fieldName;
        }

        /// <summary>
        /// Имя поля в типе TVP
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// Передача DataTable в качестве параметра
        /// </summary>
        public override OracleParameter AsSql
        {
            get
            {
                var dt = new DataTable("Items");
                dt.Columns.Add(FieldName);
                foreach (var rowVal in (object[])Value)
                {
                    dt.Rows.Add(rowVal);
                }
                var p = new OracleParameter(Name, dt);
                p.OracleDbType = OracleDbType.XmlType;
                return p;
            }
        }
    }
}
