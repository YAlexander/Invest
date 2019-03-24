using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Invest.Site.Core.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace Invest.Site.Core.Security
{
	public class AuthService
	{
		private readonly AppSettings _appSettings;

		public AuthService (IOptions<AppSettings> appSettings)
		{
			_appSettings = appSettings.Value;
		}

		//public Customer? Authenticate (string username, string password)
		//{
		//	Customer? user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

		//	if (user == null)
		//	{
		//		return null;
		//	}

		//	// authentication successful so generate jwt token
		//	JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
		//	byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
		//	SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
		//	{
		//		Subject = new ClaimsIdentity(new Claim[]
		//		{
		//			new Claim(ClaimTypes.Name, user?.Email ?? string.Empty)
		//		}),
		//		Expires = DateTime.UtcNow.AddHours(1),
		//		SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
		//	};

		//	SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
		//	user.Token = tokenHandler.WriteToken(token);

		//	// remove password before returning
		//	user.Password = null;

		//	return user;
		//}

		public void CreatePasswordHash (string password, out byte[] passwordHash, out byte[] passwordSalt)
		{
			using (var hmac = new HMACSHA512())
			{
				passwordSalt = hmac.Key;
				passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
			}
		}

		public bool VerifyPasswordHash (string password, byte[] passwordHash, byte[] passwordSalt)
		{
			using (HMACSHA512 hmac = new HMACSHA512(passwordSalt))
			{
				byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

				for (int i = 0; i < computedHash.Length; i++)
				{
					if (computedHash[i] != passwordHash[i])
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}
