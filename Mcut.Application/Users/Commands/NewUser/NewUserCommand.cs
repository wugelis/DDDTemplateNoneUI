using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mcut.Application.Users.Commands.NewUser
{
    public class NewUserCommand : IRequest<bool>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
