﻿using System.Threading.Tasks;
using Invest.Site.Core.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Invest.Site.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index ()
		{
			return View();
		}

		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> Login ()
		{
			LoginDTO model = new LoginDTO();
			return View(model);
		}

		[AllowAnonymous]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login (LoginDTO model)
		{
			if (ModelState.IsValid)
			{

			}

			return View(model);
		}

		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> Register()
		{
			RegisterDTO model = new RegisterDTO();
			return View(model);
		}

		[AllowAnonymous]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterDTO model)
		{
			if (ModelState.IsValid)
			{

			}

			return View(model);
		}

		[AllowAnonymous]
		public async Task<IActionResult> PasswordReset (string? email = null)
		{
			if (email != null)
			{

			}

			return View();
		}
	}
}