using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace RetentionUnit.Models.DataBase
{
    /// <summary>
    /// Значение для передачи в SqlParameter
    /// </summary>
    internal class QueryParameter : IEquatable<QueryParameter>
    {
        public string Name
        {
            get;
        }

        /// <summary>
        /// Значение
        /// </summary>
        public object Value
        {
            get;
        }

        /// <summary>
        /// SqlParameter.Direction
        /// </summary>
        public ParameterDirection Direction
        {
            get;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="key">SQL parameter name</param>
        /// <param name="value">SQL parameter value</param>
        /// <param name="direction">SQL parameter direction</param>
        public QueryParameter(string key, object value, ParameterDirection direction = ParameterDirection.Input)
        {
            Name = key;
            Value = value;
            Direction = direction;
        }

        /// <summary>
        /// SQL параметр
        /// </summary>
        public virtual OracleParameter AsSql
        {
            get
            {
                var s = new OracleParameter(Name, Value);
                if (Direction != ParameterDirection.Input)
                {
                    if (ReferenceEquals(Value, null) || Value is string || Value.GetType() == typeof(object))
                    {
                        s.OracleDbType = OracleDbType.Varchar2;
                        s.Size = 256;
                    }

                    s.Direction = Direction;
                }

                return s;
            }
        }

        #region Overriden methods and operators

        /// <summary>
        /// Выводит значение параметра ParamValue
        /// </summary>
        public sealed override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Equality
        /// </summary>
        /// <param name="obj">The object instance to compare</param>
        /// <returns>True если ключи имеют одно и то же имя</returns>
        public override bool Equals(object obj)
        {
            if (obj is QueryParameter)
            {
                return Equals((QueryParameter)obj);
            }

            return false;
        }

        /// <summary>
        /// Хеш ключа
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        /// <summary>
        /// Сравнение двух SQL параметров
        /// </summary>
        /// <param name="other">Другой SQL параметр</param>
        /// <returns>true если поля Name у обоих SQL параметров равны (значения игнорируются)</returns>
        public bool Equals(QueryParameter other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            return Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public static bool operator ==(QueryParameter first, QueryParameter second)
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            if (ReferenceEquals(first, null))
            {
                return false;
            }

            return first.Equals(second);
        }

        public static bool operator !=(QueryParameter first, QueryParameter second)
        {
            return !(first == second);
        }

        #endregion
    }
}
