namespace AbalfadhlTV.Application.Dtos
{
    public class BaseDto<T>
    {
        public BaseDto(bool isSuccess, List<string> message, T data )
        {
            this.IsSuccess = isSuccess;
            message ??= new List<string> {"عملیات با موفقیت انجام شد"};
          
            this.Message = message;
            this.Data = data;
        }

        public BaseDto( T data)
        {
            Data = data;
        }
        public T Data { get; private set; }
        public List<string> Message { get; private set; }
        public bool IsSuccess { get; private set; }

    }


    public class BaseDto
    {
        public BaseDto(bool isSuccess, List<string> message)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }
        public List<string> Message { get; private set; }
        public bool IsSuccess { get; private set; }
    }


}
