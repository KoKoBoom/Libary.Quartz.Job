using Common.Logging;
using Quartz;
using System;

namespace Library.Job
{
    public class SampleJob : IJob
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SampleJob));

        public void Execute(IJobExecutionContext context)
        {
            //执行调度
            try
            {
                logger.Info("调度完成。" + DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            catch (Exception error)
            {
                logger.Error(error.ToString());
            }
        }
    }
}
