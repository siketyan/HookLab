using System;
using System.Collections.Generic;
using HookLab.Models;
using HookLab.Providers.GitLab;
using HookLab.Targets;
using HookLab.Targets.Slack;

namespace HookLab.UserDictionaries
{
    public class GitLabSlackUserDictionary : IUserDictionary
    {
        private const char RowSeparator = ';';
        private const char ColumnSeparator = '=';
        
        private readonly IDictionary<string, string> _dictionary;
        
        public GitLabSlackUserDictionary(string dictionary)
        {
            _dictionary = new Dictionary<string, string>();

            foreach (var row in dictionary.Split(RowSeparator))
            {
                var column = row.Split(ColumnSeparator);
                if (column.Length < 2)
                {
                    continue;
                }
                
                var gitlab = column[0];
                var slack = column[1];
                
                _dictionary.Add(gitlab, slack);
            }
        }

        public string Find(Notification notification)
        {
            var username = notification.Sender;
            if (_dictionary.ContainsKey(username))
            {
                return _dictionary[username];
            }
            
            throw new NotSupportedException(
                "The user is not in the dictionary."
            );
        }

        public bool Supports(Notification notification, ITarget target)
        {
            return notification.Provider is GitLabProvider && target is SlackTarget;
        }
    }
}
