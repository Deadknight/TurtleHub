using GitLabApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TurtleHub
{
    public class GitLabIssueTracker : IIssueTracker
    {
        Parameters parameters;
        GitLabClient client;

        public GitLabIssueTracker(Parameters parameters)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            this.parameters = parameters;
            client = new GitLabClient(parameters.Tracker, parameters.APIToken);
        }

        public async Task<IReadOnlyList<TurtleIssue>> GetAllIssuesOnRepository()
        {
            var issues = new List<TurtleIssue>();
            int projectIdNumber = 0;
            //string projectId = String.Format("{0}/{1}", parameters.Owner, parameters.Repository);
            string projectId = parameters.Repository;
            try
            {
                // Try to find the internal id because getting issues with project name group/project looks bugged
                var projects = await client.Projects.GetAsync();
                var project = projects.Where(p => p.Name == parameters.Repository || p.Namespace.ToString() == parameters.Repository).FirstOrDefault();
                if (project != null)
                {
                    projectIdNumber = project.Id;
                    projectId = project.Id.ToString();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            var glissues = await client.Issues.GetAsync(projectId);
            foreach (var glissue in glissues)
            {
                issues.Add(CreateTurtleIssue(glissue));
            }

            if (projectIdNumber > 0)
            {
                var glprs = await client.MergeRequests.GetAsync(projectIdNumber);
                foreach (var glpr in glprs)
                {
                    issues.Add(CreateTurtleIssue(glpr));
                }
            }
            return issues;
        }

        public async Task<IReadOnlyList<string>> GetAllRepositories()
        {
            var repos = new List<string>();
            var projects = await client.Projects.GetAsync();
            foreach(var project in projects)
            {
                repos.Add(project.Name);
            }
            return repos;
        }

        public Task<RepositoryMetrics> GetRepositoryMetrics()
        {
            return null;
        }

        private TurtleIssue CreateTurtleIssue(GitLabApiClient.Models.Issues.Responses.Issue issue)
        {
            return new TurtleIssue()
            {
                Number = issue.Iid,
                Title = issue.Title,
                Creator = issue.Author?.Username,
                Assignee = issue.Assignee == null ? "" : issue.Assignee.Username,
                Labels = (issue.Labels == null || issue.Labels.Count == 0) ? "" : String.Join(",", issue.Labels),
                Milestone = issue.Milestone == null ? "" : issue.Milestone.Title,
                IsPullRequest = false,
                HtmlUrl = issue.WebUrl
            };
        }

        private TurtleIssue CreateTurtleIssue(GitLabApiClient.Models.MergeRequests.Responses.MergeRequest pr)
        {
            return new TurtleIssue()
            {
                Number = pr.Iid,
                Title = pr.Title,
                Creator = pr.Author?.Username,
                Assignee = pr.Assignee?.Username,
                Labels = "",
                Milestone = "",
                IsPullRequest = true,
                HtmlUrl = pr.WebUrl
            };
        }
    }
}
