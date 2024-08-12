namespace TodoApi.Communication.Responses;

public class ResponseRegisterUserJson
    {
        public int Id {get; set;}
        public string UserName { get; set; } = string.Empty; // para a strindo caso nula vim vazia
    }

