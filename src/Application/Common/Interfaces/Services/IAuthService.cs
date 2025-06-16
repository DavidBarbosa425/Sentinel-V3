using Application.Common.Models;
using Application.Common.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Services
{
    public interface IAuthService
    {
        Task<Result> RegisterAsync(RegisterDto dto);
        Task<Result> ConfirmUserEmailAsync(Guid id);
        Task<Result> LoginAsync(LoginDto dto);
        Task<Result> ForgotPasswordAsync(ForgotPasswordDto dto);
        Task<Result> ResetPasswordAsync(ResetPasswordDto dto);
    }
}
