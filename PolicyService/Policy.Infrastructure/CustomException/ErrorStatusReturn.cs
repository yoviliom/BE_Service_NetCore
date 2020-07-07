using System.ComponentModel.DataAnnotations;

namespace Policy.Infrastructure.Exception
{
    public enum ErrorStatusReturn
    {

        [Display(Name = "Dữ liệu request không hợp lệ")]
        REQUEST_NULL,

        [Display(Name = "Không tìm thấy dữ liệu yêu cầu")]
        NOT_FOUND,

        [Display(Name = "Lỗi hệ thống, vui lòng liên hệ Administrator")]
        SYSTEM_ERROR,

        SUCCESS,
        MODEL_NOT_VALID,

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