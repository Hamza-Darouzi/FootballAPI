global using System;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Football.EF.Data;
global using Football.Core.Options;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Text;
global using Football.Domain.Services.Clubs;
global using Football.Domain.Services.Players;
global using Football.Domain.Services.Leagues;
global using Football.Domain.Services.Auth;
global using Football.Core.DTOs.Requests.Clubs;
global using Football.Core.DTOs.Requests.Leagues;
global using Football.Core.DTOs.Requests.Players;
global using Football.Domain.Repository;
global using Football.Domain.UOW;
global using Microsoft.OpenApi.Models;
global using Swashbuckle.AspNetCore.SwaggerUI;
global using Football.Core.DTOs.Requests.Auth;
global using Football.Domain.JWT;
global using System.Text.Json.Serialization;
