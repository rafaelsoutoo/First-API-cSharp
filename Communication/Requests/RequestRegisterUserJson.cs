namespace TodoApi.Communication.Requests;

public class RequestRegisterUserJson
    {
        public string Name { get; set; } = string.Empty; // para a strindo caso nula vim vazia
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

