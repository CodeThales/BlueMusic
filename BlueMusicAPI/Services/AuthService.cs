﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueMusicAPI.Services
{
    public class AuthService : IAuthService
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;

        public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<SignInResult> GetUser(IdentityUser identityUser)
        {
            var user = await _userManager.FindByEmailAsync(identityUser.Email);
            var result = await _signInManager.CheckPasswordSignInAsync(user, identityUser.PasswordHash, false);
            return result;
        }

        public async Task<IdentityResult> Create(IdentityUser identityUser)
        {
            var result = await _userManager.CreateAsync(identityUser, identityUser.PasswordHash);
            return result;
        }


    }
}
