## Banner
The Banner class contains static strings that can be used to render giant ASCII Art test in your logs. The class has the following static string properties:
* AppStart
* Error
* Warn
### Banner.AppStart
Example of using **AppStart** in Global.asax.cs:
```C#
protected void Application_Start()
{
    if (Logger.IsInfoEnabled)
    {
        Logger.Info($"\n{Banner.AppStart}");
    }
}
```
### Banner.Error
Example of using **Error** in a try/catch statement:
```C#
try
{
    // do something interesting
}
catch (Exception ex)
{
    Logger.Error($"\n{Banner.Error}\nError creating work order (workOrder={workOrder.ToDebugString()})", ex);
    throw ex;
}
```
## CurrentDirectoryRollingFileAppender
Make log4net output to current working directory.
```C#
<appender name="LogFileAppender" type="Log4netHelpers.CurrentDirectoryRollingFileAppender, Log4netHelpers">
```