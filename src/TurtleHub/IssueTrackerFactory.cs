using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleHub
{
    public static class IssueTrackerFactory
    {
        public static IIssueTracker CreateIssueTracker(Parameters parameters)
        {
            IIssueTracker tracker = null;
            if (String.IsNullOrEmpty(parameters.Tracker) || parameters.Tracker.ToUpper() == "GITHUB")
            {
                tracker = new GitHubIssueTracker(parameters);
            }
            else
            {
                try
                {
                    var trackerUri = new Uri(parameters.Tracker);
                    if (trackerUri.Host.ToLower().EndsWith("github.com"))
                    {
                        tracker = new GitHubIssueTracker(parameters);
                    }
                    else
                    {
                        tracker = new GitLabIssueTracker(parameters);
                    }
                }
                catch(UriFormatException ex)
                {
                    Logger.LogMessageWithData("Issue Tracker Uri parsing exception: " + ex);
                }
            }

            return tracker;
        }
    }
}
