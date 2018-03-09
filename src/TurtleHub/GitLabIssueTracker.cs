using GitLabApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
            this.parameters = parameters;
            client = new GitLabClient(parameters.Tracker, parameters.APIToken);
        }

        public async Task<IReadOnlyList<TurtleIssue>> GetAllIssuesOnRepository()
        {
            var issues = new List<TurtleIssue>();
            int projectIdNumber = 0;
            string projectId = String.Format("{0}/{1}", parameters.Owner, parameters.Repository);
            try
            {
                // Try to find the internal id because getting issues with project name group/project looks bugged
                var projects = await client.Projects.GetAsync(o => o.UserId = parameters.Owner);
                var project = projects.Where(p => p.Name == parameters.Repository).FirstOrDefault();
                if (project != null)
                {
                    projectIdNumber = project.Id;
                    projectId = project.Id.ToString();
                }
            }
            catch(GitLabException)
            { }

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
                Number = issue.Id,
                Title = issue.Title,
                Creator = issue.Author?.Username,
                Assignee = issue.Assignee?.Username,
                IsPullRequest = false,
                HtmlUrl = issue.WebUrl
            };
        }

        private TurtleIssue CreateTurtleIssue(GitLabApiClient.Models.MergeRequests.Responses.MergeRequest pr)
        {
            return new TurtleIssue()
            {
                Number = pr.Id,
                Title = pr.Title,
                Creator = pr.Author?.Username,
                Assignee = pr.Assignee?.Username,
                IsPullRequest = true,
                HtmlUrl = pr.WebUrl
            };
        }
    }
}
