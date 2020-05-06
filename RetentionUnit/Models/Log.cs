using System;
using Newtonsoft.Json;
using NLog;

namespace RetentionUnit.Models
{
    /// <summary>
    /// Единый логгер для всего приложения
    /// </summary>
    public static class Log
    {
        private static readonly Logger Nlog = LogManager.GetCurrentClassLogger();

        public static void Fatal(string text, params object[] o)
        {
            Nlog.Fatal(text, o);
        }

        public static void Error(string text, params object[] o)
        {
            Nlog.Error(text, o);
        }

        public static void Warn(string text, params object[] o)
        {
            Nlog.Warn(text, o);
        }

        public static void Debug(string text, params object[] o)
        {
            Nlog.Debug(text, o);
        }

        public static void Info(string text, params object[] o)
        {
            Nlog.Info(text, o);
        }

        [Obsolete]
        public static void ErrorException(string message, Exception e)
        {
            Nlog.Error(message, e);
        }

        [Obsolete]
        public static void FatalException(string message, Exception e)
        {
            Nlog.Fatal(message, e);
        }

        public static string LogFileName(string targetName)
        {
            var config = LogManager.Configuration;
            var target = config.FindTargetByName(targetName) as NLog.Targets.FileTarget;
            if (target == null)
            {
                return null;
            }

            return target.FileName.ToString().Replace("${basedir}", "~").Replace("\'", string.Empty);
        }

        public static void SwitchToConfig(string filePath)
        {
            LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(filePath);
        }

        public class ErrorObject
        {
            public object Message { get; set; }
            public object Params { get; set; }
            public object AdditionlInfo { get; set; }

            public ErrorObject()
            {
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="message">сообщение</param>
            /// <param name="param">параметры</param>
            /// <param name="additionalInfo">Дополнительная информация</param>
            public ErrorObject(object message, object param, object additionalInfo)
            {
                Message = message;
                Params = param;
                AdditionlInfo = additionalInfo;
            }

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }
    }
}
