using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshment.Math;
using System.IO;
using System.Threading;
using Amazon;
using System.Collections;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            var workflow = new Workflow();
            var uploadingVideo = new UploadingVideo();
            var notifyingWebService = new NotifyingWebService();
            var notifyingOwner = new NotifyingOwner();
            var changingStatusOfAVideo = new ChangingStatusOfAVideo();
            workflow.RegisterActivity(uploadingVideo);
            workflow.RegisterActivity(notifyingWebService);
            workflow.RegisterActivity(notifyingOwner);
            workflow.RegisterActivity(changingStatusOfAVideo);
            workflowEngine.Run(workflow);
        }

    }
}