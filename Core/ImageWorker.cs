using Microsoft.VisualBasic.Logging;

namespace MassImageEditor.Core;

public sealed class ImageWorker
{
    private readonly ImageTaskQueue _taskQueue;
    private readonly CancellationToken _cancellationToken;

    public event Action<ImageTask>? TaskCompleted;
    public event Action<ImageTask>? TaskStarted;
    public event Action<ImageTask, Exception>? TaskFailed;

    public ImageWorker(ImageTaskQueue taskQueue, CancellationToken cancellationToken)
    {
        _taskQueue = taskQueue;
        _cancellationToken = cancellationToken;
    }

    public Task StartAsync()
    {
        return Task.Run(RunWorkerLoop, _cancellationToken);
    }

    /// <summary>
    /// Continuously processes image tasks from the task queue until the cancellation is requested or the queue is marked as completed.
    /// During task execution, the following events may be triggered:
    /// <list type="bullet">
    /// <item>
    /// <description><c>TaskStarted</c> - Invoked when a new task begins processing.</description>
    /// </item>
    /// <item>
    /// <description><c>TaskCompleted</c> - Invoked when a task has been successfully processed.</description>
    /// </item>
    /// <item>
    /// <description><c>TaskFailed</c> - Invoked if an exception occurs during task processing.</description>
    /// </item>
    /// </list>
    /// Tasks are dequeued from the <see cref="ImageTaskQueue"/>. If the queue is empty or completed, and
    /// cancellation via the <see cref="CancellationToken"/> has not been requested, the loop terminates.
    /// </summary>
    private void RunWorkerLoop()
    {
        while (!_taskQueue.IsCompleted && !_cancellationToken.IsCancellationRequested)
        {
            ImageTask? task = null;

            try
            {
                task = _taskQueue.Dequeue(_cancellationToken);

            }
            catch (OperationCanceledException e)
            {
                break;
            }
            catch(InvalidOperationException)
            {
                //Queue is empty
                break;
            }

            if (task == null)
                continue;

            try
            {
                TaskStarted?.Invoke(task);

                // TODO: Replace this with real image processing logic.
                ProcessImage(task);

                TaskCompleted?.Invoke(task);
            }
            catch (Exception ex)
            {
                TaskFailed?.Invoke(task, ex);
            }
        }
    }
    private void ProcessImage(ImageTask task)
    {
        // Placeholder for CPU-bound work.
        // Example: load bitmap, apply filters, save to OutputPath.
        // Keep this synchronous; parallelism is achieved by multiple workers.
        Thread.Sleep(100);
    }
}