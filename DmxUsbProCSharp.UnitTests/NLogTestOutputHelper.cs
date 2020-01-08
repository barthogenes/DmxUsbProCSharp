using NLog;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace DmxUsbProCSharp.UnitTests
{
	public class NLogTestOutputHelper : ILogger
	{
		private readonly ITestOutputHelper testOutputHelper;

		public NLogTestOutputHelper(ITestOutputHelper testOutputHelper)
		{
			this.testOutputHelper = testOutputHelper;
		}

		public bool IsTraceEnabled => throw new NotImplementedException();

		public bool IsDebugEnabled => throw new NotImplementedException();

		public bool IsInfoEnabled => throw new NotImplementedException();

		public bool IsWarnEnabled => throw new NotImplementedException();

		public bool IsErrorEnabled => throw new NotImplementedException();

		public bool IsFatalEnabled => throw new NotImplementedException();

		public string Name => throw new NotImplementedException();

		public LogFactory Factory => throw new NotImplementedException();

#pragma warning disable CS0067
		public event EventHandler<EventArgs> LoggerReconfigured;
#pragma warning restore CS0067

		public void Debug(object value)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, object value)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, object arg1, object arg2)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, object arg1, object arg2, object arg3)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Debug<T>(T value)
		{
			throw new NotImplementedException();
		}

		public void Debug<T>(IFormatProvider formatProvider, T value)
		{
			throw new NotImplementedException();
		}

		public void Debug(LogMessageGenerator messageFunc)
		{
			throw new NotImplementedException();
		}

		public void Debug(Exception exception, [Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Debug(Exception exception, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Debug(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Debug([Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Debug([Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Debug([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Debug<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Debug<TArgument>([Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Debug<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void Debug<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void DebugException([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Error(object value)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, object value)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, object arg1, object arg2)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, object arg1, object arg2, object arg3)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Error<T>(T value)
		{
			throw new NotImplementedException();
		}

		public void Error<T>(IFormatProvider formatProvider, T value)
		{
			throw new NotImplementedException();
		}

		public void Error(LogMessageGenerator messageFunc)
		{
			throw new NotImplementedException();
		}

		public void Error(Exception exception, [Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Error(Exception exception, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Error(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Error([Localizable(false)] string message)
		{
			testOutputHelper.WriteLine(message);
		}

		public void Error([Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Error([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Error<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Error<TArgument>([Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Error<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void Error<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void ErrorException([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Fatal(object value)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, object value)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, object arg1, object arg2)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, object arg1, object arg2, object arg3)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal(string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal<T>(T value)
		{
			throw new NotImplementedException();
		}

		public void Fatal<T>(IFormatProvider formatProvider, T value)
		{
			throw new NotImplementedException();
		}

		public void Fatal(LogMessageGenerator messageFunc)
		{
			throw new NotImplementedException();
		}

		public void Fatal(Exception exception, [Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Fatal(Exception exception, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Fatal(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Fatal([Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Fatal([Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Fatal([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Fatal<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal<TArgument>([Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Fatal<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void Fatal<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void FatalException([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Info(object value)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, object value)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, object arg1, object arg2)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, object arg1, object arg2, object arg3)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, string argument)
		{
			testOutputHelper.WriteLine(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, int argument)
		{
			testOutputHelper.WriteLine(message, argument);
		}

		public void Info(IFormatProvider formatProvider, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Info<T>(T value)
		{
			throw new NotImplementedException();
		}

		public void Info<T>(IFormatProvider formatProvider, T value)
		{
			throw new NotImplementedException();
		}

		public void Info(LogMessageGenerator messageFunc)
		{
			throw new NotImplementedException();
		}

		public void Info(Exception exception, [Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Info(Exception exception, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Info(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Info([Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Info([Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Info([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Info<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Info<TArgument>([Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Info<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void Info<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void InfoException([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public bool IsEnabled(LogLevel level)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, object value)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, object value)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, object arg1, object arg2)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, object arg1, object arg2, object arg3)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Log(LogEventInfo logEvent)
		{
			throw new NotImplementedException();
		}

		public void Log(Type wrapperType, LogEventInfo logEvent)
		{
			throw new NotImplementedException();
		}

		public void Log<T>(LogLevel level, T value)
		{
			throw new NotImplementedException();
		}

		public void Log<T>(LogLevel level, IFormatProvider formatProvider, T value)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, LogMessageGenerator messageFunc)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, [Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Log(LogLevel level, [Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Log<TArgument>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Log<TArgument>(LogLevel level, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Log<TArgument1, TArgument2>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Log<TArgument1, TArgument2>(LogLevel level, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void LogException(LogLevel level, [Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Swallow(Action action)
		{
			throw new NotImplementedException();
		}

		public T Swallow<T>(Func<T> func)
		{
			throw new NotImplementedException();
		}

		public T Swallow<T>(Func<T> func, T fallback)
		{
			throw new NotImplementedException();
		}

		public void Swallow(Task task)
		{
			throw new NotImplementedException();
		}

		public Task SwallowAsync(Task task)
		{
			throw new NotImplementedException();
		}

		public Task SwallowAsync(Func<Task> asyncAction)
		{
			throw new NotImplementedException();
		}

		public Task<TResult> SwallowAsync<TResult>(Func<Task<TResult>> asyncFunc)
		{
			throw new NotImplementedException();
		}

		public Task<TResult> SwallowAsync<TResult>(Func<Task<TResult>> asyncFunc, TResult fallback)
		{
			throw new NotImplementedException();
		}

		public void Trace(object value)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, object value)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, object arg1, object arg2)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, object arg1, object arg2, object arg3)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Trace(string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Trace<T>(T value)
		{
			throw new NotImplementedException();
		}

		public void Trace<T>(IFormatProvider formatProvider, T value)
		{
			throw new NotImplementedException();
		}

		public void Trace(LogMessageGenerator messageFunc)
		{
			throw new NotImplementedException();
		}

		public void Trace(Exception exception, [Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Trace(Exception exception, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Trace(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Trace([Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Trace([Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Trace([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Trace<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Trace<TArgument>([Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Trace<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void Trace<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void TraceException([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Warn(object value)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, object value)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, object arg1, object arg2)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, object arg1, object arg2, object arg3)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, bool argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, char argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, byte argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, string argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, int argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, long argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, float argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, double argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, decimal argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, object argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, sbyte argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, uint argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Warn(string message, ulong argument)
		{
			throw new NotImplementedException();
		}

		public void Warn<T>(T value)
		{
			throw new NotImplementedException();
		}

		public void Warn<T>(IFormatProvider formatProvider, T value)
		{
			throw new NotImplementedException();
		}

		public void Warn(LogMessageGenerator messageFunc)
		{
			throw new NotImplementedException();
		}

		public void Warn(Exception exception, [Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Warn(Exception exception, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Warn(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Warn([Localizable(false)] string message)
		{
			throw new NotImplementedException();
		}

		public void Warn([Localizable(false)] string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Warn([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Warn<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Warn<TArgument>([Localizable(false)] string message, TArgument argument)
		{
			throw new NotImplementedException();
		}

		public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Warn<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
		{
			throw new NotImplementedException();
		}

		public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void Warn<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			throw new NotImplementedException();
		}

		public void WarnException([Localizable(false)] string message, Exception exception)
		{
			throw new NotImplementedException();
		}
	}
}
