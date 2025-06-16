using Application.Common.Models;
using Application.Common.Models.DTOs;

namespace API.Services
{
    public class AuthService
    {
        public async Task<Result> RegisterAsync(RegisterDto dto)
        {
            return Result.Ok("E-mail de confirmação enviado com sucesso! Confira sua caixa de entrada.");
        }

        public async Task<Result> ConfirmUserEmailAsync(Guid id)
        {

            return Result.Ok("E-mail confirmado com sucesso!");

        }

        public async Task<Result> ForgotPasswordAsync(ForgotPasswordDto dto)
        {

            return Result.Ok("E-mail de recuperar senha enviado com sucesso! Confira sua caixa de entrada.");

        }

        public async Task<Result> ResetPasswordAsync(ResetPasswordDto dto)
        {

            return Result.Ok("Senha redefinida com sucesso! Você pode fazer login agora.");
        }

        public async Task<Result> LoginAsync(LoginDto dto)
        {

            return Result<string>.Ok("", "pega o token ai");
        }
    }
}
