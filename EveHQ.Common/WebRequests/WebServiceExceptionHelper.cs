// Проект: EveHQ.Common
// Имя файла: WebServiceExceptionHelper.cs
// GUID файла: A827C54B-FF5E-4BCF-B5F0-E3B33BD84B69
// Автор: Mike Eshva (mike@eshva.ru)
// Дата создания: 24.09.2017

#region Usings

using System;
using System.Net.Http;

#endregion


namespace EveHQ.Common
{
	public static class WebServiceExceptionHelper
	{
		public static bool IsServiceUnabailableError(Exception exception)
		{
			var aggregateException1 = exception as AggregateException;
			var aggregateException2 = aggregateException1?.InnerException as AggregateException;
			return aggregateException2?.InnerException is HttpRequestException;
		}
	}
}