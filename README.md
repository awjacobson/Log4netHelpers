# Log4netHelpers
A collection of helpers to be used with Log4net.
## Banner
The Banner class contains static strings that can be used to render giant ASCII Art text in your logs. The class has the following static string properties:
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
## ToDebugString
ToDebugString is an extension method on the Object class. This method will serialize the instance to a JSON string which can then be written to your logs.

Example using ToDebugString to log all the details about an argument passed to a method:
```C#
public WorkOrder Create(WorkOrder workOrder)
{
    if (Logger.IsDebugEnabled)
    {
        Logger.Debug($"Entering Create (workOrder={workOrder.ToDebugString()})");
    }
```
## CurrentDirectoryRollingFileAppender
Make log4net output to current working directory.
```C#
<appender name="LogFileAppender" type="Log4netHelpers.CurrentDirectoryRollingFileAppender, Log4netHelpers">
```