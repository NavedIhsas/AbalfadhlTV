
namespace AbalfadhlTV.infrastructure.ConstMessages
{
    public static class ErrorMessage
    {
        public const string RecordNotFount = "رکوردی با این مشخصات یافت نشد";
        public const string RoleNameNotExist = "هیچ نقشی با این نام وجود ندارد لطفا نقش درستی را وارد کنید";
        public const string DuplicatedRecord = "این رکورد قبلا ثبت شده است";
        public const string ModelStateInvalid = "فیلد های مورد نیاز را به درستی پر کنید";
    }

    public static class EventMessage
    {
        public const string Success = "عملیات با موفقیت انجام شد";
    }
}
