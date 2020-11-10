using System;
using System.Collections.Generic;
using System.Linq;
using LoginExample.Models;

namespace LoginExample.Data.Impl {
public class InMemoryUserService : IUserService {
    private List<User> users;

    public InMemoryUserService() {
 
    }


    public User ValidateUser(string userName, string password) {
        User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
        if (first == null) {
            throw new Exception("User not found");
        }

        if (!first.Password.Equals(password)) {
            throw new Exception("Incorrect password");
        }

        return first;
    }
}
}