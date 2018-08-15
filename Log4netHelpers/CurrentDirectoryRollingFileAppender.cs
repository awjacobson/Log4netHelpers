using System.IO;

namespace Log4netHelpers
{
    public class CurrentDirectoryRollingFileAppender : log4net.Appender.RollingFileAppender
    {
        /// <summary>
        /// Make log4net output to current working directory.
        /// </summary>
        /// <remarks>
        /// Could not create Appender
        /// https://stackoverflow.com/questions/1922430/how-do-you-make-log4net-output-to-current-working-directory
        /// </remarks>
        public CurrentDirectoryRollingFileAppender()
        {
        }

        public override string File
        {
            get => base.File;
            set => base.File = Path.Combine(Directory.GetCurrentDirectory(), value);
        }
    }
}