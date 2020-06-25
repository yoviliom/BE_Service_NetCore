namespace Policy.Infrastructure.Exception
{
    public enum ErrorStatusReturn
    {
        SUCCESS,
        MODEL_NOT_VALID,
        SYSTEM_ERROR,

        NOT_FOUND,
        CAN_NOT_LOGIN_DASHBOARD,
        USER_HAS_REGISTER,
        CAN_NOT_LOGIN_FRONTEND,
        NOT_INVITED,
        EMAIL_EXISTED,

        EMAIL_NOT_FOUND,
        FULLNAME_NOT_FOUND,
        ADDRESS_DETAIL_NOT_FOUND,
        WORKING_PLACE_NOT_FOUND,
        TITLE_NOT_FOUND,
        PROVINCE_NOT_FOUND,
        NOT_APPROVED_POLICY,
        CAN_NOT_CREATE_ACCOUNT,
        FORMAT_DATA_INVALID
    }
}