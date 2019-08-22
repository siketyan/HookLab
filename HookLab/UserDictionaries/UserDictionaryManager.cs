using System;
using System.Collections.Generic;
using HookLab.Models;
using HookLab.Targets;

namespace HookLab.UserDictionaries
{
    public class UserDictionaryManager
    {
        private readonly IEnumerable<IUserDictionary> _userDictionaries;

        public UserDictionaryManager(IEnumerable<IUserDictionary> userDictionaries)
        {
            _userDictionaries = userDictionaries;
        }

        public string Find(Notification notification, ITarget target)
        {
            foreach (var userDictionary in _userDictionaries)
            {
                if (userDictionary.Supports(notification, target))
                {
                    return userDictionary.Find(notification);
                }
            }
            
            throw new NotSupportedException(
                "The pair of provider and target is not supported yet."
            );
        }
    }
}
