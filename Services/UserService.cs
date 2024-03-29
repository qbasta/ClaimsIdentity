﻿using ClaimsIdentity.Interfaces;
using ClaimsIdentity.Models;
using ClaimsIdentity.ViewModels.User;

namespace ClaimsIdentity.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public void Insert(User user)
        {
            _userRepo.Insert(user);
        }

        public ListUserViewModel GetPeople()
        {
            var people = _userRepo.GetPeople();

            ListUserViewModel result = new ListUserViewModel();
            result.People = new List<UserViewModel>();

            foreach (var user in people)
            {
                // mapowanie obiektow
                var pVM = new UserViewModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    Year = user.Year,
                    Result = user.Result,
                    CreatedTime = user.CreatedTime,
                    OwnerId = user.OwnerId,
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;

            return result;
        }

        public ListUserViewModel GetTodayPeople()
        {
            var people = _userRepo.GetTodayPeople();

            ListUserViewModel result = new ListUserViewModel();
            result.People = new List<UserViewModel>();

            foreach (var user in people)
            {
                // mapowanie obiektow
                var pVM = new UserViewModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    Year = user.Year,
                    Result = user.Result,
                    CreatedTime = user.CreatedTime,
                    OwnerId = user.OwnerId,
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;

            return result;
        }
    }
}
