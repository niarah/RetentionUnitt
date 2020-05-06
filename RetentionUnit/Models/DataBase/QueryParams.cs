using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace RetentionUnit.Models.DataBase
{
    /// <summary>
    /// Параметры для передачи в запрос к БД
    /// </summary>
    internal sealed class QueryParams
    {
        /// <summary>
        /// Входные параметры
        /// </summary>
        private List<QueryParameter> _iparams;

        /// <summary>
        /// Входные параметры
        /// </summary>
        public IEnumerable<QueryParameter> InParams => _iparams;

        /// <summary>
        /// Выходные параметры
        /// </summary>
        public Dictionary<string, object> OutParams
        {
            get;
            private set;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public QueryParams()
        {
            _iparams = new List<QueryParameter>();
        }

        /// <summary>
        /// Конструктор для одного параметра
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        public QueryParams(string name, object value)
        {
            _iparams = new List<QueryParameter> { new QueryParameter(name, value) };
        }

        /// <summary>
        /// Добавление значений параметров
        /// </summary>
        /// <param name="paramName">Имя параметра</param>
        /// <param name="paramValue">Значение параметра</param>
        /// <param name="direction">Входной/выходной параметр</param>
        public void Add(string paramName, object paramValue, ParameterDirection direction = ParameterDirection.Input)
        {
            var newParam = new QueryParameter(paramName, paramValue ?? DBNull.Value, direction);
            if (!_iparams.Contains(newParam))
            {
                _iparams.Add(newParam);
            }

            if (direction != ParameterDirection.Input && OutParams == null)
            {
                OutParams = new Dictionary<string, object>();
            }
        }

        /// <summary>
        /// Добавление Table-Valued parameter
        /// </summary>
        /// <param name="paramName">Имя параметра</param>
        /// <param name="paramValueArray">Массив значений</param>
        /// <param name="tvpFieldName">Имя колонки в TVP (поддерживаются только одноколоночные)</param>
        public void AddTvp<T>(string paramName, T[] paramValueArray, string tvpFieldName)
        {
            var p = new QueryArrayParameter(
                paramName,
                paramValueArray.Select(x => (object)x).ToArray(),
                tvpFieldName);
            _iparams.Add(p);
        }

        /// <summary>
        /// Добавление Table-Valued parameter для произвольного числа колонок
        /// </summary>
        /// <param name="paramName">Имя параметра</param>
        /// <param name="table">Таблица TVP</param>
        public void AddTable(string paramName, DataTable table)
        {
            _iparams.Add(new QueryTableParameter(paramName, table));
        }
    }
}
