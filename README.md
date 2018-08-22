# Log4netHelpers
A collection of helpers to be used with Log4net.
## Download
Add Log4netHelpers to your .Net project using the [Nuget package](https://www.nuget.org/packages/log4nethelpers).
## Banner
The Banner class contains static strings that can be used to render giant ASCII art text in your logs. When viewing your logs in tools such as Visual Studio Code, the banners will stand out in the minimap.

![Example Banners](https://raw.githubusercontent.com/awjacobson/Log4netHelpers/master/docs/banner_example.png)

The class has the following static string properties:
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
Example outout from the above snippet:

![Example ToDebugString](https://raw.githubusercontent.com/awjacobson/Log4netHelpers/master/docs/todebugstring_example.png)

## CurrentDirectoryRollingFileAppender
Make log4net output to current working directory.
```C#
<appender name="LogFileAppender" type="Log4netHelpers.CurrentDirectoryRollingFileAppender, Log4netHelpers">
```