using System;
using System.Diagnostics.Contracts;

namespace RetentionUnit.Models.DataBase
{
    public abstract class BaseProvider
    {
        internal readonly DbConnector Connector;

        private BaseProvider()
        {
            throw new ArgumentException("Default constructor deprecated");
        }

        /// <summary>
        /// Коннектор к БД
        /// </summary>
        internal DbConnector Db => Connector;

        /// <summary>
        /// Конструктор с инициализацией строки подключения
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        protected BaseProvider(string connectionString)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(connectionString),
                "Connection string is not presented");
            Connector = new DbConnector(connectionString);
        }
    }
}
