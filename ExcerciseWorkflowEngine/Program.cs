using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace WorkFlowEngine
{
    public class UploadVideoWorkflow : IWorkflows
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage....");
        }
    }


    public class CallWebServiceWorkflow : IWorkflows
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.....");
        }
    }


    public class SendEmailWorkflow : IWorkflows
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing......");
        }
    }


    public class ChangeStatusWorkflow : IWorkflows
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”......");
        }
    }


    public interface IWorkflows
    {
        void Execute();
    }

    public class WorkflowEngine

    // The VideoEncoder class is responsible for encoding videos and notifying registered notification channels about
    // the encoding process.It maintains a private list _notificationChannels of INotificationChannel objects.
    {
        private readonly IList<IWorkflows> _workflows;
        public WorkflowEngine()
        {
            _workflows = new List<IWorkflows>();
        }
        public void Run()
        {
            foreach (var wf in _workflows)
                wf.Execute();
        }
        public void RegisterWorkflow(IWorkflows workflow)
        //   The RegisterNotificationChannel method is called on the encoder object to add a MailNotificationChannel
        //   and a SmsNotificationChannel to the list of notification channels.

        {
            _workflows.Add(workflow);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var engine = new WorkflowEngine();
            engine.RegisterWorkflow(new UploadVideoWorkflow());
            engine.RegisterWorkflow(new CallWebServiceWorkflow());
            engine.RegisterWorkflow(new SendEmailWorkflow());
            engine.RegisterWorkflow(new ChangeStatusWorkflow());
            engine.Run();
        }


    }
}
