using System.Collections.Generic;

namespace AspCoreWebApiApp.Models
{
    public class BugOpenedVersionRequest
    {
        public string sessionId { get; set; }
        public string timestamp { get; set; }
        public Status status { get; set; }
        public string id { get; set; }
        public string originalRequest { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public string resolvedQuery { get; set; }
        public string action { get; set; }
        public string actionIncomplete { get; set; }
        public MetaData metadata { get; set; }
        public Parameters parameters { get; set; }
        public double score { get; set; }
        public Fulfillment fulfillment { get; set; }
        public string speech { get; set; }
        public string source { get; set; }
    }

    public class Fulfillment
    {
        public IEnumerable<Message> messages { get; set; }
        public string speech { get; set; }
    }

    public class Message
    {
        public int type { get; set; }
        public string speech { get; set; }
    }

    public class Parameters
    {
        public string bugNumber { get; set; }
    }

    public class MetaData
    {
        public string intentName { get; set; }
        public string intentId { get; set; }
        public string webhookForSlotFillingUsed { get; set; }
        public string webhookUsed { get; set; }
    }

    public class Status
    {
        public string code { get; set; }
        public string errorType { get; set; }
    }
}
