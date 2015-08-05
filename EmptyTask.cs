using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdcAPI
{
    public class EmptyTask
    {
        public static Task Start()
        {
            var taskSource = new TaskCompletionSource<AsyncVoid>();
            taskSource.SetResult(default(AsyncVoid));
            return taskSource.Task as Task;
        }

        private struct AsyncVoid
        {
        }
    }
}
